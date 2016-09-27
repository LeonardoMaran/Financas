using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace Financas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(string login, string senha)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(senha))
            {
                ModelState.AddModelError("Login.Invalido", "Digite o seu login ou senha");
                return View("Index");
            }


            if (WebSecurity.Login( login, senha))
                {

                    return RedirectToAction("Index", "Movimentacao");
                }

                else
                {

                    ModelState.AddModelError("Login.Invalido", "Login ou senha incorretos");
                return View("Index");
               
            }
}
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index");

            

        }
    }
}