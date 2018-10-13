using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Compras;

namespace Catiotro_s.Telas.Entregavel_II.Controle_de_Compras
{
    public partial class frmVerCompras : UserControl
    {
        public frmVerCompras()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ComprasBusiness bus = new ComprasBusiness();
            List<ComprasDTO> dto = bus.Listar();

            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = dto;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string data = mkbData.Text;

            ComprasBusiness bus = new ComprasBusiness();
            List<ComprasDTO> dto = bus.Consultar(nome, data);

            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = dto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
