using HelloWorldAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using HelloWorldAPI.Model;

namespace MSUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHelloWorldTest()
        {
            MessageController messageController = new MessageController();
            var message = messageController.GetHelloWorld();
            Assert.Equals("Hello World", message);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task WebGetHelloWorldTestAsync()
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format("http://demoapihelloworld.azurewebsites.net/api/message", string.Empty));
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var message = new Message(content);
                Assert.AreEqual("Hello World", message.ToString());
            }
            else
            {
                Assert.Fail("Something might be wrong with the web serivce!");
            }
        }
    }
}
