using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SofosoftShop.Model;
using SofosoftShop.Web.Services;

namespace SofosoftShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Solosoft About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact model)
        {

            var svc = new MailService();
            var msg = string.Format("Comment from: {1}{0}Email:{2}{0}Website{3}{0}", Environment.NewLine, model.Name, model.Email, model.Phone,model.Message);


            if (svc.SendMail("noreply@whaterver.com", "foo@gmail.com", "Website contact", msg))
            {
                ViewBag.MailSent = true;
            } 

            return View();
        }


    }
}