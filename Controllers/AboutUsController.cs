namespace oldCapitalWeb.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using oldCapitalWeb.Models;
    using oldCapitalWeb.Services.Home;

    using static ArticleConstants.Constants.AboutUsPageArticles;
    public class AboutUsController : Controller
    {

        public IActionResult Index()
        {
            var articleList = new List<ArticleViewModel>();

            var headArticle = new ArticleViewModel
            {
                Id = FrontEndHeadId,
                Title = HeadTitle,
                Text = HeadArticleText,
            };
            articleList.Add(headArticle);

            var firstArticle = new ArticleViewModel
            {
                Id = FrontEndArticleOneId,
                Title = SecondArticleTitle,
                Text = SecondArticleText,
            };
            articleList.Add(firstArticle);

            var secondArticle = new ArticleViewModel
            {
                Id = FrontEndArticleTwoId,
                Title = ThirdArticleTitle,
                Text = ThirdArticleText,
            };
            articleList.Add(secondArticle);

            return View(articleList);
        }
    }
}
