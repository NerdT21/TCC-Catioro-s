using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Compras;
using Catiotro_s.classes.Classes.Compras.ItemCompras;

namespace Catiotro_s.Telas.Entregavel_II.Controle_de_Compras
{
    public partial class frmVerCompras : UserControl
    {
        public frmVerCompras()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ComprasBusiness bus = new ComprasBusiness();
            List<ItemComprasView> dto = bus.Listar();

            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = dto;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            ComprasBusiness bus = new ComprasBusiness();
            List<ItemComprasView> dto = bus.Consultar(data);

            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.DataSource = dto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmVerCompras_Load(object sender, EventArgs e)
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

            //Fonte
            dgvCompras.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvCompras.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvCompras.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
