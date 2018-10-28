using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Cliente;

namespace Catiotro_s.Telas.Entregavel_I
{
    public partial class frmVerFolha : UserControl
    {
        public frmVerFolha()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            FPagamentoBusiness buss = new FPagamentoBusiness();
            List<FPamentoDTO> lista = buss.Listar();

            dgvFolha.AutoGenerateColumns = false;
            dgvFolha.DataSource = lista;
        }
    }
}
