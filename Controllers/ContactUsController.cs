namespace oldCapitalWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
