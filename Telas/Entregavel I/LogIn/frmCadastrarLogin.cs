using Catiotro_s.classes.Classes.Login;
using Catiotro_s.Consultar;
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

namespace Catiotro_s.Telas.Entregavel_I.Login
{
    public partial class frmCadastrarLogin : Form
    {
        public frmCadastrarLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Close();
        }

        private void frmCadastrarLogin_Load(object sender, EventArgs e)
        {

        }

        private void ckbAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdm.Checked == true)
            {
                ckbCadastar.Checked = true;
                ckbConsultar.Checked = true;
            }

            if (ckbConsultar.Checked == false)
            {
                ckbCadastar.Checked = false;
                ckbConsultar.Checked = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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

                LoginDTO dto = new LoginDTO();
                dto.Nome = txtUsuario.Text;
                dto.Senha = txtSenha.Text;
                dto.NmUsuario = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.PermicaoADM = ckbAdm.Checked;
                dto.PermicaoCadastro = ckbCadastar.Checked;
                dto.PermicaoConsulta = ckbConsultar.Checked;

                LoginBusiness buss = new LoginBusiness();
                buss.Salvar(dto);

                string msg = "Novo usuário criado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
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
