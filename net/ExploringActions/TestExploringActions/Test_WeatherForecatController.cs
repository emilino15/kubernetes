using ExploringActions;
using ExploringActions.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestExploringActions
{
    public class UnitTest1
    {
        [Fact]
        public void Test_WeatherForecastController()
        {
            // Arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);
            // Act
            var result = controller.Get();
            // Assert
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
        }
    }
}
