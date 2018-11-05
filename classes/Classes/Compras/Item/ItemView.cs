﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.classes.Classes.Compras.Item
{
    public class ItemView
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Fornecedor { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }
    }
}
