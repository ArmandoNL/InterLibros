using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace interlibros.Controllers
{
    public class CuentaController : Controller
    {
        //
        // GET: /Cuenta/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Cuenta/IniciarSesion
        [AllowAnonymous]
        public ActionResult IniciarSesion(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

	}
}