using Microsoft.Extensions.DependencyInjection;
using StarRating.Service.Contract;
using StarRating.Service.Implementation;

namespace StarRating.ConsoleApp
{
    public class ServiceRegistration
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IStarRatingService, StarRatingService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
