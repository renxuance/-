using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;

namespace CourseManager.Controllers
{
    public class ActionLinkController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        //
        // GET: /ActionLink/

        public ActionResult Index()
        {
            return View(db.ActionLink.ToList());
        }

        //
        // GET: /ActionLink/Details/5

        public ActionResult Details(int id = 0)
        {
            ActionLink actionlink = db.ActionLink.Find(id);
            if (actionlink == null)
            {
                return HttpNotFound();
            }
            return View(actionlink);
        }

        //
        // GET: /ActionLink/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ActionLink/Create

        [HttpPost]
        public ActionResult Create(ActionLink actionlink)
        {
            if (ModelState.IsValid)
            {
                db.ActionLink.Add(actionlink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionlink);
        }

        //
        // GET: /ActionLink/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ActionLink actionlink = db.ActionLink.Find(id);
            if (actionlink == null)
            {
                return HttpNotFound();
            }
            return View(actionlink);
        }

        //
        // POST: /ActionLink/Edit/5

        [HttpPost]
        public ActionResult Edit(ActionLink actionlink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionlink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionlink);
        }

        //
        // GET: /ActionLink/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ActionLink actionlink = db.ActionLink.Find(id);
            if (actionlink == null)
            {
                return HttpNotFound();
            }
            return View(actionlink);
        }

        //
        // POST: /ActionLink/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ActionLink actionlink = db.ActionLink.Find(id);
            db.ActionLink.Remove(actionlink);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}