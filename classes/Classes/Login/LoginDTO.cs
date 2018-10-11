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

        public bool PermicaoCadastro { get; set; }

        public bool PermicaoConsulta { get; set; }


    }
}
