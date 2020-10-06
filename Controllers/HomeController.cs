using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisManagement.Models;
using SisManagement.BusinessObjects;

namespace SisManagement.Controllers
{
    public class HomeController : Controller
    {
        #region "Propriedades"

        private UsuarioBo Bo = new UsuarioBo();

        #endregion

        #region "Método redirecionar para Index"

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region "Método redirecionar para About"

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        #endregion

        #region "Método redirecionar para Contact"

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #endregion

        #region "Método redirecionar Login"

        public ActionResult Login()
        {
            return View();
        }

        #endregion

        #region "Método para validar o usuario"

        public ActionResult LoginUser(Usuario model)
        {
            var Result = Bo.LoginUser(model);

            if(Result.Id  > 0)
            {
                Session["UserId"] = Result.Id;
                return View("Index");
            }
            else
            {
                return View("Login");
            }
        }

        #endregion
    }
}