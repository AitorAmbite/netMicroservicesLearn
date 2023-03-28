using Basket.API.Repositories;

namespace Basket.API
{
    public class StartUp
    {
        //public IConfiguration Configuration { get; set; }
        //public StartUp(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        public static void configureServices(IServiceCollection services,IConfiguration configuration) {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<String>("CacheSettings:ConnectionString");

            });
            services.AddScoped<IBasketRepository, BasketRepository>();
        }
    }
}
