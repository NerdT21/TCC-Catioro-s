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
using Catiotro_s.CustomException;

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
            try
            {
                //Vai intanciar o DTO e dps joga um valor nesse DTO
                classes.Classes.Cliente.DeptoDTO dto = new classes.Classes.Cliente.DeptoDTO();
                dto.Nome = txtDepto.Text;
                dto.Descricao = txtDecricao.Text;

                //Chama a função de salvar de business que em sua vez grava essas açoes no DTO 
                classes.Classes.Cliente.DeptoBusiness business = new classes.Classes.Cliente.DeptoBusiness();
                business.Salvar(dto);

                //Exibe de uma msg de suceso 
                MessageBox.Show("Departamento cadastrado.", "Catioro's", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                //Caso o try nn funcione o Catch roda e exibe uma msg de erro 
                MessageBox.Show("Ocorreu um Erro: " + ex.Message);
            }
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
            //Design das Linhas
            dgvDepto.BorderStyle = BorderStyle.None;
            dgvDepto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvDepto.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvDepto.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvDepto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDepto.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvDepto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDepto.BackgroundColor = Color.White;

            //Estilo da GV
            dgvDepto.EnableHeadersVisualStyles = false;
            dgvDepto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDepto.RowHeadersVisible = false;

            //Cabeça da GV
            dgvDepto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvDepto.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtDepto.Text;
                nome = nome.Trim();
                int qtdNome = nome.Count();

                if (qtdNome > 50)
                {
                    throw new ValidacaoException("O campo 'Nome do Departamento' não pode possuir mais de 50 caracteres.");
                }
                else if (qtdNome == 0)
                {
                    throw new ValidacaoException("O campo 'Nome do Departamento' não pode estar vazio.");
                }

                string desc = txtDecricao.Text;
                desc = desc.Trim();
                int qtdDesc = desc.Count();

                if (qtdDesc > 300)
                {
                    throw new ValidacaoException("O campo 'Descrição do Departamento' não pode possuir mais de 300 caracteres.");
                }
                else if (qtdDesc == 0)
                {
                    throw new ValidacaoException("O campo 'Descrição do Departamento' não pode estar vazio.");
                }

                Cadastro();
                CarregarGrid();
            }
            catch (ValidacaoException vex)
            {
                MessageBox.Show(vex.Message, "Catioro's Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvDepto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DeptoDTO dto = dgvDepto.Rows[e.RowIndex].DataBoundItem as DeptoDTO;

                DialogResult dialog = MessageBox.Show("Quer mesmo apagar o registro " + dto.Id + "??" + 
                    "\n\n" + "obs: Ao apagar um departamento, todos os funcionários nele vinculados serão deletados.",
                    "Catioro's", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    DeptoBusiness buss = new DeptoBusiness();

                    int IdDepto = dto.Id;
                    buss.Remover(IdDepto);

                    MessageBox.Show("Registo removido com sucesso!", "Catioro's", MessageBoxButtons.OK);
                    CarregarGrid();
                }
            }
        }
    }
}
