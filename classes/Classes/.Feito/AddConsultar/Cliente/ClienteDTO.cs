using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
     public class ClienteDTO
    {
        public int Pessoa { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Endereco { get; set; }
        public string Local { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string DataNasc { get; set; }
        public string DataCadastro { get; set; }
    }
}
