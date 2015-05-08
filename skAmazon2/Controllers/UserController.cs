using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using skAmazon2.Models;

namespace skAmazon2.Controllers
{
    public class UserController : Controller
    {
        private skAmazonEntities db = new skAmazonEntities();

        // GET: /User/
        public ActionResult Index()
        {
            var skamazonusers = db.skAmazonUsers.Include(s => s.Permission).Include(s => s.skAmazonUserPassword);
            return View(skamazonusers.ToList());
        }

        // GET: /User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            skAmazonUser skamazonuser = db.skAmazonUsers.Find(id);
            if (skamazonuser == null)
            {
                return HttpNotFound();
            }
            return View(skamazonuser);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            ViewBag.PermissionLevelID = new SelectList(db.Permissions, "PermissionID", "PermissionDescription");
            ViewBag.UserID = new SelectList(db.skAmazonUserPasswords, "UserId", "Password");
            return View();
        }

        // POST: /User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserID,Firstname,Lastname,PermissionLevelID")] skAmazonUser skamazonuser)
        {
            if (ModelState.IsValid)
            {
                db.skAmazonUsers.Add(skamazonuser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PermissionLevelID = new SelectList(db.Permissions, "PermissionID", "PermissionDescription", skamazonuser.PermissionLevelID);
            ViewBag.UserID = new SelectList(db.skAmazonUserPasswords, "UserId", "Password", skamazonuser.UserID);
            return View(skamazonuser);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            skAmazonUser skamazonuser = db.skAmazonUsers.Find(id);
            if (skamazonuser == null)
            {
                return HttpNotFound();
            }
            ViewBag.PermissionLevelID = new SelectList(db.Permissions, "PermissionID", "PermissionDescription", skamazonuser.PermissionLevelID);
            ViewBag.UserID = new SelectList(db.skAmazonUserPasswords, "UserId", "Password", skamazonuser.UserID);
            return View(skamazonuser);
        }

        // POST: /User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UserID,Firstname,Lastname,PermissionLevelID")] skAmazonUser skamazonuser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skamazonuser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PermissionLevelID = new SelectList(db.Permissions, "PermissionID", "PermissionDescription", skamazonuser.PermissionLevelID);
            ViewBag.UserID = new SelectList(db.skAmazonUserPasswords, "UserId", "Password", skamazonuser.UserID);
            return View(skamazonuser);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            skAmazonUser skamazonuser = db.skAmazonUsers.Find(id);
            if (skamazonuser == null)
            {
                return HttpNotFound();
            }
            return View(skamazonuser);
        }

        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            skAmazonUser skamazonuser = db.skAmazonUsers.Find(id);
            db.skAmazonUsers.Remove(skamazonuser);
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
