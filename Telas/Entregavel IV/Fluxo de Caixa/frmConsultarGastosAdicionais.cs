using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Gastos_Adicionais;

namespace Catiotro_s.Telas.Entregavel_IV.Fluxo_de_Caixa
{
    public partial class frmConsultarGastosAdicionais : UserControl
    {
        public frmConsultarGastosAdicionais()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            GastosBusiness buss = new GastosBusiness();
            List<GastosDTO> lista = buss.Listar();
            
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            GastosBusiness buss = new GastosBusiness();
            List<GastosDTO> lista = buss.Consultar(data);

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
