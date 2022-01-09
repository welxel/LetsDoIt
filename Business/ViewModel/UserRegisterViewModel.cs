using Business.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModel {
    public class UserRegisterViewModel {
        public UserRegisterModel userRegisterModel { get; set; }
        public IFormFile formFile { get; set; }
    }
}
