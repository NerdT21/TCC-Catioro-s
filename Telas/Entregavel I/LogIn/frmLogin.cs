using Catiotro_s.classes.Classes.Login;
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

namespace Catiotro_s
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void lblRegistrar_Click(object sender, EventArgs e)
        //{
        //    LoginBusiness business = new LoginBusiness();
        //    string user = txtUser.Text;
        //    string pass = txtPass.Text;

        //    LoginDTO usuario = business.Logar(user, pass);


        //    if (usuario != null)
        //    {
        //        frmCadastrarLogin tela = new frmCadastrarLogin();
        //        tela.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("É preciso ser um administrador do sistema para acessar o cadastro de Logins.");
        //    }


        //}

        //private void btnEntrar_Click(object sender, EventArgs e)
        //{
        //    LoginBusiness business = new LoginBusiness();
        //    string user = txtUser.Text;
        //    string pass = txtPass.Text;

        //    LoginDTO usuario = business.Logar(user, pass);


        //    if (usuario != null)
        //    {
        //        UserSession.UsuarioLogado = usuario;

        //        Menu tela = new Menu();
        //        tela.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nome de usuário ou senha incorretos.");
        //    }
        //}

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
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

        private void lblRegistrar_Click_1(object sender, EventArgs e)
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

        private void pbxClose_Click(object sender, EventArgs e)
        {
            //Fechao o progrma por inteiro 
            Application.Exit();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {


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

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
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
    }
}
