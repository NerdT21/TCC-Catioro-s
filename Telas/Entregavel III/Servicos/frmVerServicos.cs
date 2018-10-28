using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catiotro_s.classes.Classes.Servicos;
using Catiotro_s.classes.Classes.Servico;

namespace Catiotro_s.Telas.Entregavel_III.Servicos
{
    public partial class frmVerServicos : UserControl
    {
        public frmVerServicos()
        {
            InitializeComponent();
            AutoCarregarGrid();
        }

        void AutoCarregarGrid()
        {
            ServicoBusiness buss = new ServicoBusiness();
            List<ServicoView> lista = buss.Listar();

            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.DataSource = lista;
        }

        void CarregarGrid()
        {
            string animal = txtAnimal.Text;
            string data = txtData.Text;

            ServicoBusiness buss = new ServicoBusiness();
            List<ServicoView> lista = buss.Consultar(animal, data);

            dgvServicos.AutoGenerateColumns = false;
            dgvServicos.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
