using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
    public class ClienteDTO
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public int EstadoId { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public string Telefone { get; set; }

        public string DataNascimento { get; set; }

        public string DataCadastro { get; set; }
    }
}
