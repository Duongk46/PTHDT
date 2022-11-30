using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Admin.Models;
using Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Set<LoginModel>("LoginModel", null);
            return Redirect("/");
        }
    }
}
