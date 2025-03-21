using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public enum EtipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string? CPF { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public string? DDD { get; set; }
        public string? Telefone { get; set; }
        public bool PossuiFilhos { get; set; }
        public EtipoTelefone TipoTelefone { get; set;}

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();
    }
}
