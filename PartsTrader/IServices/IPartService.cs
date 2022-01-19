using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PartsTrader.Models;

namespace PartsTrader.IServices
{
    public class IPartService
    {
        public bool ValidatePartNumber(string partnumber);
        public List<Part> CheckExclusionList(List<Part> list);
        public Part LookupCompatibleParts(string partNumber);
    }
}