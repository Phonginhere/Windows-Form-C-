using SendMail.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SendMail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SendEmail2()
        {
            return View();
        }
        //string receiver, string subject, string message
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SendEmail2(EmailModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress(model.From);
                    var receiverEmail = new MailAddress(model.To);
                    var password = model.Password;
                    var sub = model.Subject;
                    var body = model.Body;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = model.Subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    ViewBag.Succesful = "Thành công";
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Thất bại";
            }
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(EmailModel model)
        {
           

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}