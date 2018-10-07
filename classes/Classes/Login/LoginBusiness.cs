using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Login
{
    class LoginBusiness
    {

        public int Salvar (LoginDTO dto)
        {

            LoginDataBase db = new LoginDataBase();
            return db.Salvar(dto);

        }

        public LoginDTO Logar (string nome, string senha)
        {

            LoginDataBase db = new LoginDataBase();
            return db.Logar(nome,senha);
        }


    }
}
