using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Agenda;

namespace Catiotro_s.Telas.Entregavel_II.Produto
{
    public partial class frmConsultarProduto : UserControl
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Listar();

            dgvProduto.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string marca = txtMarca.Text;

            ProdutoBusiness buss = new ProdutoBusiness();
            List<ProdutoDTO> lista = buss.Consultar(nome, marca);

            dgvProduto.DataSource = lista;
        }

        private void lblprocurar_Click(object sender, EventArgs e)
        {

        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }

        private void txtprocurar_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
