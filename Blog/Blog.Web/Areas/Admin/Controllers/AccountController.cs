using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}