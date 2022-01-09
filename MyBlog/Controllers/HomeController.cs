using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MyBlog.Models;

namespace MyBlog.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserMailInfo userMailInfo) {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("furkaanbektas@gmail.com", "jackal333");
                MailMessage msj = new MailMessage();
                msj.From = new MailAddress(userMailInfo.EMail, userMailInfo.UserName);
                msj.To.Add("furkaanbektas@gmail.com");
                msj.Subject = userMailInfo.Title + "" + userMailInfo.EMail;
                msj.Body = userMailInfo.Message;
                client.EnableSsl = true;
                client.Send(msj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return View();
        }
    }

}
