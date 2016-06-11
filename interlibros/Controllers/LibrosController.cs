using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using interlibros;
using interlibros.Models;

namespace interlibros.Controllers
{
    public class LibrosController : Controller
    {
        private interlibrosEntities db = new interlibrosEntities();

        // GET: Libros
        public async Task<ActionResult> Index()
        {
            var libros = db.Libros.Include(l => l.Libreria);
            return View(await libros.ToListAsync());
        }

        // GET: Libros/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libros libros = await db.Libros.FindAsync(id);
            if (libros == null)
            {
                return HttpNotFound();
            }
            return View(libros);
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            ViewBag.idLibreria = new SelectList(db.Libreria, "id", "Nombre");
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,idLibreria,Titulo,Autor,Idioma,Condicion,Cantidad,Description,Descuento,Precio")] Libros libros)
        {
            if (ModelState.IsValid)
            {
                db.Libros.Add(libros);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idLibreria = new SelectList(db.Libreria, "id", "Nombre", libros.idLibreria);
            return View(libros);
        }

        // GET: Libros/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libros libros = await db.Libros.FindAsync(id);
            if (libros == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLibreria = new SelectList(db.Libreria, "id", "Nombre", libros.idLibreria);
            return View(libros);
        }

        // POST: Libros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,idLibreria,Titulo,Autor,Idioma,Condicion,Cantidad,Description,Descuento,Precio")] Libros libros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libros).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idLibreria = new SelectList(db.Libreria, "id", "Nombre", libros.idLibreria);
            return View(libros);
        }

        // GET: Libros/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libros libros = await db.Libros.FindAsync(id);
            if (libros == null)
            {
                return HttpNotFound();
            }
            return View(libros);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Libros libros = await db.Libros.FindAsync(id);
            db.Libros.Remove(libros);
            await db.SaveChangesAsync();
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
