using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class TownModel : RecordBase
    {
        public string Name { get; set; }
        public int IDCity { get; set; }
    }
}
