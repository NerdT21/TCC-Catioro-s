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
using Catiotro_s.classes.Classes.Cliente;

namespace Catiotro_s.Telas.Entregavel_II.Controle_de_Compras
{
    public partial class frmCompras : UserControl
    {
        public frmCompras()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            //cboProduto

            ItemBusiness buss = new ItemBusiness();
            List<ItemDTO> lista = buss.Listar();

            cboProduto.ValueMember = nameof(ProdutoDTO.Id);
            cboProduto.DisplayMember = nameof(ProdutoDTO.Nome);
            cboProduto.DataSource = lista;

            //cboFornecedor

            FornecedoresBusiness buss2 = new FornecedoresBusiness();
            List<FornecedoresDTO> lista2 = buss2.Listar();

            cboFornecedor.ValueMember = nameof(FornecedoresDTO.Id);
            cboFornecedor.DisplayMember = nameof(FornecedoresDTO.Nome);
            cboFornecedor.DataSource = lista2;
        }

        void CarregarGrid()
        {
            ComprasBusiness buss = new CompraBusiness();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
