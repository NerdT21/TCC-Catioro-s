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

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            LoginBusiness business = new LoginBusiness();
            string user = txtUser.Text;
            string pass = txtPass.Text;

            LoginDTO usuario = business.Logar(user, pass);


            if (usuario != null)
            {
                frmCadastrarLogin tela = new frmCadastrarLogin();
                tela.Show();
            }
            else
            {
                MessageBox.Show("É preciso ser um administrador do sistema para acessar o cadastro de Logins.");
            }
            
            
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
                MessageBox.Show("Nome de usuário ou senha incorretos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
