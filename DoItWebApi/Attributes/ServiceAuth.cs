using AppCore.Business.Models.Results;
using Business.Models.MobilAppModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoItWebApi.Attributes {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ServiceAuth : Attribute,IAuthorizationFilter {

        public ServiceAuth() {

        }

        public void OnAuthorization(AuthorizationFilterContext context) {
            string thisToken = context.HttpContext.Request.Headers["Authorization"];

            var user = (LoginModel)context.HttpContext.Items[thisToken];
            if (user != null) {

            }
            context.Result = new JsonResult(new { message = "You are not authorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}
