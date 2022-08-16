using Locators_and_Chrome_dev_tools_home_task.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace Locators_and_Chrome_dev_tools_home_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class emailController : ControllerBase
    {
        private IEmailService _emailService;

        public emailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }
    }
}
