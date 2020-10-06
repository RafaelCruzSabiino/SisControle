using SisManagement.Bases;
using SisManagement.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisManagement.DataObjectAccess
{
    public class UsuarioDao : Connection
    {
        #region "Procedures"

        private const string SpMng00010001 = "SP_MNG_0001_0001";
        private const string SpMng00010002 = "SP_MNG_0001_0002";
        private const string SpMng00010003 = "SP_MNG_0001_0003";
        private const string SpMng00010004 = "SP_MNG_0001_0004";

        #endregion

        #region "Parametros"

        private const string ParamId        = "pID";
        private const string ParamNome      = "pNOME";
        private const string ParamEmail     = "pEMAIL";
        private const string ParamSenha     = "pSENHA";
        private const string ParamPermissao = "pPERMISSAO";

        #endregion

        #region "Método construtor"

        public UsuarioDao()
        {

        }

        #endregion

        #region "Método para validar login DAO"

        public int LoginUser(Usuario model)
        {
            int ret = 0;

            using (var cmd = objConnection.CreateCommand())
            {
                cmd.CommandType     = CommandType.StoredProcedure;
                cmd.CommandText     = SpMng00010001;
                cmd.CommandTimeout  = 0;

                cmd.Parameters.AddWithValue(ParamEmail, model.Email);
                cmd.Parameters.AddWithValue(ParamSenha, model.Senha);

                using (var RetBase = cmd.ExecuteReader())
                {
                    while (RetBase.Read())
                    {
                        ret = Convert.ToInt32(RetBase["ID"]);
                    }
                }
            }

            CloseConnection();
            return ret;
        }

        #endregion

        #region "Método para buscar usuario Expecifico"

        public List<Usuario> GetUserLogged(int Id)
        {
            List<Usuario> result = new List<Usuario>();

            using (var cmd = objConnection.CreateCommand())
            {
                cmd.CommandType     = CommandType.StoredProcedure;
                cmd.CommandText     = SpMng00010002;
                cmd.CommandTimeout  = 0;

                cmd.Parameters.AddWithValue(ParamId, Id);

                using (var RetBase = cmd.ExecuteReader())
                {
                    while (RetBase.Read())
                    {
                        Usuario User = new Usuario();

                        User.Nome       = RetBase["NOME"].ToString();
                        User.Email      = RetBase["EMAIL"].ToString();
                        User.Senha      = RetBase["SENHA"].ToString();
                        User.Permissao  = RetBase["PERMISSAO"].ToString();
                        User.Id         = Convert.ToInt32(RetBase["ID"]);

                        result.Add(User);
                    }
                }

                CloseConnection();
                return result;
            }
        }

        #endregion

        #region "Método para listar usuario DAO"

        public List<Usuario> ListarUsuario(string Search)
        {
            List<Usuario> result = new List<Usuario>();

            using (var cmd = objConnection.CreateCommand())
            {
                cmd.CommandType     = CommandType.StoredProcedure;
                cmd.CommandText     = SpMng00010003;
                cmd.CommandTimeout  = 0;

                cmd.Parameters.AddWithValue(ParamNome, Search);

                using (var RetBase = cmd.ExecuteReader())
                {
                    while (RetBase.Read())
                    {
                        Usuario User = new Usuario();

                        User.Nome       = RetBase["NOME"].ToString();
                        User.Email      = RetBase["EMAIL"].ToString();
                        User.Senha      = RetBase["SENHA"].ToString();
                        User.Permissao  = RetBase["PERMISSAO"].ToString();
                        User.Id         = Convert.ToInt32(RetBase["ID"]);

                        result.Add(User);
                    }
                }

                CloseConnection();
                return result;
            }
        }

        #endregion

        #region "Método para inserir usuario DAO"

        public int InsertUser(Usuario model)
        {
            int ret = 0;

            using (var cmd = objConnection.CreateCommand())
            {
                cmd.CommandType     = CommandType.StoredProcedure;
                cmd.CommandText     = SpMng00010004;
                cmd.CommandTimeout  = 0;

                cmd.Parameters.AddWithValue(ParamNome, model.Nome);
                cmd.Parameters.AddWithValue(ParamEmail, model.Email);
                cmd.Parameters.AddWithValue(ParamSenha, model.Senha);
                cmd.Parameters.AddWithValue(ParamPermissao, model.Permissao);

                using (var RetBase = cmd.ExecuteReader())
                {
                    while (RetBase.Read())
                    {
                        ret = Convert.ToInt32(RetBase["ID"]);
                    }
                }
            }

            CloseConnection();
            return ret;
        }

        #endregion

    }
}