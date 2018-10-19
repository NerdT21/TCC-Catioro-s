using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_III.Produtos
{
    public partial class frmConsultarProdutos : UserControl
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
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

        }
    }
}
