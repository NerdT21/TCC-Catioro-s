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
using Catiotro_s.classes.Classes.Agenda;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarCliente : UserControl
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
            CarregarData();
        }

        void CarregarCombos()
        {
            EstadoBusiness buss = new EstadoBusiness();
            List<EstadoDTO> lista = buss.Listar();

            cboUF.ValueMember = nameof(EstadoDTO.Id);
            cboUF.DisplayMember = nameof(EstadoDTO.Estado);
            cboUF.DataSource = lista;
        }

        void CarregarData()
        {
            DateTime data = DateTime.Now;
            DateTime dataAtual = data.Date;
            string SoData = dataAtual.ToString();

            mkbCadastro.Text = SoData;
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EstadoDTO dto = cboUF.SelectedItem as EstadoDTO;

            ClienteDTO dta = new ClienteDTO();
            dta.Nome = txtNome.Text;
            dta.Email = txtEmail.Text;
            dta.DataNascimento = mkbNascimento.Text;
            dta.Rg = mkbRG.Text;
            dta.Cpf = mkbCPF.Text;
            dta.Telefone = mkbTelefone.Text;
            dta.Cidade = txtCidade.Text;
            dta.DataCadastro = mkbCadastro.Text;
            dta.Cep = txtCEP.Text;
            dta.EstadoId = Convert.ToInt32(dto.Id);           

            ClienteBusiness business = new ClienteBusiness();
            business.Salvar(dta);

            MessageBox.Show("Cliente Cadastrado com sucesso", "Catioro´s", MessageBoxButtons.OK);
        }

        private void pbxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxImagem.ImageLocation = dialog.FileName;
            }
        }
    }
}
