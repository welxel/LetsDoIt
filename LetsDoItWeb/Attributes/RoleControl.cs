using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace LetsDoItWeb.Attributes {
    public class RoleControl : ActionFilterAttribute {
        public RoleControl() {
        }

        public override void OnActionExecuting(ActionExecutingContext context) {
            byte[] test;
            var user = context.HttpContext.Session.TryGetValue("user", out test);
            if (user) {
                var modelJson = System.Text.Encoding.UTF8.GetString(test);
                UserRegisterModel sessionModel = Newtonsoft.Json.JsonConvert.DeserializeObject<UserRegisterModel>(modelJson);
                if (sessionModel == null) {
                    throw new Exception("UnAuthorizated");
                } else {
                    if (sessionModel.Role == "admin") {

                    } else {
                        context.HttpContext.Response.Redirect("/Error/Index");
                    }
                }
            } else {
                throw new Exception("AnAuthorized");
            }
            base.OnActionExecuting(context);
        }
    }
}
