using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Login
{
    public class LoginDTO
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string NmUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool PermicaoADM { get; set; }

        public bool PermicaoAtendente { get; set; }

        public bool PermicaoFinanceiro { get; set; }

        public bool PermicaoVendedor { get; set; }

        public bool PermicaoCompras { get; set; }

        public bool PermicaoServicos { get; set; }

        public bool PermicaoFuncionarios { get; set; }

        public bool PermicaoProdutos { get; set; }
        
        public bool PermicaoFornecedor { get; set; }
    }
}
