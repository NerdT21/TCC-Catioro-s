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
using Catiotro_s.classes.Classes.Vendas;
using Catiotro_s.classes.Classes.Login;

namespace Catiotro_s.Telas.Entregavel_III.Vendas
{
    public partial class frmVendas : UserControl
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        BindingList<ProdutoDTO> carrinhoAdd = new BindingList<ProdutoDTO>();

        void CarregarGrid()
        {
            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = carrinhoAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProdutoDTO dto = cboProduto.SelectedItem as ProdutoDTO;

            int quantidade = Convert.ToInt32(nudQuantidade.Value);

            for (int i = 0; i < quantidade; i++)
            {
                carrinhoAdd.Add(dto);
            }

            CarregarGrid();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            VendaDTO dto = new VendaDTO();
            dto.IdUsuario = UserSession.UsuarioLogado.Id;
            dto.Data = mkbDataCompra.Text;
            dto.FormaPagto = Convert.ToString(cboTipoPag.SelectedItem);

            VendaBusiness buss = new VendaBusiness();
            buss.Salvar(dto, carrinhoAdd.ToList());

            MessageBox.Show("Venda efetuada com sucesso!", "Catioro's",
                MessageBoxButtons.OK);
        }
    }
}
