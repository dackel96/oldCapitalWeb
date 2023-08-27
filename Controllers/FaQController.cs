namespace oldCapitalWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using oldCapitalWeb.Models;
    using oldCapitalWeb.Services.FaQ;

    public class FaQController : Controller
    {
        private readonly IFaQService faqService;

        public FaQController(IFaQService faqService)
        {
            this.faqService = faqService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new FaQViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FaQViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.faqService.AddFaQAsync(model.Question, model.Answer);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
