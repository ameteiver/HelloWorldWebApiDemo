using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldAPI.Model;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        // GET api/Message
        [HttpGet]
        public string GetHelloWorld()
        {
            return new Message("Hello World").ToString();
        }
        /// <summary>
        /// returns the value of msg parameter passed by the user in the URL 
        /// </summary>
        /// <returns>The parrot.</returns>
        /// <param name="msg">Message.</param>
        // GET api/Message/parrot/msg
        [HttpGet("parrot/{msg}")]
        public string GetParrot(string msg)
        {
            return new Message(msg).ToString();
        }
        // GET api/Message/
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Message.Get(id).ToString();
        }
        // POST api/Message
        [HttpPost]
        public void Create([FromBody]string value)
        {
            //To do - This where the server would save new messages to the database
        }
        // POST api/Message
        [HttpPost]
        public void Update([FromBody]string value)
        {
            //To do - This where the server would save new messages to the database
        }
        // DELETE api/Message/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
