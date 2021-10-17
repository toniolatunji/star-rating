using Microsoft.Extensions.DependencyInjection;
using StarRating.Service.Contract;
using System;

namespace StarRating.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceRegistration.GetServiceProvider();

            var starRatingService = serviceProvider.GetService<IStarRatingService>();

            Console.WriteLine("===============Star Rating===================\n");

            Console.WriteLine("Get equivalent Star Rating for provided score iteratively. Press Ctrl C on the keyboard to stop and exit\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Enter score (int or double): ");

                Console.ForegroundColor = ConsoleColor.White;

                var input = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Output: ");

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write(starRatingService.StarRating(input));

                Console.WriteLine("\n");
            }
        }
    }
}
