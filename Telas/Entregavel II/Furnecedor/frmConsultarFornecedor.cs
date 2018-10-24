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
            List<FornecedoresDTO> lista = buss.ListarPraGrid();

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

        private void frmConsultarFornecedor_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvFornecedor.BorderStyle = BorderStyle.None;
            dgvFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvFornecedor.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvFornecedor.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFornecedor.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFornecedor.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFornecedor.BackgroundColor = Color.White;

            //Estilo da GV
            dgvFornecedor.EnableHeadersVisualStyles = false;
            dgvFornecedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFornecedor.RowHeadersVisible = false;

            //Cabeça da GV
            dgvFornecedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFornecedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvFornecedor.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvFornecedor.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFornecedor.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
