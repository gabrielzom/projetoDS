using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRestaurante
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa (String nome)
        {
            this.Nome = nome;
        }
        public Pessoa(String nome, String nascimento)
        {
            this.Nome = nome;
            this.Nascimento = Convert.ToDateTime(nascimento);
        }
        
        public Pessoa (DateTime nascimento)
        {
            this.Nascimento = nascimento;
        }

        public String Nome { get; set; } //C#
        public DateTime Nascimento { get; set; }
        public String Endereço { get; set; }
    }
}
