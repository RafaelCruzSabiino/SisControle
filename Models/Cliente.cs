using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisManagement.Models
{
    public class Cliente
    {
        public int Id           { get; set; }
        public string Razao     { get; set; }
        public string Fantazia  { get; set; }
        public string Sexo      { get; set; }
        public string Cnpj      { get; set; }
        public string Cpf       { get; set; }
        public string Rg        { get; set; }
        public int Contato      { get; set; }
        public int Endereco     { get; set; }
        public string Tipo      { get; set; }
        public string Status    { get; set; }
        public string Date      { get; set; }

        public Cliente()
        {
            Id          = 0;
            Razao       = string.Empty;
            Fantazia    = string.Empty;
            Sexo        = string.Empty;
            Cnpj        = string.Empty;
            Cpf         = string.Empty;
            Rg          = string.Empty;
            Contato     = 0;
            Endereco    = 0;
            Tipo        = string.Empty;
            Status      = string.Empty;
            Date        = string.Empty;
        }
    }
}