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
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.classes.Classes.Vendas.Produto;

namespace Catiotro_s.Telas.Entregavel_III.Vendas
{
    public partial class frmVendas : UserControl
    {
        public frmVendas()
        {
            InitializeComponent();
            DataParaHoje();
        }
        BindingList<ProdutoDTO> carrinhoAdd = new BindingList<ProdutoDTO>();
        BindingList<decimal> valor = new BindingList<decimal>();

        void CarregarGrid()
        {
            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = carrinhoAdd;
        }

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            string data = dia + "/" + mes + "/" + ano;
            mkbDataCompra.Text = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = cboProduto.SelectedItem as ProdutoDTO;

                int quantidade = Convert.ToInt32(nudQuantidade.Value);

                for (int i = 0; i < quantidade; i++)
                {
                    carrinhoAdd.Add(dto);
                }

                CarregarGrid();

                valor.Add(dto.Preco * quantidade);
                txtPrecoTotal.Text = Convert.ToString(valor.Sum());
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
           
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                VendaDTO dto = new VendaDTO();
                dto.IdUsuario = UserSession.UsuarioLogado.Id;
                dto.Data = mkbDataCompra.Text;
                dto.FormaPagto = Convert.ToString(cboTipoPag.SelectedItem);

                VendaBusiness buss = new VendaBusiness();
                buss.Salvar(dto, carrinhoAdd.ToList());

                string msg = "Venda efetuada com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
           
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
