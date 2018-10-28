using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Servico.ServicoItem
{
    public class ServicoItemBusiness
    {
        public int Salvar(ServicoItemDTO dto)
        {
            ServicoItemDatabase db = new ServicoItemDatabase();
            return db.Salvar(dto);
        }
    }
}
