using NUnit.Framework;

namespace DockerSelfhostWebApi.Tests
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void HelloWorldTest()
        {
            var controller = new DockerSelfhostWebApi.DemoController();

            var result = controller.HelloWorld();

            Assert.That(result, Is.StringMatching(@"Hello, cosmos! Said at \d{2}:\d{2}"));
        }
    }
}
