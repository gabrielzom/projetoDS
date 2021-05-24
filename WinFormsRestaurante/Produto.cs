using System;


namespace WinFormsRestaurante 
{ 
    public class Produto
    {

        public String Codigo { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
        public Categoria categoria { get; set; }
        public Boolean cancelado { get; set; }

        public void Add(Produto produto)
        {

        }

    }
}
