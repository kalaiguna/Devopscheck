using Xunit;
using Moq;
using myapi.Controllers;
using Microsoft.Extensions.Logging;

namespace myapitest
{
    public class MyapiControllerTest
    {
        [Fact]
        public void SayHello_WithText_ReturnsTrue()
        {
            Mock<ILogger<MyAPIController>> logstub = new Mock<ILogger<MyAPIController>>();
            var api = new MyAPIController(logstub.Object);
            Assert.Equal("Hello Pokemon!", api.SayHello("Pokemon"));
        }
    }
}
