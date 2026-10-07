using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ProfileSelectController : Controller
    {
        public IActionResult ProfileSelect()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
