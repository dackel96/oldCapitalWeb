using oldCapitalWeb.Services.FaQ;

namespace oldCapitalWeb.Extensions
{
    public static class OldCapitalWebServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFaQService,FaQservice>();

            return services;
        }
    }
}
