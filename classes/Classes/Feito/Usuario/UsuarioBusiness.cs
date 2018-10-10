using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
   public class UsuarioBusiness
    {

        public int Salvar(UsuarioDTO user)
        {
            UsuarioDatabase userDB = new UsuarioDatabase();
            int id = userDB.Salvar(user);
            return id;
        }

        public void Altera(UsuarioDTO user)
        {
            UsuarioDatabase userDB = new UsuarioDatabase();
            userDB.Alterar(user);
        }

        public void Remover(int IdUser)
        {
            UsuarioDatabase userDB = new UsuarioDatabase();
            userDB.Remover(IdUser);
        }

        public List<UsuarioDTO> Listar()
        {
            UsuarioDatabase userDB = new UsuarioDatabase();
            List<UsuarioDTO> user = userDB.Listar();
            return user;
        }

        public List<UsuarioDTO> Consultar(string user)
        {
            UsuarioDatabase userDB = new UsuarioDatabase();
            return userDB.Consultar(user);
        }
    }
}
