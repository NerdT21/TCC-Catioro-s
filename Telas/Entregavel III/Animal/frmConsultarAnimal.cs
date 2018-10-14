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
            List<AnimalDTO> lista = business.Listar();

            dgvAnimal.DataSource = lista;
        }
        void CarregarGrid()
        {
            string nome = txtAnimal.Text;
            string nomeDono = txtDono.Text;

            AnimalBusiness buss = new AnimalBusiness();
            List<AnimalDTO> lista = buss.Consultar(nome, nomeDono);

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
    }
}
