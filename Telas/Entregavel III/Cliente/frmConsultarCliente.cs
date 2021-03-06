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
using Catiotro_s.classes.Classes.AddConsultar.Cliente;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.Telas.Entregavel_III.Cliente;

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
            List<ClienteView> lista = buss.Listar();

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = lista;
        }

        void CarregarGrid()
        {
            string nome = txtprocurar.Text;
            string cpf = mkbCpf.Text;

            ClienteBusiness buss = new ClienteBusiness();
            List<ClienteView> lista = buss.Consultar(nome, cpf);

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = lista;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
            
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

            //Fonte
            dgvCliente.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvCliente.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvCliente.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        ClienteView cliente;

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = dgvCliente.Rows[e.RowIndex].DataBoundItem as ClienteView;
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                string msg = "Selecione um registro para alterá-lo.";
                frmAlert alert = new frmAlert();
                alert.LoadScreen(msg);
                alert.ShowDialog();
            }
            else
            {
                frmAlterarCliente tela = new frmAlterarCliente();
                tela.LoadScreen(cliente);
                tela.ShowDialog();

                CarregarGrid();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                string msg = "Selecione um registro para removê-lo.";
                frmAlert alert = new frmAlert();
                alert.LoadScreen(msg);
                alert.ShowDialog();
            }
            else
            {
                string msgm = "Quer mesmo apagar o registro " + cliente.id + "?" +
                    "\nObs: ao apagar este cliente, todos os outros registros nele vinculados serão perdidos.";

                frmQuestion tela = new frmQuestion();
                tela.LoadScreen(msgm);
                tela.ShowDialog();

                bool click = tela.BotaoYes;

                if (click == true)
                {
                    ClienteBusiness buss = new ClienteBusiness();
                    buss.Remover(cliente.id);

                    CarregarGrid();
                }
            }
        }
    }
}
