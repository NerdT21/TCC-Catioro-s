using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Servicos;
using Catiotro_s.classes.Classes.Servico;

namespace Catiotro_s.Telas.Entregavel_III.Servicos
{
    public partial class frmVerServicos : UserControl
    {
        public frmVerServicos()
        {
            InitializeComponent();
            AutoCarregarGrid();
        }

        void AutoCarregarGrid()
        {
            ServicoBusiness buss = new ServicoBusiness();
            List<ServicoView> lista = buss.Listar();

            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string animal = txtAnimal.Text;
            string data = txtData.Text;

            ServicoBusiness buss = new ServicoBusiness();
            List<ServicoView> lista = buss.Consultar(animal, data);

            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmVerServicos_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvServicos.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvServicos.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServicos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvServicos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvServicos.BackgroundColor = Color.White;

            //Estilo da GV
            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvServicos.RowHeadersVisible = false;

            //Cabeça da GV
            dgvServicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvServicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvServicos.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvServicos.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvServicos.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }
    }
}
