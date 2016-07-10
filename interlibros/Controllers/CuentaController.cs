using interlibros.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

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

        // POST: /Cuenta/IniciarSesion
        [HttpPost]
        [AllowAnonymous]
        public ActionResult IniciarSesion(LoginViewModel model, string ReturnUrl)
        {
            /*if (!ModelState.IsValid)
            {
                return View(model);
            }*/
            /*
            var result = SignInStatus.Success;
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }*/
            FormsAuthentication.SetAuthCookie("user.Username", true);
            if (Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
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