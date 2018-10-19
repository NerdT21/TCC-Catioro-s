using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Animal;
using Catiotro_s.classes.Classes.AddConsultar.Animal;

namespace Catiotro_s.Consultar
{
    public partial class frmConsultarAnimal : UserControl
    {
        public frmConsultarAnimal()
        {
            InitializeComponent();
            AutoCarregar();
        }
        void AutoCarregar()
        {
            AnimalBusiness business = new AnimalBusiness();
            List<AnimalView> lista = business.Listar();

            dgvAnimal.DataSource = lista;
        }
        void CarregarGrid()
        {
            string nome = txtAnimal.Text;
            string nomeDono = txtDono.Text;

            AnimalBusiness buss = new AnimalBusiness();
            List<AnimalView> lista = buss.Consultar(nome, nomeDono);

            dgvAnimal.DataSource = lista;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmConsultarAnimal_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvAnimal.BorderStyle = BorderStyle.None;
            dgvAnimal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvAnimal.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvAnimal.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvAnimal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAnimal.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvAnimal.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAnimal.BackgroundColor = Color.White;

            //Estilo da GV
            dgvAnimal.EnableHeadersVisualStyles = false;
            dgvAnimal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAnimal.RowHeadersVisible = false;

            //Cabeça da GV
            dgvAnimal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvAnimal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
