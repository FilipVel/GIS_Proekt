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
    public class MK_PROTECTEDAREAS_EEACDDAV15__ATTACHController : Controller
    {
        private GISTelerikEntities db = new GISTelerikEntities();

        // GET: MK_PROTECTEDAREAS_EEACDDAV15__ATTACH
        public ActionResult Index()
        {
            return View(db.MK_PROTECTEDAREAS_EEACDDAV15__ATTACH.ToList());
        }

        // GET: MK_PROTECTEDAREAS_EEACDDAV15__ATTACH/Details/5
        

        public ActionResult Show(int id)
        {
            var ImageData = db.MK_PROTECTEDAREAS_EEACDDAV15__ATTACH.FirstOrDefault(item=>item.ATTACHMENTID==id).DATA;
            return File(ImageData, "image/jpg");
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
