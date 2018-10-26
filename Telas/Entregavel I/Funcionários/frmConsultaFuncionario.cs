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
using Catiotro_s.Telas.Entregavel_I.Funcionários;
using Catiotro_s.classes.Classes.Feito.Funcionarios;
using Catiotro_s.CustomException.TelasException;

namespace Catiotro_s.Consultar
{
    public partial class frmConsultaFuncionario : UserControl
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioView> dto = buss.Listar();

            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = dto;
        }


        void CarregarGrid()
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            FuncionarioBusiness buss = new FuncionarioBusiness();
            List<FuncionarioView> dto = buss.Consultar(nome, cpf);

            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = dto;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            //Design das Linhas
            dgvFuncionario.BorderStyle = BorderStyle.None;
            dgvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 116, 186);
            dgvFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 81, 130);
            dgvFuncionario.RowsDefaultCellStyle.ForeColor = Color.White;

            //Design da seleção de células da GV e da GV "pelada"
            dgvFuncionario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFuncionario.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvFuncionario.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvFuncionario.BackgroundColor = Color.White;

            //Estilo da GV
            dgvFuncionario.EnableHeadersVisualStyles = false;
            dgvFuncionario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFuncionario.RowHeadersVisible = false;

            //Cabeça da GV
            dgvFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            dgvFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            //Fonte
            dgvFuncionario.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12);
            dgvFuncionario.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvFuncionario.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        FuncionarioView funcionario;

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                funcionario = dgvFuncionario.Rows[e.RowIndex].DataBoundItem as FuncionarioView;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionario == null)
                {
                    string msg = "Selecione um registro para Altera-lo.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
                else
                {
                    frmAlterarFuncionarios screen = new frmAlterarFuncionarios();
                    screen.LoadScreen(funcionario);
                    screen.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro: " + ex.Message;

                frmException tela = new frmException();
                tela.LoadScreen(msg);
                tela.ShowDialog();
            }
                    
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionario == null)
                {
                    string msg = "Selecione um registro para remove-lo.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
                else
                {
                    string msg = "Quer mesmo deletar o funcionário " + funcionario.Id + " do sistema?";

                    frmQuestion tela = new frmQuestion();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();

                    bool botaoYes = tela.BotaoYes;

                    if (botaoYes == true)
                    {
                        FuncionarioBusiness buss = new FuncionarioBusiness();
                        int Id = funcionario.Id;
                        buss.Remover(Id);

                        CarregarGrid();
                    }
                }
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
