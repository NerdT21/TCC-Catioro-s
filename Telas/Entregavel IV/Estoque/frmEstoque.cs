using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Estoque;

namespace Catiotro_s.Telas.Entregavel_IV.Estoque
{
    public partial class frmEstoque : UserControl
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        void AutoCarregarGrid()
        {
            EstoqueBusiness buss = new EstoqueBusiness();
            List<EstoqueView> list = buss.Listar();

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = list;
        }

        void CarregarGrid()
        {
            string produto = txrProduto.Text;

            EstoqueBusiness buss = new EstoqueBusiness();
            List<EstoqueView> list = buss.Consultar(produto);

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = list;
        }
    }
}
