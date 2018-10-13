using Catiotro_s.Consultar;
using Catiotro_s.Resgistros;
using Catiotro_s.Telas.Entregavel_I;
using Catiotro_s.Telas.Entregavel_I.Funcionários;
using Catiotro_s.Telas.Entregavel_II.Controle_de_Compras;
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
            //Fechao o progrma por inteiro 
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmRegistrarFornecedor tela = new frmRegistrarFornecedor();
            OpenScreen(tela);
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarAnimal tela = new frmRegistrarAnimal();
            OpenScreen(tela);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente tela = new frmRegistrarCliente();
            OpenScreen(tela);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Entregavel_II.Produto.frmRegistrarProduto tela = new Telas.Entregavel_II.Produto.frmRegistrarProduto();
            OpenScreen(tela);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor tela = new frmConsultarFornecedor();
            OpenScreen(tela);
        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarAnimal tela = new frmConsultarAnimal();
            OpenScreen(tela);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarCliente tela = new frmConsultarCliente();
            OpenScreen(tela);
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Entregavel_II.Produto.frmConsultarProduto tela = new Telas.Entregavel_II.Produto.frmConsultarProduto();
            OpenScreen(tela);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Home tela = new Telas.Home();
            OpenScreen(tela);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras tela = new frmCompras();
            OpenScreen(tela);
        }

        private void verComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerCompras tela = new frmVerCompras();
            OpenScreen(tela);
        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
           //Codigo pra mexer a tela 
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

    }
}
