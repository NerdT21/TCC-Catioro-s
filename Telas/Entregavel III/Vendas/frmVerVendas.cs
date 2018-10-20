using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_III.Vendas
{
    public partial class frmVerVendas : UserControl
    {
        public frmVerVendas()
        {
            InitializeComponent();
        }

        private void frmVerVendas_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvVendas.BorderStyle = BorderStyle.None;
            dgvVendas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvVendas.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvVendas.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvVendas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVendas.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvVendas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVendas.BackgroundColor = Color.White;

            //Estilo da GV
            dgvVendas.EnableHeadersVisualStyles = false;
            dgvVendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVendas.RowHeadersVisible = false;

            //Cabeça da GV
            dgvVendas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvVendas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
