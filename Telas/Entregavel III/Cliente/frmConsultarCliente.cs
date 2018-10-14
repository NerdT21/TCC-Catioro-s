using System;
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
    }
}
