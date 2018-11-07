using Catiotro_s.classes.Classes.Login;
using Catiotro_s.Consultar;
using Catiotro_s.Resgistros;
using Catiotro_s.Telas.Diferenciais;
using Catiotro_s.Telas.Entregavel_I;
using Catiotro_s.Telas.Entregavel_I.Funcionários;
using Catiotro_s.Telas.Entregavel_I.LogIn;
using Catiotro_s.Telas.Entregavel_II.Controle_de_Compras;
using Catiotro_s.Telas.Entregavel_III.Produtos;
using Catiotro_s.Telas.Entregavel_III.Servicos;
using Catiotro_s.Telas.Entregavel_III.Vendas;
using Catiotro_s.Telas.Entregavel_IV.Estoque;
using Catiotro_s.Telas.Entregavel_IV.Floxo_de_Caixa;
using Catiotro_s.Telas.Entregavel_IV.Fluxo_de_Caixa;
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
            VerificarPermissoes();
        }

        void VerificarPermissoes()
        {
            if (UserSession.UsuarioLogado.PermicaoADM == false)
            {
                if (UserSession.UsuarioLogado.PermicaoAtendente == false)
                {
                    animalToolStripMenuItem.Enabled = false;
                    clienteToolStripMenuItem.Enabled = false;
                    clienteToolStripMenuItem1.Enabled = false;
                    animalToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoCompras == false)
                {
                    compraToolStripMenuItem.Enabled = false;
                    verComprasToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoVendedor == false)
                {
                    verVendasToolStripMenuItem.Enabled = false;
                    vendaToolStripMenuItem.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoFinanceiro == false)
                {
                    financeiroToolStripMenuItem.Enabled = false;
                    gastosToolStripMenuItem.Enabled = false;
                    verGastosToolStripMenuItem.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoFuncionarios == false)
                {
                    funcionáriosToolStripMenuItem.Enabled = false;
                    funcionáriosToolStripMenuItem1.Enabled = false;
                    folhaDePagamentoToolStripMenuItem.Enabled = false;
                    pamentosToolStripMenuItem.Enabled = false;
                    departamentosToolStripMenuItem.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoServicos == false)
                {
                    serviçoToolStripMenuItem1.Enabled = false;
                    verServiçosToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoFornecedor == false)
                {
                    fornecedorToolStripMenuItem.Enabled = false;
                    fornecedorToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoProdutos == false)
                {
                    produtoToolStripMenuItem1.Enabled = false;
                    itensToolStripMenuItem.Enabled = false;
                    produtoToolStripMenuItem2.Enabled = false;
                    itensToolStripMenuItem1.Enabled = false;
                }

                if (UserSession.UsuarioLogado.PermicaoVendedor == false &&
                    UserSession.UsuarioLogado.PermicaoCompras == false &&
                    UserSession.UsuarioLogado.PermicaoServicos == false && 
                    UserSession.UsuarioLogado.PermicaoFinanceiro == false)
                {
                    compraEVendaToolStripMenuItem.Enabled = false;
                }
            }
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
            frmLogin tela = new frmLogin();
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
            //
            frmProdutos tela = new frmProdutos();
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
            frmConsultarProdutos tela = new frmConsultarProdutos();
            OpenScreen(tela);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Home tela = new Telas.Home();
            OpenScreen(tela);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Telas.Entregavel_II.Produto.frmRegistrarProduto tela = new Telas.Entregavel_II.Produto.frmRegistrarProduto();
            OpenScreen(tela);
        }
        
        private void itensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Entregavel_II.Produto.frmConsultarProduto tela = new Telas.Entregavel_II.Produto.frmConsultarProduto();
            OpenScreen(tela);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque tela = new frmEstoque();
            OpenScreen(tela);
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFluxoDeCaixa tela = new frmFluxoDeCaixa();
            OpenScreen(tela);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras tela = new frmCompras();
            OpenScreen(tela);
        }

        private void verComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerCompras tela = new frmVerCompras();
            OpenScreen(tela);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas tela = new frmVendas();
            OpenScreen(tela);
        }

        private void verVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerVendas tela = new frmVerVendas();
            OpenScreen(tela);
        }

        private void compraEVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerServicos tela = new frmVerServicos();
            OpenScreen(tela);
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmServico tela = new frmServico();
            OpenScreen(tela);
        }

        private void pamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFolha tela = new frmVerFolha();
            OpenScreen(tela);
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGastoAdicional tela = new frmGastoAdicional();
            OpenScreen(tela);
        }

        private void verGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarGastosAdicionais tela = new frmConsultarGastosAdicionais();
            OpenScreen(tela);
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmail tela = new frmEmail();
            tela.Show();
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSite tela = new frmSite();
            tela.Show();
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
