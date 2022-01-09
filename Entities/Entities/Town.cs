using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Town : RecordBase
    {

        public string Name { get; set; }
        public int IDCity { get; set; }
        public City City { get; set; }
        public List<User> User  { get; set; }
    }
}
