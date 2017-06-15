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
    public class TipoDeTarjetasController : Controller
    {
        private YakuzaDBEntities db = new YakuzaDBEntities();

        // GET: TipoDeTarjetas
        public ActionResult Index()
        {
            return View(db.TipoDeTarjeta.ToList());
        }

        // GET: TipoDeTarjetas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeTarjeta tipoDeTarjeta = db.TipoDeTarjeta.Find(id);
            if (tipoDeTarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeTarjeta);
        }

        // GET: TipoDeTarjetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeTarjetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTipo,descripcionTipo")] TipoDeTarjeta tipoDeTarjeta)
        {
            if (ModelState.IsValid)
            {
                db.TipoDeTarjeta.Add(tipoDeTarjeta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDeTarjeta);
        }

        // GET: TipoDeTarjetas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeTarjeta tipoDeTarjeta = db.TipoDeTarjeta.Find(id);
            if (tipoDeTarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeTarjeta);
        }

        // POST: TipoDeTarjetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTipo,descripcionTipo")] TipoDeTarjeta tipoDeTarjeta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDeTarjeta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDeTarjeta);
        }

        // GET: TipoDeTarjetas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeTarjeta tipoDeTarjeta = db.TipoDeTarjeta.Find(id);
            if (tipoDeTarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeTarjeta);
        }

        // POST: TipoDeTarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeTarjeta tipoDeTarjeta = db.TipoDeTarjeta.Find(id);
            db.TipoDeTarjeta.Remove(tipoDeTarjeta);
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
