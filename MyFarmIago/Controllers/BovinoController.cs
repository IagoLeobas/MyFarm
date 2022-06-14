using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFarmIago.DAL;
using MyFarmIago.Models;

namespace MyFarmIago.Controllers
{
    public class BovinoController : Controller
    {
        private MyFarmIagoContext db = new MyFarmIagoContext();

        // GET: Bovino
        public ActionResult Index()
        {
            return View(db.Bovinos.ToList());
        }

        // GET: Bovino/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bovino bovino = db.Bovinos.Find(id);
            if (bovino == null)
            {
                return HttpNotFound();
            }
            return View(bovino);
        }

        // GET: Bovino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bovino/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnimalID,Numero,DataNascimento,Observacao,SexoBovino,EhLeiteira,Peso,Cor")] Bovino bovino)
        {
            if (ModelState.IsValid)
            {
                db.Bovinos.Add(bovino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bovino);
        }

        // GET: Bovino/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bovino bovino = db.Bovinos.Find(id);
            if (bovino == null)
            {
                return HttpNotFound();
            }
            return View(bovino);
        }

        // POST: Bovino/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnimalID,Numero,DataNascimento,Observacao,SexoBovino,EhLeiteira,Peso,Cor")] Bovino bovino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bovino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bovino);
        }

        // GET: Bovino/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bovino bovino = db.Bovinos.Find(id);
            if (bovino == null)
            {
                return HttpNotFound();
            }
            return View(bovino);
        }

        // POST: Bovino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bovino bovino = db.Bovinos.Find(id);
            db.Animais.Remove(bovino);
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
