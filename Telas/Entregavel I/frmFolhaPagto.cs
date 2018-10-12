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
using Catiotro_s.PlugIn;
using FamosoAça.Screens.Entregavel_I;
using System.Globalization;

namespace Catiotro_s.Telas.Entregavel_I
{
    public partial class frmFolhaPagto : UserControl
    {
        public frmFolhaPagto()
        {
            InitializeComponent();
            CarregarCombos();
            GerarCredenciais();
        }

        void GerarCredenciais()
        {
            string nome = cboFuncionario.Text;
            FuncionarioDTO dto = cboFuncionario.SelectedItem as FuncionarioDTO;

            mkbCPF.Text = dto.Cpf;
            txtSalario.Text = dto.Salario.ToString();
            txtDepto.Text = dto.IdDepto.ToString();

            if (dto.Imagem == string.Empty)
            {
                pbxImgFuncionario.Image = null;
            }
            else
            {
                pbxImgFuncionario.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
            }
        }

        void CarregarCombos()
        {
            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = buss.Listar();

            cboFuncionario.ValueMember = nameof(FuncionarioDTO.Id);
            cboFuncionario.DisplayMember = nameof(FuncionarioDTO.Nome);
            cboFuncionario.DataSource = lista;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FolhaPagto pagto = new FolhaPagto();
            pagto.Salario = Convert.ToDecimal(txtSalario.Text);
            pagto.Faltas = Convert.ToInt32(nudFaltas.Value);
            pagto.HoraExtra = Convert.ToDateTime(mkbAtraso.Text);
            pagto.Atrasos = Convert.ToDateTime(mkbHE.Text);

            txtINSS.Text = pagto.CalcularINSS().ToString("F2");
            txtIR.Text = pagto.CalcularIR().ToString("F2");
            txtFGTS.Text = pagto.CalcularFGTS().ToString("F2");
            txtSalFam.Text = pagto.VerificarSalarioFamilia().ToString("F2");
            txtValTrans.Text = pagto.CalcularValeTransporte().ToString("F2");
            TxtSalLiq.Text = pagto.CalcularSalarioLiquido().ToString("F2");
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarCredenciais();
        }   
    
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
