using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Records.Bases;
using Entities.Entities;

namespace Business.Models {
    public class UserMessageModel:RecordBase {
        public int UserID { get; set; }
        public int MessageID { get; set; }

        public User User { get; set; }
    }
}
