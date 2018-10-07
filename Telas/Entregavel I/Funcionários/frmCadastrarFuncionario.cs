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
using Catiotro_s.classes.Classes.Agenda;

namespace Catiotro_s.Telas.Entregavel_I.Funcionários
{
    public partial class frmCadastrarFuncionario : UserControl
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        void CarregarCombos()
        {
            EstadoBusiness buss = new EstadoBusiness();
            List<FuncionarioDTO> lista = buss.Listar();

            cbo
        }

        private void frmCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
