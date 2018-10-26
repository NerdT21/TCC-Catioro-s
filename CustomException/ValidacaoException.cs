using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.CustomException
{
    public class ValidacaoException : Exception
    {
        public ValidacaoException(string msg) : base(msg)
        {
        }
    }
}
