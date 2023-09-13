using oldCapitalWeb.Services.Articles;
using oldCapitalWeb.Services.FaQ;
using oldCapitalWeb.Services.Home;

namespace oldCapitalWeb.Extensions
{
    public static class OldCapitalWebServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFaQService, FaQservice>();

            services.AddScoped<IArticleService, ArticleService>();

            return services;
        }
    }
}
