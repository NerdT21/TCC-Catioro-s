﻿using System;
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
using Catiotro_s.PlugIn;
using MySql.Data.MySqlClient;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.CustomException;

namespace Catiotro_s.Telas.Entregavel_I.Funcionários
{
    public partial class frmCadastrarFuncionario : UserControl
    {
        public frmCadastrarFuncionario()
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

        private void frmCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DeptoDTO depto = cboDepto.SelectedItem as DeptoDTO;
                EstadoDTO estado = cboUF.SelectedItem as EstadoDTO;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Nome = txtNome.Text;
                dto.Rg = mkbRG.Text;
                dto.Salario = nudSalario.Value;
                dto.Cpf = mkbCPF.Text;
                dto.Telefone = mkbTelefone.Text;
                dto.Email = txtEmail.Text;
                dto.IdDepto = depto.Id;
                dto.Cidade = txtCidade.Text;
                dto.IdEstado = estado.Id;
                dto.Cep = mkbCEP.Text;
                dto.Rua = txtEndereco.Text;

                if (txtNum.Text == string.Empty)
                {
                    dto.Numero = 0;
                }
                else
                {
                    dto.Numero = Convert.ToInt32(txtNum.Text);
                }

                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxFoto.Image);

                FuncionarioBusiness buss = new FuncionarioBusiness();
                buss.Salvar(dto);

                MessageBox.Show("Funcionário cadastrado com suceso!!", "Catioro's", MessageBoxButtons.OK);
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    string msg = "Funcionario já está cadastrado. Verifique se o CPF está corretamente preenchido ou se ele já esta no sistema.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
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

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxFoto.ImageLocation = dialog.FileName;
            }
        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mkbCEP_KeyUp(object sender, KeyEventArgs e)
        {       
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(mkbCEP.Text);

                    txtEndereco.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboUF.Text = resposta.uf;

                }
                catch (Exception cex)
                {
                    string msg = "Não foi possível encontrar o CEP";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
        }

        private void frmCadastrarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mkbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
