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
    public partial class frmConsultaFuncionario : UserControl
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioDTO> dto = buss.Listar();

            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = dto;
        }


        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string cpf = mkbCpf.Text;

            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioDTO> dto = buss.Consultar(nome, cpf);

            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = dto;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvFuncionario.BorderStyle = BorderStyle.None;
            dgvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvFuncionario.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFuncionario.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFuncionario.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFuncionario.BackgroundColor = Color.White;

            //Estilo da GV
            dgvFuncionario.EnableHeadersVisualStyles = false;
            dgvFuncionario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFuncionario.RowHeadersVisible = false;

            //Cabeça da GV
            dgvFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
