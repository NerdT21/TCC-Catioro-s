﻿using Catiotro_s.Consultar;
using Catiotro_s.Resgistros;
using Catiotro_s.Telas.Entregavel_I;
using Catiotro_s.Telas.Entregavel_I.Funcionários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void OpenScreen(UserControl control)
        {
            if (pnlCentro.Controls.Count == 1)
                pnlCentro.Controls.RemoveAt(0);
            pnlCentro.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private bool mover;
        private int cX, cY;

        private void pnlTopo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mover = false;
            }
        }

        private void pnlTopo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlTopo.Left);
                this.Top += e.Y - (cY - pnlTopo.Top);
            }
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario tela = new frmCadastrarFuncionario();
            OpenScreen(tela);
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario tela = new frmConsultaFuncionario();
            OpenScreen(tela);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarDepartamento tela = new frmRegistrarDepartamento();
            OpenScreen(tela);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
            this.Close();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolhaPagto tela = new frmFolhaPagto();
            OpenScreen(tela);
        }

        private void pnlCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

    }
}
