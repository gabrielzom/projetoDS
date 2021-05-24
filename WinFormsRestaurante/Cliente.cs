using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsRestaurante
{
    public class Cliente : Pessoa
    {
        public Int32 Id { get; set; }
        public String Telefone { get; set; }
    }
}
