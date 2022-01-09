using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.MobilAppModel
{
    public class TodoEventModel: RecordBase
    {
        public DateTime EventDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public int IDTodo { get; set; }
        public int IDUser { get; set; }
        public byte AllDay { get; set; }
    }
}
