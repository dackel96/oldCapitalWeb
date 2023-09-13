using oldCapitalWeb.Models;

namespace oldCapitalWeb.Services.Home
{
    public interface IArticleService
    {
        public Task GetHomePageArticleAsync(Guid id);

        public Task EditArticleAsync(Guid id, ArticleViewModel model);

        public Task DeleteArticleAsync(Guid id);

        public Task AddArticleAsync(string title, string text);
    }
}