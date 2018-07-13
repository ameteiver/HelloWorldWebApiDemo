using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericEmailService.Models;
using Microsoft.AspNetCore.Mvc;
using GenericEmailService.Services;

namespace GenericEmailService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IEmailService _emailService;
        public ValuesController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("{From}/{ReplyTo}/{Body}")]
        public string SendEmail(string From, string ReplyTo, string Body)
        {
            var from = new EmailAddress("Web Site Notifications", "websitenotifications@drmader.com");
            var to = new EmailAddress("Mader", "leeann@drmader.com");
            var replyTo = new EmailAddress(From, ReplyTo);
                
            var msg = new EmailMessage();
            msg.Content = Body;

            //msg.FromAddresses = new List<EmailAddress>();
            msg.FromAddresses.Add(from);
            msg.ToAddresses.Add(to);
            msg.ReplyToAddresses.Add(replyTo);
            msg.Subject = "Request from Dr. Mader Site";

            try
            {
                _emailService.Send(msg);
                return "Email Sent!";
            }
            catch(Exception e)
            {
                while (e.InnerException != null) e = e.InnerException;
                return e.Message;
            }
        }

    }
}
