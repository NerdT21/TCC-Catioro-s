using Catiotro_s.classes.Classes.AddConsultar.Animal;
using Catiotro_s.classes.Classes.Animal;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_III.Animal
{
    public partial class frmAlterarAnimal : Form
    {
        public frmAlterarAnimal()
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

        AnimalView animal;

        public void LoadScreen(AnimalView view)
        {
            this.animal = view;
            txtNomeAnimal.Text = view.Nome;
            txtCorPelo.Text = view.dsCorPelagem;
            txtObs.Text = view.dsObs;
            txtRaca.Text = view.dsRaca;
            txtTipoPelo.Text = view.dsPelagem;
            mkbDataNasc.Text = view.DtDataNasc;
            cboDono.SelectedItem = view.Cliente;
            cboSexo.SelectedItem = view.dsSexo;

            if (view.Imagem == string.Empty)
            {
                pbxImagem.Image = null;
            }
            else
            {
                pbxImagem.Image = PlugIn.ImagemPlugIn.ConverterParaImagem(view.Imagem);
            }          
        }

        private void frmAlterarAnimal_Load(object sender, EventArgs e)
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
                dto.Id = this.animal.Id;

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
                business.Alterar(dto);

                string msg = "Animal Alterado com sucesso!";

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
    }
}
