using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.classes.Classes.Cliente;

namespace Catiotro_s.Telas.Entregavel_III.Produtos
{
    public partial class frmProdutos : UserControl
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        void CarregarCombos()
        {
            FornecedoresBusiness buss = new FornecedoresBusiness();
            FornecedoresDTO lista = buss.Listar();

            cboFornecedor.ValueMember = nameof(ItemDTO.Id);
            cboFornecedor.DisplayMember = nameof(ItemDTO.Nome);
            cboFornecedor.DataSource = lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FornecedoresDTO fornecedor = new FornecedoresDTO();

            ItemDTO dto = new ItemDTO();
            dto.Nome = txtNome.Text;
            dto.FornecedorId = fornecedor.Id;
            dto.Descricao = txtDescricao.Text;
            dto.Preco = Convert.ToDecimal(nudPreco.Value);

            ItemBusiness buss = new ItemBusiness();
            buss.Salvar(dto);

            MessageBox.Show("Item salvo com sucesso!", "Catioro's",
                MessageBoxButtons.OK);
        }
    }
}
