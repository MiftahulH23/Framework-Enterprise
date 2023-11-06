using Microsoft.AspNetCore.Mvc;

namespace MvcMovieMiftahul.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
