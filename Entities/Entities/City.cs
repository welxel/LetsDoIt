using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class City : RecordBase
    {
        public int IDCountry { get; set; }
        public string Name { get; set; }
        public List<User> User { get; set; }
        public List<Town> Towns { get; set; }
    }
}
