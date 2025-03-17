using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace WebApp.Areas.Dashboard.Controllers
{
    [Area("dashboard")]
    public class CategoryController : BaseController
    {
        IStringLocalizer<CategoryController> localizer;

        public CategoryController(IStringLocalizer<CategoryController> localizer) =>
            this.localizer = localizer;

        public IActionResult Index()
        {
            ViewData["Title"] = localizer["Title"];
            ViewData["Description"] = localizer["Description"];
            return View(Provider.Category.GetCategories());
        }
    }
}
