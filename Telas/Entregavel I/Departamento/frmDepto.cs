using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Resgistros
{
    public partial class frmRegistrarDepartamento : UserControl
    {
        public frmRegistrarDepartamento()
        {
            InitializeComponent();
            AutoCarregar();
        }

        public void Cadastro()
        {
           // try
           // {
                //Vai intanciar o DTO e dps joga um valor nesse DTO
                classes.Classes.Cliente.DeptoDTO dto = new classes.Classes.Cliente.DeptoDTO();
                dto.Nome = txtDepto.Text;

                //Chama a função de salvar de business que em sua vez grava essas açoes no DTO 
                classes.Classes.Cliente.DeptoBusiness business = new classes.Classes.Cliente.DeptoBusiness();
                business.Salvar(dto);

                //Exibe de uma msg de suceso 
                MessageBox.Show("Departamento cadastrado.", "Catioro's", MessageBoxButtons.OK);

            //}
            //catch (Exception ex)
            //{
            //    //Caso o try nn funcione o Catch roda e exibe uma msg de erro 
            //  MessageBox.Show("Ocorreu um Erro: " + ex.Message);
            //}
        }
         public void CarregarGrid()
         {
            string depto = txtProcurarDepto.Text;

            classes.Classes.Cliente.DeptoBusiness business = new classes.Classes.Cliente.DeptoBusiness();
            List<classes.Classes.Cliente.DeptoDTO> dto = business.Consultar(depto);

            dgvDepto.AutoGenerateColumns = false;
            dgvDepto.DataSource = dto;
         }

        public void AutoCarregar()
        {
            classes.Classes.Cliente.DeptoBusiness busines = new classes.Classes.Cliente.DeptoBusiness();
            List<classes.Classes.Cliente.DeptoDTO> dto = busines.Listar();

            dgvDepto.AutoGenerateColumns = false;
            dgvDepto.DataSource = dto;
        }




        private void frmRegistrarDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
