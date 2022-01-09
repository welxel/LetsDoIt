using AppCore.Records.Bases;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class ContactModel : RecordBase
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int IDUser { get; set; }
        public User User { get; set; }
    }
}
