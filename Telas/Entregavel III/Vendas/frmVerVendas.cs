using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Vendas;
using Catiotro_s.classes.Classes.Vendas.ProdutoVendas;

namespace Catiotro_s.Telas.Entregavel_III.Vendas
{
    public partial class frmVerVendas : UserControl
    {
        public frmVerVendas()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            VendaBusiness buss = new VendaBusiness();
            List<ProdutoVendasView> lista = buss.Listar();

            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = lista;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            VendaBusiness buss = new VendaBusiness();
            List<ProdutoVendasView> lista = buss.Consultar(data);

            dgvVendas.AutoGenerateColumns = false;
            dgvVendas.DataSource = lista;
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

            //Fonte
            dgvVendas.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvVendas.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvVendas.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
