using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.MobilAppModel
{
    public class LoginModel:RecordBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Token { get; set; }
    }
}
