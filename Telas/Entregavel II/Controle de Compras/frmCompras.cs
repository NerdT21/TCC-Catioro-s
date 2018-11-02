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
using Catiotro_s.classes.Classes.Compras.Item;
using Catiotro_s.classes.Classes.Compras;
using Catiotro_s.classes.Classes.Login;
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.classes.Classes.Compras.ItemCompras;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.CustomException;

namespace Catiotro_s.Telas.Entregavel_II.Controle_de_Compras
{
    public partial class frmCompras : UserControl
    {
        public frmCompras()
        {
            InitializeComponent();
            CarregarCombos();
            DataParaHoje();
            CarregarTxt();
        }

        BindingList<ItemDTO> carrinhoAdd = new BindingList<ItemDTO>();
        BindingList<decimal> valor = new BindingList<decimal>();

        void DataParaHoje()
        {
            DateTime hoje = DateTime.Now;
            int dia = hoje.Day;
            int mes = hoje.Month;
            int ano = hoje.Year;

            string data = dia + "/" + mes + "/" + ano;
            mkbDataCompra.Text = data;
        }

        void CarregarTxt()
        {
            ItemView item = cboProduto.SelectedItem as ItemView;

            if (item.Nome != null)
            {
                txtProduto.Text = item.Nome;

                txtPrecoTotal.Text = Convert.ToString(item.Preco);
                txtFornecedor.Text = item.Fornecedor;
            }
            else
            {
                txtProduto.Text = "NULL";
            }
           
        }

        void CarregarCombos()
        {
            //cboProduto

            ItemBusiness buss = new ItemBusiness();
            List<ItemView> lista = buss.Listar();

            cboProduto.ValueMember = nameof(ItemDTO.Id);
            cboProduto.DisplayMember = nameof(ItemDTO.Nome);
            cboProduto.DataSource = lista;
        }

        void CarregarGrid()
        {
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = carrinhoAdd;
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
            //Design das Linhas
            dgvCompras.BorderStyle = BorderStyle.None;
            dgvCompras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvCompras.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvCompras.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvCompras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCompras.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvCompras.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCompras.BackgroundColor = Color.White;

            //Estilo da GV
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCompras.RowHeadersVisible = false;

            //Cabeça da GV
            dgvCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
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

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTxt();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemDTO dto = cboProduto.SelectedItem as ItemDTO;

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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                ComprasDTO dto = new ComprasDTO();
                dto.UsuarioId = UserSession.UsuarioLogado.Id;
                dto.Data = mkbDataCompra.Text;
                dto.FormaPagto = Convert.ToString(cboTipoPag.SelectedItem);

                ComprasBusiness buss = new ComprasBusiness();
                buss.Salvar(dto, carrinhoAdd.ToList());

                string msg = "Compra salva com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                string msg = vex.Message;

                frmAlert tela = new frmAlert();
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
    }
}
