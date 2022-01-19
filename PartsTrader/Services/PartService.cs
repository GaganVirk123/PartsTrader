using Newtonsoft.Json;
using PartsTrader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Collections;

namespace PartsTrader.Services
{
    public class PartService
    {
        public class EmployeeService : IPartService
        {
            public bool ValidatePartNumber(string partNumber)
            {
                if(partNumber != null)
                {
                    var parts = partNumber.Split('-');
                    var partId = parts[0];
                    var partCode = parts[1];
                    var toNumber = 0;
                    bool canConvert = long.TryParse(partId, out toNumber);
                    if (canConvert == true)
                    {
                        bool partNumberValidated = partNumber.ToCharArray().Count(c => c == 'a') == 4;
                    }
                }
                return false; 
            }
            public List<Part> CheckExclusionList(List<Part> list)
            {
                using (StreamReader r = new StreamReader("Exclusions.json"))
                {
                    string json = r.ReadToEnd();
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        var parts = item.PartNumber.split('-');
                        var partId = parts[0];
                        var partCode = parts[1];
                        foreach(Part partList in list)
                        {
                            if(partList.PartId == partId && partList.PartCode == partCode)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            public Part LookupCompatibleParts(string partNumber)
            {

            }
        }
    }
}