using Microsoft.AspNetCore.Mvc;

namespace oldCapitalWeb.Controllers
{
    public class ArtistsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
