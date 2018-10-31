using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Feito.Funcionarios;
using Catiotro_s.Consultar;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
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
            try
            {
                this.dto = dto;
                txtCidade.Text = dto.Cidade;
                txtEmail.Text = dto.Email;
                txtNome.Text = dto.Nome;
                txtSalario.Text = dto.Salario.ToString();
                mkbCEP.Text = dto.Cep;
                txtEndereco.Text = dto.Rua;
                txtNum.Text = dto.Numero.ToString();
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
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
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
                dto.Rua = txtEndereco.Text;
                dto.Numero = Convert.ToInt32(txtNum.Text);
                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxFoto.Image);

                FuncionarioBusiness buss = new FuncionarioBusiness();
                buss.Alterar(dto);

                string msg = "Funcionário alterado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();

                this.Close();
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
    }
}
