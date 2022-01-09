using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class TodoEventModel : RecordBase
    {
        public int IDTodo { get; set; }
        public int IDUser { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string Description { get; set; }
        public string strDate { get; set; }
        public string strEndDate { get; set; }
        public bool AllDay { get; set; }
        public string Url { get; set; }
    }
}
