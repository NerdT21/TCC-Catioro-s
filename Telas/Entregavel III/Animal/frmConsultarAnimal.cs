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
    }
}
