using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Yakuza.Models;

namespace Yakuza.Controllers
{
    public class CategoriaPlatilloesController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();

        // GET: CategoriaPlatilloes
        public ActionResult Index()
        {
            return View(db.CategoriaPlatillo.ToList());
        }

        // GET: CategoriaPlatilloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPlatillo categoriaPlatillo = db.CategoriaPlatillo.Find(id);
            if (categoriaPlatillo == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPlatillo);
        }

        // GET: CategoriaPlatilloes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaPlatilloes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategoriaPlatillo,nombreCategoriaPlatillo,descripcionCategoriaPlatillo")] CategoriaPlatillo categoriaPlatillo)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaPlatillo.Add(categoriaPlatillo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaPlatillo);
        }

        // GET: CategoriaPlatilloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPlatillo categoriaPlatillo = db.CategoriaPlatillo.Find(id);
            if (categoriaPlatillo == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPlatillo);
        }

        // POST: CategoriaPlatilloes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategoriaPlatillo,nombreCategoriaPlatillo,descripcionCategoriaPlatillo")] CategoriaPlatillo categoriaPlatillo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaPlatillo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaPlatillo);
        }

        // GET: CategoriaPlatilloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaPlatillo categoriaPlatillo = db.CategoriaPlatillo.Find(id);
            if (categoriaPlatillo == null)
            {
                return HttpNotFound();
            }
            return View(categoriaPlatillo);
        }

        // POST: CategoriaPlatilloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaPlatillo categoriaPlatillo = db.CategoriaPlatillo.Find(id);
            db.CategoriaPlatillo.Remove(categoriaPlatillo);
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
