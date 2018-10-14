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

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarAnimal : UserControl
    {
        public frmRegistrarAnimal()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAnimal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblObs_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorPelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpedigree_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalDTO dto = new AnimalDTO();
                dto.NomeAnimal = txtNomeAnimal.Text;
                dto.Sexo = cboSexo.Text;
                dto.IdRaca = Convert.ToInt32(txtRaca.Text);
                dto.Pelagem = txtTipoPelo.Text;
                dto.CorPelo = txtCorPelo.Text;
                dto.Pedigree = txtPedigree.Text;
                dto.Obs = txtObs.Text;
                dto.IdCliente = Convert.ToInt32(txtNomeDono.Text);
                dto.IdCliente = Convert.ToInt32(txtEmailDono.Text);

                AnimalBusiness business = new AnimalBusiness();
                business.Salvar(dto);
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Catioro's", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
