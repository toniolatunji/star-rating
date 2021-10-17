using StarRating.Service.Contract;
using System;

namespace StarRating.Service.Implementation
{
    public class StarRatingService : IStarRatingService
    {
        public string StarRating(string input)
        {
            var ratingScore = Convert.ToDouble(input);

            string rating = string.Empty;

            for (var starCount = 0; starCount < 5; starCount++)
            {
                if (ratingScore >= 1)
                {
                    rating += "full ";
                }
                else if (ratingScore > 0)
                {
                    if (ratingScore + 0.25 >= 0.5)
                    {
                        rating += "half ";
                    }
                    else
                    {
                        rating += "empty ";
                    }
                }
                else
                {
                    rating += "empty ";
                }

                ratingScore -= 1;
            }

            return rating.Trim();
        }
    }
}
