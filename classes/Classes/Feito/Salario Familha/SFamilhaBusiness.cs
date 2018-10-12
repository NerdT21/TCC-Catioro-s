using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Agenda
{
    public class SFamilhaBusiness
    {
        public SFamilhaDTO Consultar(decimal salario)
        {
            SFamilhaDatabase DB = new SFamilhaDatabase();
            return DB.Consultar(salario);
        }
    }
}

