using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Records.Bases;
using Entities.Entities;

namespace Business.Models {
    public class UserFirendModel:RecordBase {
        public int IDUser { get; set; }
        public int FormToUserID { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public User FormToUser { get; set; }
    }
}
