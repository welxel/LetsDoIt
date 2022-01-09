using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Records.Bases;

namespace Business.Models {
    public class MessageModel:RecordBase {
        public string Body { get; set; }
        public DateTime SendingTime { get; set; }
        public DateTime? LastSeenTime { get; set; }
    }
}
