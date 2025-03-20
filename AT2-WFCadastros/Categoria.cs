using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Status { get; set; }

        public static List<Categoria> ListaCategoria =
            new List<Categoria>();

        public void Cadastro()
        {
            ListaCategoria.Add(this);
        }

        public static List<Categoria> ObterLista()
        {
            return ListaCategoria;
        }
    }
}
