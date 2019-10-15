using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetMailer;
using DotnetMailer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmailApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public ValuesController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var senderEmailAddress = new List<EmailAddress>() { new EmailAddress()
            {
                Name="vikram",
                Address="vshahks4578@gmail.com"
            } };
            var receiverEmialAddress = new List<EmailAddress>() { new EmailAddress()
            {
                Name="vikram",
                Address="vshahk4578@gmail.com"
            } };
            var email = new EmailMessage()
            {
                FromAddresses = senderEmailAddress,
                ToAddresses = receiverEmialAddress,
                Content = "<h1> Hello Test </h1>",
                Subject = "test Email"
            };
            _emailService.Send(email);
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
