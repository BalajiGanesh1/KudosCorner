using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Graph;
using System.Net.Http.Headers;
using KudosCorner.DAL;
using KudosCorner.Models;
using Microsoft.Office.Interop.Outlook;

namespace KudosCorner.Controllers
{   
    [Authorize]
    public class HomeController : Controller
    {
        private OfficeContext db = new OfficeContext();
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                for (int i = 0; i < model.ToEmail.Length; i++)
                {
                    //message.To.Add(new MailAddress(model.ToEmail[i]));
                }
                message.To.Add(new MailAddress(model.ToEmail));  // replace with valid value 
                message.From = new MailAddress("balaji.ganesh@psiog.com");  // replace with valid value
                message.Subject = "Congrats on the achievement";
                message.Body = string.Format(body, model.FromName, model.ToEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
        //[Authorize]
        public ActionResult Sent()
        {
            return View();
        }

       /* private void AccessContacts()
        {
            Microsoft.Office.Interop.Outlook.MAPIFolder folderContacts = this.Application.ActiveExplorer().Session.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);
            Outlook.Items searchFolder = folderContacts.Items;
           
            PsiogUser user1 = new PsiogUser();
            foreach (Outlook.ContactItem item in searchFolder)
            {
               user1.
            }
           
        }*/


    }
}