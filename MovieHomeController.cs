using Microsoft.AspNetCore.Mvc;

namespace MovieOnlineStoreProject.Controllers
{
    public class MovieHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
