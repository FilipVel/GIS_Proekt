using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Praksa;

namespace Praksa.Controllers
{
    public class MK_PROTECTEDAREAS_EEACDDAV15Controller : Controller
    {
        private GISTelerikEntities db = new GISTelerikEntities();

        // GET: MK_PROTECTEDAREAS_EEACDDAV15
        public ActionResult Index(String searchBy, String request)
        {
            if (searchBy == null)
            {
                return View(db.MK_PROTECTEDAREAS_EEACDDAV15.ToList());
            }
            else
            {
                if (searchBy == "Name")
                {
                    return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Where(item => item.SITE_NAME.StartsWith(request) || request == "").ToList());
                }
                else if (searchBy == "Code")
                {
                    return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Where(item => item.SITE_CODE.ToString() == request || request == "").ToList());
                }
                else if (searchBy == "ISO3")
                {
                    return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Where(item => item.ISO3 == request || request == "").ToList());
                }

                else if (searchBy == "Year")
                {
                    return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Where(item => item.YEAR.ToString() == request || request == "").ToList());
                }
                else
                {
                    return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Where(item => item.MUNICIPALITY == request || request == "").ToList());
                }
            }
        }

        // GET: MK_PROTECTEDAREAS_EEACDDAV15/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15 = db.MK_PROTECTEDAREAS_EEACDDAV15.Find(id);
            if (mK_PROTECTEDAREAS_EEACDDAV15 == null)
            {
                return HttpNotFound();
            }
            return View(mK_PROTECTEDAREAS_EEACDDAV15);
        }

        // GET: MK_PROTECTEDAREAS_EEACDDAV15/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MK_PROTECTEDAREAS_EEACDDAV15/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OBJECTID,SITE_CODE,PARENT_ISO,ISO3,SITE_NAME,SITE_AREA,YEAR,DESIG_ABBR,DESIGNATE,ODESIGNATE,IUCNCAT,CDDA_disse,Shape,MUNICIPALITY")] MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15)
        {
            if (ModelState.IsValid)
            {
                db.MK_PROTECTEDAREAS_EEACDDAV15.Add(mK_PROTECTEDAREAS_EEACDDAV15);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mK_PROTECTEDAREAS_EEACDDAV15);
        }

        // GET: MK_PROTECTEDAREAS_EEACDDAV15/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15 = db.MK_PROTECTEDAREAS_EEACDDAV15.Find(id);
            if (mK_PROTECTEDAREAS_EEACDDAV15 == null)
            {
                return HttpNotFound();
            }
            return View(mK_PROTECTEDAREAS_EEACDDAV15);
        }

        // POST: MK_PROTECTEDAREAS_EEACDDAV15/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OBJECTID,SITE_CODE,PARENT_ISO,ISO3,SITE_NAME,SITE_AREA,YEAR,DESIG_ABBR,DESIGNATE,ODESIGNATE,IUCNCAT,CDDA_disse,Shape,MUNICIPALITY")] MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mK_PROTECTEDAREAS_EEACDDAV15).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mK_PROTECTEDAREAS_EEACDDAV15);
        }

        // GET: MK_PROTECTEDAREAS_EEACDDAV15/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15 = db.MK_PROTECTEDAREAS_EEACDDAV15.Find(id);
            if (mK_PROTECTEDAREAS_EEACDDAV15 == null)
            {
                return HttpNotFound();
            }
            return View(mK_PROTECTEDAREAS_EEACDDAV15);
        }

        // POST: MK_PROTECTEDAREAS_EEACDDAV15/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MK_PROTECTEDAREAS_EEACDDAV15 mK_PROTECTEDAREAS_EEACDDAV15 = db.MK_PROTECTEDAREAS_EEACDDAV15.Find(id);
            db.MK_PROTECTEDAREAS_EEACDDAV15.Remove(mK_PROTECTEDAREAS_EEACDDAV15);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Shape(int id)
        {
            return View(db.MK_PROTECTEDAREAS_EEACDDAV15.Find(id));
        }

        public ActionResult Table() {
            return View();
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
