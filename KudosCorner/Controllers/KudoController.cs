using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KudosCorner.DAL;
using KudosCorner.Models;

namespace KudosCorner.Controllers
{
    public class KudoController : Controller
    {
        private OfficeContext db = new OfficeContext();

        // GET: Kudo
        public ActionResult Index()
        {
            return View(db.Kudos.ToList());
        }

        // GET: Kudo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kudo kudo = db.Kudos.Find(id);
            if (kudo == null)
            {
                return HttpNotFound();
            }
            return View(kudo);
        }

        // POST: Kudo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Details")]
         [ValidateAntiForgeryToken]
         public ActionResult DetailsPost(int? id)
         {
             if (id == null)
             {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
             var kudoToUpdate = db.Kudos.Find(id);

             if (TryUpdateModel(kudoToUpdate, "",
                 new string[] { "Congrats_Messages" }))
             {
                 try
                 {
                     db.SaveChanges();

                     return RedirectToAction("Index");
    }
               catch (DataException /* dex */) 
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(kudoToUpdate);
        } 
            

        // GET: Kudo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kudo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Image_Link,Title,Description,Congrats_Messages")] Kudo kudo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Kudos.Add(kudo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /*dex*/)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }


            return View(kudo);
        }

        // GET: Kudo/Edit/5
        public ActionResult Edit(int? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kudo kudo = db.Kudos.Find(id);
            if (kudo == null)
            {
                return HttpNotFound();
            }
            return View(kudo);
        }

        // POST: Kudo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var kudoToUpdate = db.Kudos.Find(id);

            if (TryUpdateModel(kudoToUpdate, "",
                new string[] { "Title", "Description", "Image_Link","Congrats_Messages","Achievers" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(kudoToUpdate);
        }

        // GET: Kudo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kudo kudo = db.Kudos.Find(id);
            if (kudo == null)
            {
                return HttpNotFound();
            }
            return View(kudo);
        }

        // POST: Kudo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kudo kudo = db.Kudos.Find(id);
            db.Kudos.Remove(kudo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
