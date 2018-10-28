using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Estoque;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.classes.Classes.Vendas.Produto;

namespace Catiotro_s.Telas.Entregavel_II.Produto
{
    public partial class frmRegistrarProduto : UserControl
    {
        public frmRegistrarProduto()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Nome = txtNome.Text;
                dto.Marca = txtMarca.Text;
                dto.Descricao = txtDesc.Text;
                dto.Preco = nudPreco.Value;

                ProdutoBusiness business = new ProdutoBusiness();
                int pk = business.Salvar(dto);

                EstoqueDTO estoque = new EstoqueDTO();
                estoque.Produto = txtNome.Text;
                estoque.ItemProdutoId = pk;
                estoque.QtdEstocado = 0;

                EstoqueBusiness buss = new EstoqueBusiness();
                buss.Salvar(estoque);

                string msg = "Produto Cadastrado com sucesso!";

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

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
