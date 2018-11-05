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
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Telas.Entregavel_II.Produtos_Compras;

namespace Catiotro_s.Telas.Entregavel_III.Produtos
{
    public partial class frmConsultarProdutos : UserControl
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ItemBusiness dto = new ItemBusiness();
            List<ItemView> lista = dto.Listar();

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string fornecedor = txtFornecedor.Text;

            ItemBusiness dto = new ItemBusiness();
            List<ItemView> lista = dto.Consultar(nome, fornecedor);

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = lista;
        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvProdutos.BorderStyle = BorderStyle.None;
            dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvProdutos.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvProdutos.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProdutos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProdutos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProdutos.BackgroundColor = Color.White;

            //Estilo da GV
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdutos.RowHeadersVisible = false;

            //Cabeça da GV
            dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvProdutos.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvProdutos.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvProdutos.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        ItemView item;

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = dgvProdutos.Rows[e.RowIndex].DataBoundItem as ItemView;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                string msg = "Selecione um item para alterá-lo.";
                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            else
            {
                frmAlterarItem tela = new frmAlterarItem();
                tela.LoadScreen(item);
                tela.ShowDialog();

                CarregarGrid();
            }   
        }
    }
}
