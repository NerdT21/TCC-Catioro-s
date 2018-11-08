using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Gastos_Adicionais;

namespace Catiotro_s.Telas.Entregavel_IV.Fluxo_de_Caixa
{
    public partial class frmConsultarGastosAdicionais : UserControl
    {
        public frmConsultarGastosAdicionais()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            GastosBusiness buss = new GastosBusiness();
            List<GastosDTO> lista = buss.Listar();
            
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string data = mkbData.Text;

            GastosBusiness buss = new GastosBusiness();
            List<GastosDTO> lista = buss.Consultar(data);

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmConsultarGastosAdicionais_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvGastos.BorderStyle = BorderStyle.None;
            dgvGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvGastos.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvGastos.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvGastos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGastos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvGastos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGastos.BackgroundColor = Color.White;

            //Estilo da GV
            dgvGastos.EnableHeadersVisualStyles = false;
            dgvGastos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGastos.RowHeadersVisible = false;

            //Cabeça da GV
            dgvGastos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvGastos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvGastos.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvGastos.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvGastos.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
