using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_IV.Floxo_de_Caixa
{
    public partial class frmFluxoDeCaixa : UserControl
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }

        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvFluxoDeCaixa.BorderStyle = BorderStyle.None;
            dgvFluxoDeCaixa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvFluxoDeCaixa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFluxoDeCaixa.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFluxoDeCaixa.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFluxoDeCaixa.BackgroundColor = Color.White;

            //Estilo da GV
            dgvFluxoDeCaixa.EnableHeadersVisualStyles = false;
            dgvFluxoDeCaixa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFluxoDeCaixa.RowHeadersVisible = false;

            //Cabeça da GV
            dgvFluxoDeCaixa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFluxoDeCaixa.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvFluxoDeCaixa.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvFluxoDeCaixa.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFluxoDeCaixa.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
