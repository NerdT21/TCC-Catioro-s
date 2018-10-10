using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Cliente
{
   public class FornecedoresDTO
    {
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        
        public string Cnpj { get; set; }
       
        
        public string Bairro { get; set; }
        public string Cidade { get; set; }
       
        public string Telefone { get; set; }
        public string Email { get; set; }
       
    }
}
