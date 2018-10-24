using Catiotro_s.classes.Classes.Login;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Telas.Entregavel_I.Login;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginBusiness business = new LoginBusiness();
            string user = txtUser.Text;
            string pass = txtPass.Text;

            LoginDTO usuario = business.Logar(user, pass);


            if (usuario != null)
            {
                UserSession.UsuarioLogado = usuario;

                Menu tela = new Menu();
                tela.Show();
                this.Close();
            }
            else
            {
                string msg = "Nome de usuário ou senha incorretos.";

                frmAlert tela = new frmAlert();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness business = new LoginBusiness();
                string user = txtUser.Text;
                string pass = txtPass.Text;

                LoginDTO usuario = business.Logar(user, pass);


                if (usuario != null)
                {
                    UserSession.UsuarioLogado = usuario;

                    frmCadastrarLogin tela = new frmCadastrarLogin();
                    tela.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Catioro's Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    LoginBusiness business = new LoginBusiness();
                    string user = txtUser.Text;
                    string pass = txtPass.Text;

                    LoginDTO usuario = business.Logar(user, pass);


                    if (usuario != null)
                    {
                        UserSession.UsuarioLogado = usuario;

                        Menu tela = new Menu();
                        tela.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Catioro's Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEntrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    LoginBusiness business = new LoginBusiness();
                    string user = txtUser.Text;
                    string pass = txtPass.Text;

                    LoginDTO usuario = business.Logar(user, pass);


                    if (usuario != null)
                    {
                        UserSession.UsuarioLogado = usuario;

                        Menu tela = new Menu();
                        tela.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Catioro's Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
