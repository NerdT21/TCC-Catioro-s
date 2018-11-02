using Catiotro_s.classes.Classes.AddConsultar.Cliente;
using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_III.Cliente
{
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
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

        ClienteView cliente;

        public void LoadScreen(ClienteView dto)
        {
            this.cliente = dto;
            txtNome.Text = dto.Nome;
            txtEmail.Text = dto.Email;
            txtCEP.Text = dto.Cep;
            txtCidade.Text = dto.Cidade;
            txtNumero.Text = dto.Nome.ToString();
            txtRua.Text = dto.Rua;
            cboUF.SelectedItem = dto.Estado;
            mkbCadastro.Text = dto.DataCadastro;
            mkbCPF.Text = dto.DataCadastro;
            mkbNascimento.Text = dto.DataNascimento;
            mkbRG.Text = dto.Rg;
            mkbTelefone.Text = dto.Telefone;

            if (dto.Imagem == null)
            {
                pbxImagem.Image = null;
            }
            else
            {
                pbxImagem.Image = PlugIn.ImagemPlugIn.ConverterParaImagem(dto.Imagem);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                EstadoDTO dto = cboUF.SelectedItem as EstadoDTO;

                ClienteDTO dta = new ClienteDTO();
                dta.id = this.cliente.id;

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
                business.Alterar(dta);

                string msg = "Cliente Cadastrado com sucesso";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            catch (ValidacaoException vex)
            {
                frmAlert tela = new frmAlert();
                tela.LoadScreen(vex.Message);
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
    }
}
