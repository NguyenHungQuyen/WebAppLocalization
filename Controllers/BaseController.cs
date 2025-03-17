using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        SiteProvider? provider;

        protected SiteProvider Provider => provider
            ??= HttpContext.RequestServices.GetRequiredService<SiteProvider>();
    }
}
