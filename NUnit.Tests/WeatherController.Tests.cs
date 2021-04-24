using ASP.NET.IntegraionTestExample;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    public class WeatherControllerTests
    {
        WebApplicationFactory<Startup> _factory = new WebApplicationFactory<Startup>();

        [Test]
        public async Task TestWeatherForecast()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/WeatherForecast");

            // Assert
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.AreNotEqual("hi", responseString);
        }
    }
}