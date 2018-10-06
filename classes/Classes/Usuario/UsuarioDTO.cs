using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int Senha { get; set; }
        public int IdPermissao { get; set; }
    }
}
