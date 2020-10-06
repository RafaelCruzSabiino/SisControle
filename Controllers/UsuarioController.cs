using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisManagement.Models;
using SisManagement.BusinessObjects;

namespace SisManagement.Controllers
{
    public class UsuarioController : Controller
    {
        #region "Propriedades"

        private UsuarioBo Bo = new UsuarioBo();

        #endregion

        #region "Método redirecionar e buscar Usuario Index"

        public ActionResult UsuarioIndex()
        {
            var Result = Bo.GetUserLogged(Convert.ToInt32(Session["UserId"]));

            ViewBag.UserList = Result.Items.ToList();

            return View();
        }

        #endregion

        #region "Método para listar usuarios"

        [HttpPost]
        public ActionResult ListarUsuario(string Search)
        {
            var Usuarios = Bo.ListarUsuario(Search);

            return PartialView(Usuarios.Items);
        }

        #endregion

        #region "Método para cadastrar um usuario"

        [HttpPost]
        public ActionResult InsertUser(Usuario model)
        {
            var Result = Bo.InsertUser(model);

            return RedirectToAction("UsuarioIndex");
        }

        #endregion

        #region "Método para Redirecionar pagina para alterar"

        [HttpPost]
        public int UsuarioAlter(int ID)
        {             
            return 1;
        }

        #endregion


    }
}