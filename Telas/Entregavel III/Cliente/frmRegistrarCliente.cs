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
            dta.Bairro = txtBairro.Text;
            dta.Rua = txtRua.Text;
            dta.NumeroCasa = Convert.ToInt32(txtNr.Text);
            dta.IdEstado = Convert.ToInt32(dto.Estado);
        }
    }
}
