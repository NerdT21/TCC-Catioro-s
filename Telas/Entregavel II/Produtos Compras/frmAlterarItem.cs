using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.CustomException.TelasException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_II.Produtos_Compras
{
    public partial class frmAlterarItem : Form
    {
        public frmAlterarItem()
        {
            InitializeComponent();
        }

        void CarregarCombos()
        {
            FornecedoresBusiness buss = new FornecedoresBusiness();
            List<FornecedoresDTO> lista = buss.ListarPraCombo();

            cboFornecedor.ValueMember = nameof(FornecedoresDTO.Id);
            cboFornecedor.DisplayMember = nameof(FornecedoresDTO.Nome);
            cboFornecedor.DataSource = lista;
        }

        ItemView item;
        public void LoadScreen(ItemView dto)
        {
            this.item = dto;
            txtNome.Text = dto.Nome;
            txtDescricao.Text = dto.Descricao;
            cboFornecedor.SelectedItem = dto.Fornecedor;
            nudPreco.Value = dto.Preco;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FornecedoresDTO fornecedor = cboFornecedor.SelectedItem as FornecedoresDTO;

            ItemDTO dto = new ItemDTO();
            dto.Id = this.item.Id;

            dto.Nome = txtNome.Text;
            dto.FornecedorId = fornecedor.Id;
            dto.Descricao = txtDescricao.Text;
            dto.Preco = Convert.ToDecimal(nudPreco.Value);

            ItemBusiness buss = new ItemBusiness();
            buss.Alterar(dto);

            string msg = "Item alterado com sucesso!";

            frmMessage tela = new frmMessage();
            tela.LoadScreen(msg);
            tela.ShowDialog();
        }
    }
}
