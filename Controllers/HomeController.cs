namespace oldCapitalWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using oldCapitalWeb.Models;
    using oldCapitalWeb.Services.Home;
    using System.Diagnostics;
    using static ArticleConstants.Constants.HomePageArticles;
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            this.logger = logger;
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            var upperArticle = new ArticleViewModel
            {
                Id = FrontEndId,
                Title = FirstArticleTitle,
                Text = FirstArticleText,
            };

            return View(upperArticle);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}