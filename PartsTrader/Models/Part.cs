using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartsTrader.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string PartCode { get; set; }

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        public Part(string number, string description)
        {
            PartNumber = PartId+"-"+PartCode;
            PartDescription = description;
        }
    }
}