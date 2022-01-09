using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class TodoEvent : RecordBase
    {
        public DateTime EventDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public int IDTodo { get; set; }
        public Todo Todo { get; set; } 
        public int IDUser { get; set; }
        public User User { get; set; }
        public bool AllDay { get; set; }
    }
}
