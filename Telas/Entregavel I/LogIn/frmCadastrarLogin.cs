using Catiotro_s.classes.Classes.Login;
using Catiotro_s.Consultar;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Resgistros;
using Catiotro_s.Telas.Entregavel_I;
using Catiotro_s.Telas.Entregavel_I.Funcionários;
using Catiotro_s.Telas.Entregavel_I.LogIn;
using Catiotro_s.Telas.Entregavel_II.Controle_de_Compras;
using Catiotro_s.Telas.Entregavel_III.Produtos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Catiotro_s.Telas.Entregavel_I.LogIn
{
    public partial class frmCadastrarLogin : Form
    {
        public frmCadastrarLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrarLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text != txtConfirm.Text)
                {
                    string msgm = "Senha incorreta!";

                    frmAlert alert = new frmAlert();
                    alert.LoadScreen(msgm);
                    alert.ShowDialog();
                }
                else
                {
                    LoginDTO dto = new LoginDTO();
                    dto.Nome = txtUsuario.Text;
                    dto.Senha = txtSenha.Text;
                    dto.NmUsuario = txtNome.Text;
                    dto.Email = txtEmail.Text;
                    dto.PermicaoADM = ckbAdm.Checked;
                    dto.PermicaoAtendente = ckbAtendente.Checked;
                    dto.PermicaoCompras = ckbCompras.Checked;
                    dto.PermicaoFinanceiro = ckbFinanceiro.Checked;
                    dto.PermicaoFuncionarios = ckbPagamentos.Checked;
                    dto.PermicaoServicos = ckbServico.Checked;
                    dto.PermicaoVendedor = ckbVendas.Checked;
                    dto.PermicaoFornecedor = ckbFornecedores.Checked;
                    dto.PermicaoProdutos = ckbProdutos.Checked;

                    LoginBusiness buss = new LoginBusiness();
                    buss.Salvar(dto);

                    string msg = "Novo usuário criado com sucesso!";

                    frmMessage tela = new frmMessage();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }

            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    string msg = "O nome de usuário já existe.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
            catch (ValidacaoException vex)
            {
                string msg = vex.Message;

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }

        private void ckbAdm_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbFinanceiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbAtendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbAdm_CheckedChanged_2(object sender, EventArgs e)
        {
            if (ckbAdm.Checked == true)
            {
                string msg = "Ao definir esse usuário com permissão ADM, ele terá acesso a todas as funções do sistema." +
                    "\n Deseja mesmo torná-lo ADM?";

                frmQuestion tela = new frmQuestion();
                tela.LoadScreen(msg);
                tela.ShowDialog();

                bool click = tela.BotaoYes;

                if (click == true)
                {
                    ckbAtendente.Checked = true;
                    ckbCompras.Checked = true;
                    ckbFinanceiro.Checked = true;
                    ckbPagamentos.Checked = true;
                    ckbServico.Checked = true;
                    ckbVendas.Checked = true;
                    ckbFornecedores.Checked = true;
                    ckbProdutos.Checked = true;
                }
            }
            else
            {
                ckbAtendente.Checked = false;
                ckbCompras.Checked = false;
                ckbFinanceiro.Checked = false;
                ckbPagamentos.Checked = false;
                ckbServico.Checked = false;
                ckbVendas.Checked = false;
                ckbFornecedores.Checked = false;
                ckbProdutos.Checked = false;
            }
        }
    }
}


