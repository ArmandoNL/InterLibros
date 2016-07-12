using interlibros.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace interlibros.Controllers
{
    public class HomeController : Controller
    {
        private interlibrosEntities db = new interlibrosEntities();
        

        public ActionResult Index(int? categoria, int? libreria)
        {
            IEnumerable<Libros> l;
            if(categoria != null)
            {
                l = db.Libros.Where(x => x.Categorias.Where(a => a.id == categoria).Count() > 0);
            }
            else
            {
                if (libreria != null)
                {
                    l = db.Libros.Where(x => x.Librerias.id == libreria);
                }
                else
                {
                    l = db.Libros.AsNoTracking();
                }
            }
            var ll = db.Libros.AsNoTracking();
            var lib = db.Librerias;
            var cat = db.Categorias;

            if (Session["Username"] != null)
            {
                string username = Session["Username"].ToString();
                Usuarios usuarios = db.Usuarios.FirstOrDefault(a => a.NombreUsuario.Equals(username));
                ViewBag.Cart = usuarios.LibroEnCarro.Count();
            }
            else {
                ViewBag.Cart = "0";
            }
            


            var viewModel = new MainPageViewModel { libros = ll, ResLibros = l, librerias = lib, categorias = cat };
            return View(viewModel);
        }

        public ActionResult Contactenos()
        {
            return View();
        }

    }
}