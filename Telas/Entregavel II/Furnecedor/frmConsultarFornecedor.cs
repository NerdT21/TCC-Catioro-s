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

namespace Catiotro_s.Consultar
{
    public partial class frmConsultarFornecedor : UserControl
    {
        public frmConsultarFornecedor()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            FornecedoresBusiness buss = new FornecedoresBusiness();
            List<FornecedoresDTO> lista = buss.Listar();

            dgvFornecedor.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string cidade = txtCidade.Text;

            FornecedoresBusiness buss = new FornecedoresBusiness();
            List<FornecedoresDTO> lista = buss.Consultar(nome, cidade);

            dgvFornecedor.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
