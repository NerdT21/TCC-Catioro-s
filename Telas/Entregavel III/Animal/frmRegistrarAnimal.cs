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
using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.CustomException;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarAnimal : UserControl
    {
        public frmRegistrarAnimal()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            ClienteBusiness biss = new ClienteBusiness();
            List<ClienteDTO> lista = biss.ListarPraCombo();

            cboDono.ValueMember = nameof(ClienteDTO.id);
            cboDono.DisplayMember = nameof(ClienteDTO.Nome);
            cboDono.DataSource = lista;
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
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxImagem.ImageLocation = dialog.FileName;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {          
            try
            {
                ClienteDTO IdCliente = cboDono.SelectedItem as ClienteDTO;

                AnimalDTO dto = new AnimalDTO();
                dto.NomeAnimal = txtNomeAnimal.Text;
                dto.Sexo = cboSexo.Text;
                dto.Raca = txtRaca.Text;
                dto.Pelagem = txtTipoPelo.Text;
                dto.CorPelo = txtCorPelo.Text;
                dto.Obs = txtObs.Text;
                dto.IdCliente = IdCliente.id;
                dto.DataNasc = mkbDataNasc.Text;
                dto.Imagem = PlugIn.ImagemPlugIn.ConverterParaString(pbxImagem.Image);

                AnimalBusiness business = new AnimalBusiness();
                business.Salvar(dto);

                string msg = "Animal Cadastrado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                frmAlert tela = new frmAlert();
                tela.LoadScreen(vex.Message);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNomeAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
