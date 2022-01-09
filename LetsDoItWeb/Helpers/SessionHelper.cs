using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Business.Models;

namespace LetsDoItWeb.Helpers {
    public class SessionHelper {

        private string _user { get; set; } = "user";
        public IHttpContextAccessor _httpContext { get; set; }
        public SessionHelper(IHttpContextAccessor httpContext) {
            _httpContext = httpContext;
        }


        public bool checkLogined() {

            return getCurrentUser() != null;
        }

        public UserRegisterModel getCurrentUser() {
            var user = _httpContext.HttpContext.Session.Get(_user);

            if (user == null)
                return null;


            var userjson = System.Text.Encoding.UTF8.GetString(user);
            UserRegisterModel userRegisterModel = Newtonsoft.Json.JsonConvert.DeserializeObject<UserRegisterModel>(userjson);
            return userRegisterModel;
        }

        public void setSession(UserRegisterModel user) {
            var userJson = System.Text.Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(user));
            _httpContext.HttpContext.Session.Set(_user, userJson);
        }

        public void setSession<T>(string key, T model) {
            var modelJson = System.Text.Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(model));
            _httpContext.HttpContext.Session.Set(key, modelJson);
        }
        public T getObject<T>(string key) {
            var model = _httpContext.HttpContext.Session.Get(key);

            if (model == null)
                return default(T);

            var modelJson = System.Text.Encoding.UTF8.GetString(model);
            T sessionModel = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(modelJson);
            return sessionModel;
        }


        public void clearSesion() {
            _httpContext.HttpContext.Session.Set(_user, null);

        }


    }
}
