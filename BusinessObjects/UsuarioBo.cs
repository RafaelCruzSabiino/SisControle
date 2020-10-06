using SisManagement.Bases;
using SisManagement.DataObjectAccess;
using SisManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisManagement.BusinessObjects
{
    public class UsuarioBo
    {
        #region "Propriedades"

        private UsuarioDao Dao = new UsuarioDao();

        #endregion

        #region "Método para validar usuario Bo"

        public ResultInfo<Usuario> LoginUser(Usuario model)
        {
            var result = new ResultInfo<Usuario>();

            try
            {
                result.Id = Dao.LoginUser(model);
            }
            catch (Exception ex)
            {
                result.MsgErro = ex.ToString();
            }

            return result;
        }

        #endregion

        #region "Método para buscar usuario expecifico"

        public ResultInfo<Usuario> GetUserLogged(int Id)
        {
            var result = new ResultInfo<Usuario>();

            try
            {
                result.Items = Dao.GetUserLogged(Id);
            }
            catch (Exception ex)
            {
                result.MsgErro = ex.ToString();
            }

            return result;
        }

        #endregion

        #region "Método para listar usuarios BO"

        public ResultInfo<Usuario> ListarUsuario(string Search)
        {
            var result = new ResultInfo<Usuario>();

            try
            {
                result.Items = Dao.ListarUsuario(Search);
            }
            catch (Exception ex)
            {
                result.MsgErro = ex.ToString();
            }

            return result;
        }

        #endregion

        #region "Método para Inserir Usuario BO"

        public ResultInfo<Usuario> InsertUser(Usuario model)
        {
            var result = new ResultInfo<Usuario>();

            try
            {
                result.Id = Dao.InsertUser(model);
            }
            catch (Exception ex)
            {
                result.MsgErro = ex.ToString();
            }

            return result;
        }

        #endregion
    }
}