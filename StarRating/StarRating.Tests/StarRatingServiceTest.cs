using NUnit.Framework;
using StarRating.Service.Contract;
using StarRating.Service.Implementation;

namespace StarRating.Tests
{
    public class Tests
    {
        [TestCase("0.15", ExpectedResult = "empty empty empty empty empty")]
        [TestCase("0.38", ExpectedResult = "half empty empty empty empty")]
        [TestCase("1.10", ExpectedResult = "full empty empty empty empty")]
        [TestCase("1.54", ExpectedResult = "full half empty empty empty")]
        [TestCase("2", ExpectedResult = "full full empty empty empty")]
        [TestCase("2.38", ExpectedResult = "full full half empty empty")]
        [TestCase("2.75", ExpectedResult = "full full half empty empty")]
        [TestCase("3.22", ExpectedResult = "full full full empty empty")]
        [TestCase("3.52", ExpectedResult = "full full full half empty")]
        [TestCase("4.05", ExpectedResult = "full full full full empty")]
        [TestCase("4.25", ExpectedResult = "full full full full half")]
        [TestCase("4.5", ExpectedResult = "full full full full half")]
        [TestCase("5", ExpectedResult = "full full full full full")]
        public string StarRating_Returns_TheCorrectListOfStars(string ratingScore)
        {
            IStarRatingService starRatingService = new StarRatingService();

            return starRatingService.StarRating(ratingScore);
        }
    }
}