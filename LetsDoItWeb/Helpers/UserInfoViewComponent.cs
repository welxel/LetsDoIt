using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDoItWeb.Helpers
{
    public class UserInfoViewComponent:ViewComponent
    {
        private readonly SessionHelper _sessionHelper;
        
        public UserInfoViewComponent(SessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            await Task.CompletedTask;
            return View( _sessionHelper.getCurrentUser());
        }
    }
}
