using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.Validacoes
{
    public class ValidarData
    {
        public bool validaData(String data)
        {
            DateTime result;

            if (DateTime.TryParse(data, out result))

                return true;

            else

                return false;

        }
    }
}
