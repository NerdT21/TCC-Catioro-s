using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                classes.Classes.Agenda.ProdutoDTO dto = new classes.Classes.Agenda.ProdutoDTO();
                dto.Nome = txtNome.Text;
                dto.Marca = txtMarca.Text;
                dto.Descricao = txtDesc.Text;
                dto.Preco = nudPreco.Value;
                // dto.Imagem =imgProduto

                classes.Classes.Agenda.ProdutoBusiness business = new classes.Classes.Agenda.ProdutoBusiness();
                business.Salvar(dto);

                MessageBox.Show("Produto Cadastrado com sucesso!", "Catioro's", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Catioros's",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
