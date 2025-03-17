using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            this.localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = localizer["Title"];
            ViewData["Description"] = localizer["Description"];
            return View();
        }
    }
}