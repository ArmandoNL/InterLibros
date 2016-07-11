using System.Linq;
using interlibros.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace interlibros.Controllers
{
    public class CuentaController : Controller
    {
        private interlibrosEntities db = new interlibrosEntities();

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

        // POST: /Cuenta/IniciarSesion
        [HttpPost]
        [AllowAnonymous]
        public ActionResult IniciarSesion(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = db.Usuarios.FirstOrDefault(a => a.NombreUsuario.Equals(model.Username) && a.Contrasena.Equals(model.Password));
            if (user != null)
            {
                // con esto podemos saber el usuario en otros lugares
                Session["Username"] = model.Username;
                FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            ModelState.Remove("Password");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Registarse([Bind(Include = "Name,Username,Email,Password")] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // todo mensaje de error
                return View(model);
            }
            var user = db.Usuarios.FirstOrDefault(a => a.NombreUsuario.Equals(model.Username) && a.Correo.Equals(model.Email));
            if (user != null)
            {
                // todo mensaje de error correo o username ya han sido tomados
            }
            // todo agregar en la base de datos
            // todo mensaje de confirmación
            // nota usar ViewBag para mandar las cosas a la vista
            return View();
        }

        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

	}
}