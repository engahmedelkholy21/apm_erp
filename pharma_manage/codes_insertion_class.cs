using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharma_manage
{
    class codes_insertion_class
    {

        public class Rootobject
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public string codeType { get; set; }
            public string parentCode { get; set; }
            public string itemCode { get; set; }
            public string codeName { get; set; }
            public string codeNameAr { get; set; }
            public DateTime activeFrom { get; set; }
            public DateTime activeTo { get; set; }
            public string description { get; set; }
            public string descriptionAr { get; set; }
            public string requestReason { get; set; }
        }

    }
}
