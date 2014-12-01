using System;
namespace SofosoftShop.Web.Services
{
   public interface IMailService
    {
        bool SendMail(string from, string to, string subject, string body);
    }
}
