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
using Catiotro_s.CustomException.TelasException;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarCliente : UserControl
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
            CarregarData();
            CarregarCombos();
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
            try
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
                dta.Rua = txtRua.Text;
                dta.Numero = Convert.ToInt32(txtNumero.Text);
                dta.EstadoId = Convert.ToInt32(dto.Id);

                ClienteBusiness business = new ClienteBusiness();
                business.Salvar(dta);

                string msg = "Cliente Cadastrado com sucesso";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (Exception ex )
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
           
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(txtCEP.Text);

                    txtRua.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboUF.Text = resposta.uf;

                }
                catch (Exception)
                {
                    string msg = "Não foi possível encontrar o CEP";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
        }
    }
}
