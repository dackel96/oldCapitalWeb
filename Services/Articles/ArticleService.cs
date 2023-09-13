using AutoMapper;
using oldCapitalWeb.Data;
using oldCapitalWeb.Data.Models;
using oldCapitalWeb.Models;
using oldCapitalWeb.Services.Home;

namespace oldCapitalWeb.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly ApplicationDbContext data;
        private readonly IMapper mapper;

        public ArticleService(ApplicationDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public async Task AddArticleAsync(string title, string text)
        {
            var article = new Article
            {
                Title = title,
                Text = text
            };

            await data.Articles.AddAsync(article);
            await data.SaveChangesAsync();

            return;
        }

        public Task DeleteArticleAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EditArticleAsync(Guid id, ArticleViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task GetHomePageArticleAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
