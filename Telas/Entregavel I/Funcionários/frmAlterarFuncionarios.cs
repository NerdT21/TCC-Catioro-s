using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Feito.Funcionarios;
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

namespace Catiotro_s.Telas.Entregavel_I.Funcionários
{
    public partial class frmAlterarFuncionarios : Form
    {
        public frmAlterarFuncionarios()
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

            DeptoBusiness business = new DeptoBusiness();
            List<DeptoDTO> list = business.Listar();

            cboDepto.ValueMember = nameof(DeptoDTO.Id);
            cboDepto.DisplayMember = nameof(DeptoDTO.Nome);
            cboDepto.DataSource = list;
        }

        FuncionarioView dto;

        public void LoadScreen(FuncionarioView dto)
        {
            this.dto = dto;
            txtCidade.Text = dto.Cidade;
            txtEmail.Text = dto.Email;
            txtNome.Text = dto.Nome;
            txtSalario.Text = dto.Salario.ToString();
            mkbCEP.Text = dto.Cep;
            mkbCPF.Text = dto.Cpf;
            mkbRG.Text = dto.Rg;
            mkbTelefone.Text = dto.Telefone;
            cboDepto.SelectedItem = dto.Depto;
            cboUF.SelectedItem = dto.Estado;

            if (dto.Imagem == null)
            {
                pbxFoto.Image = null;
            }
            else
            {
                pbxFoto.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DeptoDTO depto = cboDepto.SelectedItem as DeptoDTO;
                EstadoDTO estado = cboUF.SelectedItem as EstadoDTO;

                int funcio = this.dto.Id;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = funcio;

                dto.Nome = txtNome.Text;
                dto.Rg = mkbRG.Text;
                dto.Salario = Convert.ToDecimal(txtSalario.Text);
                dto.Cpf = mkbCPF.Text;
                dto.Telefone = mkbTelefone.Text;
                dto.Email = txtEmail.Text;
                dto.IdDepto = depto.Id;
                dto.Cidade = txtCidade.Text;
                dto.IdEstado = estado.Id;
                dto.Cep = mkbCEP.Text;
                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxFoto.Image);

                FuncionarioBusiness buss = new FuncionarioBusiness();
                buss.Alterar(dto);

                MessageBox.Show("Funcionário alterado com suceso!!", "Catioro's", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Catioro's",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
