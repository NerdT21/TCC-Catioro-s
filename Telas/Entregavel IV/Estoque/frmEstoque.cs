using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.CustomException.TelasException;

namespace Catiotro_s.Telas.Entregavel_IV.Estoque
{
    public partial class frmEstoque : UserControl
    {
        public frmEstoque()
        {
            InitializeComponent();
            AutoCarregarGrid();
        }

        void AutoCarregarGrid()
        {
            EstoqueBusiness buss = new EstoqueBusiness();
            List<EstoqueDTO> list = buss.Listar();

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = list;
        }

        void CarregarGrid()
        {
            string produto = txrProduto.Text;

            EstoqueBusiness buss = new EstoqueBusiness();
            List<EstoqueView> list = buss.Consultar(produto);

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = list;
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvEstoque.BorderStyle = BorderStyle.None;
            dgvEstoque.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvEstoque.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvEstoque.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvEstoque.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstoque.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvEstoque.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvEstoque.BackgroundColor = Color.White;

            //Estilo da GV
            dgvEstoque.EnableHeadersVisualStyles = false;
            dgvEstoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEstoque.RowHeadersVisible = false;

            //Cabeça da GV
            dgvEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvEstoque.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvEstoque.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvEstoque.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void brnBuscar_Click(object sender, EventArgs e)
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
    }
}
