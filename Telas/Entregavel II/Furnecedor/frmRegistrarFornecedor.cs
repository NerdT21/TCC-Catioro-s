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
using Catiotro_s.CustomException.TelasException;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarFornecedor : UserControl
    {
        public frmRegistrarFornecedor()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {

            EstadoBusiness biss = new EstadoBusiness();
            List<EstadoDTO> lista = biss.Listar();

            //DisplayMember = Motra,ValueMember=oque de verdade , DataSource = Lista
            cboEstado.ValueMember = nameof(EstadoDTO.Id);
            cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
            cboEstado.DataSource = lista;


        }

        private void txtCidadeF_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkbEstado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCidadeF_Click(object sender, EventArgs e)
        {

        }

        private void lblestado_Click(object sender, EventArgs e)
        {

        }

        private void lblCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeFor_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                EstadoDTO estado = cboEstado.SelectedItem as EstadoDTO;

                FornecedoresDTO dto = new FornecedoresDTO();

                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cidade = txtCidade.Text;
                dto.CEP = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IdEstado = estado.Id;

                FornecedoresBusiness business = new FornecedoresBusiness();
                business.Salvar(dto);

                string msg = "Fornecedor cadastrado com sucesso!";

                frmMessage tela = new frmMessage();
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

