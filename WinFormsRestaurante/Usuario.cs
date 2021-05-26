using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRestaurante
{
    public class Usuario: Cliente
    {
        public String Login { get; set; }

        public String Senha { get; set; }

        public Int32 Supervisor { get; set; } 
    }
}
