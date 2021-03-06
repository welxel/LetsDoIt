using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.MobilAppModel
{
    public class TodoModel:RecordBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Color { get; set; }
        public int IDUser { get; set; }
        public List<TodoEventModel> TodoEventModels { get; set; }
    }
}
