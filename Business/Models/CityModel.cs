using AppCore.Records.Bases;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class CityModel : RecordBase
    {
        public int IDCountry { get; set; }
        public string Name { get; set; }
   
    }
}
