using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;

namespace pharma_manage
{
    public partial class face_login : Form
    {

        // Video capture objects.
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        // Face detector using Accord.NET.
        private HaarObjectDetector faceDetector;
        // The enrolled (saved) face image.
        private Bitmap enrolledFace = null;

        public face_login()
        {
            InitializeComponent();
            // Initialize video devices.
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                this.Close();
            }

            // Use the first available device.
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);

            // Initialize Accord's face detector with its built-in face cascade.
            faceDetector = new HaarObjectDetector(new FaceHaarCascade(), 30);
            faceDetector.SearchMode = ObjectDetectorSearchMode.Average;
            faceDetector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller;
            faceDetector.ScalingFactor = 1.5f;
            faceDetector.UseParallelProcessing = true;
            faceDetector.Suppression = 3;
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Clone the frame once immediately
            Bitmap frameClone = (Bitmap)eventArgs.Frame.Clone();

            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new Action(() =>
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    // Use the already cloned image
                    pictureBox1.Image = frameClone;
                }));
            }
            else
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = frameClone;
            }

            // Optionally, dispose the original frame if needed
            // eventArgs.Frame.Dispose(); 
        }
        private void face_login_Load(object sender, EventArgs e)
        {

        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (!videoSource.IsRunning)
                videoSource.Start();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (!videoSource.IsRunning)
            {
                MessageBox.Show("Camera is not running.");
                return;
            }
            // Subscribe temporarily to capture one frame for enrollment.
            videoSource.NewFrame += CaptureFrameForEnrollment;
        }


        // Capture one frame and process it for enrollment.
        private void CaptureFrameForEnrollment(object sender, NewFrameEventArgs eventArgs)
        {
            // Unsubscribe immediately to capture just one frame.
            videoSource.NewFrame -= CaptureFrameForEnrollment;

            // Clone the frame so we can safely pass it to our method.
            Bitmap capturedFrame = (Bitmap)eventArgs.Frame.Clone();

            // Call the enrollment method.
            ProcessEnrollmentFrame(capturedFrame);

            // Dispose the captured frame.
            capturedFrame.Dispose();
        }
        private void ProcessEnrollmentFrame(Bitmap frame)
        {
            try
            {
                // Convert the frame to grayscale using AForge's Grayscale filter.
                Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
                Bitmap grayFrame = grayscaleFilter.Apply(frame);

                // (Optional) Save the grayscale frame for debugging:
                // grayFrame.Save("debug_grayFrame.jpg");

                // Initialize the face detector with Accord's FaceHaarCascade.
                HaarObjectDetector faceDetector = new HaarObjectDetector(new FaceHaarCascade(), 30);
                faceDetector.SearchMode = ObjectDetectorSearchMode.Average;
                faceDetector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller;
                faceDetector.ScalingFactor = 1.1f;   // Use a smaller scaling factor for finer detection.
                faceDetector.UseParallelProcessing = true;
                faceDetector.Suppression = 2;

                // Process the grayscale image to detect faces.
                Rectangle[] faces = faceDetector.ProcessFrame(grayFrame);

                if (faces != null && faces.Length > 0)
                {
                    // For enrollment, we take the first detected face.
                    Rectangle faceRect = faces[0];

                    // Crop the image to the detected face region.
                    Crop cropFilter = new Crop(faceRect);
                    Bitmap faceBmp = cropFilter.Apply(grayFrame);

                    // Resize the cropped face to a standard size (e.g., 100 x 100 pixels).
                    ResizeNearestNeighbor resizeFilter = new ResizeNearestNeighbor(100, 100);
                    Bitmap normalizedFace = resizeFilter.Apply(faceBmp);

                    // Save the normalized face image (you can also store it in a variable for later use).
                    normalizedFace.Save("enrolled_face.jpg");

                    MessageBox.Show("Enrollment complete!");

                    // Clean up the temporary images.
                    faceBmp.Dispose();
                    normalizedFace.Dispose();
                }
                else
                {
                    MessageBox.Show("No face detected during enrollment.");
                }

                // Dispose the grayscale image.
                grayFrame.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during enrollment: " + ex.Message);
            }
        }
        private void btnRecognize_Click(object sender, EventArgs e)
        {
            if (enrolledFace == null)
            {
                MessageBox.Show("Please enroll a face first.");
                return;
            }
            // Subscribe temporarily to capture one frame for recognition.
            videoSource.NewFrame += CaptureFrameForRecognition;
        }
        // Capture one frame and process it for recognition.
        private void CaptureFrameForRecognition(object sender, NewFrameEventArgs eventArgs)
        {
            // Unsubscribe to run this only once.
            videoSource.NewFrame -= CaptureFrameForRecognition;

            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            // Convert to grayscale.
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayFrame = grayscaleFilter.Apply(frame);

            // Detect faces.
            Rectangle[] faces = faceDetector.ProcessFrame(grayFrame);
            if (faces.Length > 0)
            {
                // Crop the first detected face.
                Crop cropFilter = new Crop(faces[0]);
                Bitmap liveFaceBmp = cropFilter.Apply(grayFrame);

                // Resize to match the enrolled face size.
                ResizeNearestNeighbor resizeFilter = new ResizeNearestNeighbor(100, 100);
                Bitmap normalizedLiveFace = resizeFilter.Apply(liveFaceBmp);

                // Compare the live face with the enrolled face using template matching.
                ExhaustiveTemplateMatching templateMatching = new ExhaustiveTemplateMatching(0.9f);
                TemplateMatch[] matchings = templateMatching.ProcessImage(normalizedLiveFace, enrolledFace);

                if (matchings.Length > 0)
                {
                    MessageBox.Show("Face recognized. Login successful!");
                }
                else
                {
                    MessageBox.Show("Face not recognized.");
                }

                normalizedLiveFace.Dispose();
                liveFaceBmp.Dispose();
            }
            else
            {
                MessageBox.Show("No face detected in the current frame.");
            }

            grayFrame.Dispose();
            frame.Dispose();
        }

        private void face_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
