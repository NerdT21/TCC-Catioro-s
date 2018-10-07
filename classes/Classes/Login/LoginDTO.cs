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

        public string Senha { get; set; }

        public Boolean PermicaoADM { get; set; }

        public Boolean PermicaoCadastro { get; set; }

        public Boolean PermicaoConsulta { get; set; }


    }
}
