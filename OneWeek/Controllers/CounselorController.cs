using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneWeek.Models;
using OneWeek.DAL;

namespace OneWeek.Controllers
{
    public class CounselorController : Controller
    {
        private CounselContext db = new CounselContext();

        // GET: /Counselor/
        public ActionResult Index()
        {
            return View(db.Counselors.ToList());
        }

        // GET: /Counselor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counselor counselor = db.Counselors.Find(id);
            if (counselor == null)
            {
                return HttpNotFound();
            }
            return View(counselor);
        }

        // GET: /Counselor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Counselor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,LastName,FirstName")] Counselor counselor)
        {
            if (ModelState.IsValid)
            {
                db.Counselors.Add(counselor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(counselor);
        }

        // GET: /Counselor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counselor counselor = db.Counselors.Find(id);
            if (counselor == null)
            {
                return HttpNotFound();
            }
            return View(counselor);
        }

        // POST: /Counselor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,LastName,FirstName")] Counselor counselor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(counselor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(counselor);
        }

        // GET: /Counselor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counselor counselor = db.Counselors.Find(id);
            if (counselor == null)
            {
                return HttpNotFound();
            }
            return View(counselor);
        }

        // POST: /Counselor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Counselor counselor = db.Counselors.Find(id);
            db.Counselors.Remove(counselor);
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
