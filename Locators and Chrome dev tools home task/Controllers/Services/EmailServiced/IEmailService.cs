using Locators_and_Chrome_dev_tools_home_task.Models;

namespace Locators_and_Chrome_dev_tools_home_task.Controllers.Services.EmailServiced
{
    public interface IEmailService
    {
        void SendEmail(EmailDto requestl);
    }
}
