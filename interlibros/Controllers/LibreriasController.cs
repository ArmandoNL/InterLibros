using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using interlibros.Models;

namespace interlibros.Controllers
{
    public class LibreriasController : Controller
    {
        private interlibrosEntities db = new interlibrosEntities();

        // GET: Librerias
        public ActionResult Index()
        {
            return View(db.Librerias.ToList());
        }

        // GET: Librerias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Librerias librerias = db.Librerias.Find(id);
            var l = db.Libros.Where(x => x.Librerias.id == id);
            if (librerias == null)
            {
                return HttpNotFound();
            }
            var vM = new LibreriaDetalleViewModel { libreria = librerias, libros = l };          
            return View(vM);
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
