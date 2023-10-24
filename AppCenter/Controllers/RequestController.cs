using Microsoft.AspNetCore.Mvc;

namespace AppCenter.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
    }
}
