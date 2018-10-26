using Catiotro_s.PlugIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Diferenciais
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        EmailPlugin email = new EmailPlugin();

        void InicializeValores()
        {          
            email.envioOK = false;
            email.emailDestinatario = txtPara.Text;
            email.assunto = txtAssunto.Text;
            email.mensagem = txtMsg.Text;

            email.emailAdm = txtDe.Text;

            string validador = txtDe.Text;
            int qtdCaracteres = validador.Length;
            int posicaoArroba = validador.IndexOf("@");

            int posicaoServidor = qtdCaracteres - posicaoArroba; 

            string servidor = validador.Substring(posicaoArroba, posicaoServidor);

            if (servidor == "@gmail.com")
            {
                email.servidor = "gmail.com";
            }
            else
            {
                email.servidor = "hotmail.com";
            }


            email.senha = txtSenha.Text;
        }

        void Email()
        {
            InicializeValores();
            if (email.EnviarEmail())
                MessageBox.Show("Email enviado com sucesso!!!");
            else
                MessageBox.Show("Erro ao enviar o email");

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Email();
        }
    }
}
