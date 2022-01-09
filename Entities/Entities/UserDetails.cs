using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class UserDetails : RecordBase
    {
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Jop { get; set; }
        public string InstagramAdress { get; set; }
        public string TwitterAdress { get; set; }
        public string BlogAdress { get; set;}
        public string YoutubeAdress { get; set; }
        public User User { get; set; }
    }
}