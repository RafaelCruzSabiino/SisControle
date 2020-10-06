using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisManagement.Models;
using SisManagement.BusinessObjects;

namespace SisManagement.Controllers
{
    public class ClienteController : Controller
    {

        #region "Propriedades"

        private ClienteBo Bo = new ClienteBo();

        #endregion

        #region "Metodo para redirecionar para a pagina INDEX"

        public ActionResult ClienteIndex()
        {
            return View();
        }

        #endregion
    }
}