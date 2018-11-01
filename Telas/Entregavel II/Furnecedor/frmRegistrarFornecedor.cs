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
using Catiotro_s.CustomException;
using MySql.Data.MySqlClient;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarFornecedor : UserControl
    {
        public frmRegistrarFornecedor()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {

            EstadoBusiness biss = new EstadoBusiness();
            List<EstadoDTO> lista = biss.Listar();

            //DisplayMember = Motra,ValueMember=oque de verdade , DataSource = Lista
            cboEstado.ValueMember = nameof(EstadoDTO.Id);
            cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
            cboEstado.DataSource = lista;


        }

        private void txtCidadeF_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkbEstado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCidadeF_Click(object sender, EventArgs e)
        {

        }

        private void lblestado_Click(object sender, EventArgs e)
        {

        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeFor_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                EstadoDTO estado = cboEstado.SelectedItem as EstadoDTO;

                FornecedoresDTO dto = new FornecedoresDTO();

                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cidade = txtCidade.Text;
                dto.CEP = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IdEstado = estado.Id;
                dto.Rua = txtRua.Text;
                dto.Numero = Convert.ToInt32(txtNumero.Text);

                FornecedoresBusiness business = new FornecedoresBusiness();
                business.Salvar(dto);

                string msg = "Fornecedor cadastrado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                string msg = vex.Message;

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    string msg = "Esse fornecedor já está cadastrado. " +
                        "Verifique se o CNPJ está corretamente preenchido ou se ele já está cadastrado no sistema.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void mkbCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(mkbCep.Text);

                    txtRua.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboEstado.Text = resposta.uf;

                }
                catch (Exception cex)
                {
                    string msg = "Não foi possível encontrar o CEP";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

