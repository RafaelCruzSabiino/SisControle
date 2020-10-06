using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisManagement.Bases
{
    public class DataConnection
    {
        public string Servidor  { get; set; }
        public string Usuario   { get; set; }
        public string Senha     { get; set; }
        public string Base      { get; set; }

        public DataConnection()
        {
            Servidor    = "localhost";
            Usuario     = "root";
            Senha       = "";
            Base        = "MANAGEMENT";
        }

        public string StrConnection()
        {
            return string.Format("Server={0};Database={1};Uid={2};Pwd={3};Port=3306", Servidor, Base, Usuario, Senha);
        }

    }
}