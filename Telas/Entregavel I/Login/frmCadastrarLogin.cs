using Catiotro_s.classes.Classes.Login;
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Senha incorreta", "Catioro's", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                LoginDTO dto = new LoginDTO();
                dto.Nome = txtNome.Text;
                dto.Senha = txtSenha.Text;
                dto.NmUsuario = txtUsuario.Text;
                dto.Email = txtEmail.Text;
                dto.PermicaoADM = ckbAdm.Checked;
                dto.PermicaoCadastro = ckbCadastar.Checked;
                dto.PermicaoConsulta = ckbConsultar.Checked;

                LoginBusiness buss = new LoginBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Novo usuário criado com sucesso!", "Catioro's", MessageBoxButtons.OK);
                this.Close();
            
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("O nome de usuário já existe.", "Catioro's", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Ocorreu um erro: " +es.Message, "Catioro's", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
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
            else if (ckbConsultar.Checked == false)
            {
                ckbCadastar.Checked = false;
                ckbConsultar.Checked = false;
            }
        }
    }
}
