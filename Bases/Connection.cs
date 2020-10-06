using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data;

namespace SisManagement.Bases
{
    public class Connection : DataConnection
    {
        public static MySqlConnection objConnection = null;

        public string _strConnection = new DataConnection().StrConnection();

        #region "Método para abertura de conexao com a base"

        public Connection()
        {
            try
            {
                objConnection = new MySqlConnection();
                objConnection.ConnectionString = _strConnection;
                objConnection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao se conectar com o banco");
            }
        }

        #endregion

        #region "Método para desonectar a conexao com o banco"
        
        public static void CloseConnection()
        {
            objConnection.Close();
        }

        #endregion
    }
}