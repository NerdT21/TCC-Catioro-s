using Catiotro_s.classes.Classes.Vendas.Produto;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_III.Produto_Vendas
{
    public partial class frmAlterarProduto : Form
    {
        public frmAlterarProduto()
        {
            InitializeComponent();
        }

        ProdutoDTO produto;

        public void LoadScreen(ProdutoDTO dto)
        {
            this.produto = dto;
            txtNome.Text = dto.Nome;
            txtMarca.Text = dto.Marca;
            txtDesc.Text = dto.Descricao;
            nudPreco.Value = dto.Preco;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Id = this.produto.Id;

                dto.Nome = txtNome.Text;
                dto.Marca = txtMarca.Text;
                dto.Descricao = txtDesc.Text;
                dto.Preco = nudPreco.Value;

                ProdutoBusiness business = new ProdutoBusiness();
                business.Alterar(dto);

                string msg = "Produto Alterado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
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
