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
    public class AveController : Controller
    {
        private MyFarmIagoContext db = new MyFarmIagoContext();

        // GET: Ave
        public ActionResult Index()
        {
            return View(db.Aves.ToList());
        }

        // GET: Ave/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ave ave = db.Aves.Find(id);
            if (ave == null)
            {
                return HttpNotFound();
            }
            return View(ave);
        }

        // GET: Ave/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ave/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnimalID,Numero,DataNascimento,Observacao,SexoAve,EhCaipira")] Ave ave)
        {
            if (ModelState.IsValid)
            {
                db.Aves.Add(ave);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ave);
        }

        // GET: Ave/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ave ave = db.Aves.Find(id);
            if (ave == null)
            {
                return HttpNotFound();
            }
            return View(ave);
        }

        // POST: Ave/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnimalID,Numero,DataNascimento,Observacao,SexoAve,EhCaipira")] Ave ave)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ave).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ave);
        }

        // GET: Ave/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ave ave = db.Aves.Find(id);
            if (ave == null)
            {
                return HttpNotFound();
            }
            return View(ave);
        }

        // POST: Ave/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ave ave = db.Aves.Find(id);
            db.Animais.Remove(ave);
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
