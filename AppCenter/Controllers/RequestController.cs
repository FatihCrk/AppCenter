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
        public IActionResult Apply([FromForm]Requester model) //FromForm yalnız formdan gelen modeli kabul eder.
        {

            Repository.Add(model);
            return RedirectToAction("/");
        }
    }
}
