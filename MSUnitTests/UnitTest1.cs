using HelloWorldAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MessageController messageController = new MessageController();
            var message = messageController.GetHelloWorld();
            Assert.Equals("Hello Wld", message);
        }
    }
}
