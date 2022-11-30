using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Mvc.Areas.Admin.Models;
using Mvc.Extensions;

namespace Mvc.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var loginModel = HttpContext.Session.Get<LoginModel>("LoginModel");
            if (loginModel == null)
            {
                context.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new {controller = "Home",action = "Index"}));
            }
            base.OnActionExecuting(context);
        }
    }
}
