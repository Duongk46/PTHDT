using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Admin.Models;
using Mvc.Extensions;
using System;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserBusiness _userBusiness;
        public HomeController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            try
            {
                var check = _userBusiness.CheckLogin(username, password);
                if (check == 1)
                {
                    var loginModel = new LoginModel();
                    loginModel.Username = username;
                    loginModel.Password = password;
                    HttpContext.Session.Set<LoginModel>("LoginModel", loginModel);
                    return Redirect("/Admin/Home");
                }
                else
                {
                    if (check == 2)
                    {
                        ViewBag.Message = "Tài khoản không tồn tại";
                    }
                    else
                    {
                        ViewBag.Message = "Sai mật khẩu";
                    }
                }
                
            }
            catch(Exception ex)
            {
                return View();
            }
            return View();
        }
    }
}
