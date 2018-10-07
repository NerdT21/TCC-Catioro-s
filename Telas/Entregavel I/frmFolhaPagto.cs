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
using Catiotro_s.PlugIn;

namespace Catiotro_s.Telas.Entregavel_I
{
    public partial class frmFolhaPagto : UserControl
    {
        public frmFolhaPagto()
        {
            InitializeComponent();
            CarregarCombos();
            GerarCredenciais();
        }

        void GerarCredenciais()
        {
            string nome = cboFuncionario.Text;
            FuncionarioDTO dto = cboFuncionario.SelectedItem as FuncionarioDTO;

            if (dto == null)
            {

            }
            else
            {
                mkbCPF.Text = dto.Cpf;
                txtSalario.Text = dto.Salario.ToString();
                txtDepto.Text = dto.IdDepto.ToString();
                //pbxImgFuncionario.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
            }


        }

        void CarregarCombos()
        {
            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = buss.Listar();

            cboFuncionario.ValueMember = nameof(FuncionarioDTO.Id);
            cboFuncionario.DisplayMember = nameof(FuncionarioDTO.Nome);
            cboFuncionario.DataSource = lista;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarCredenciais();
        }
    }
}
