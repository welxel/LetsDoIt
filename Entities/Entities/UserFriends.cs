using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Records.Bases;

namespace Entities.Entities {
    public class UserFriends:RecordBase {
        public int IDUser { get; set; }
        public int FormToUserID { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
    }
}
