using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisManagement.Bases
{
    public class ResultInfo<T>
    {
        public string MsgErro   { get; set; }
        public int RowsAffected { get; set; }
        public int Id           { get; set; }
        public List<T> Items;
        public T Item;

        public ResultInfo()
        {
            MsgErro         = string.Empty;
            RowsAffected    = 0;
            Id              = 0;
            Items           = new List<T>();
            Item            = Activator.CreateInstance<T>();
        }
    }
}