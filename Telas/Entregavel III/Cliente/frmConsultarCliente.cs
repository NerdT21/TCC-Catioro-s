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

namespace Catiotro_s.Consultar
{
    public partial class frmConsultarCliente : UserControl
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            ClienteBusiness buss = new ClienteBusiness();
            List<ClienteDTO> lista = buss.Listar();

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtprocurar.Text;
            string cpf = mkbCpf.Text;

            ClienteBusiness buss = new ClienteBusiness();
            List<ClienteDTO> lista = buss.Consultar(nome, cpf);

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvCliente.BorderStyle = BorderStyle.None;
            dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvCliente.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvCliente.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvCliente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCliente.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvCliente.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCliente.BackgroundColor = Color.White;

            //Estilo da GV
            dgvCliente.EnableHeadersVisualStyles = false;
            dgvCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCliente.RowHeadersVisible = false;

            //Cabeça da GV
            dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvCliente.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
