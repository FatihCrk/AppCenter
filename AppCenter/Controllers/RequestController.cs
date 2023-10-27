using Microsoft.AspNetCore.Mvc;
using AppCenter.Models;

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

        [HttpPost]
        public IActionResult Apply(Requester model)
        {

            Repository.Add(model);
            return RedirectToAction("/");
        }
    }
}
