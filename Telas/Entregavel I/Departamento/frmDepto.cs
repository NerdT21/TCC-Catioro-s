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
using Catiotro_s.CustomException.TelasException;

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
                string msg = "Departamento cadastrado.";

                frmMessage tela = new frmMessage();
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

            //Fonte
            dgvDepto.RowHeadersDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvDepto.RowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
            dgvDepto.AlternatingRowsDefaultCellStyle.Font = new Font("SegoeUI", 10);
        }

        private void dgvDepto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    DeptoDTO dto = dgvDepto.Rows[e.RowIndex].DataBoundItem as DeptoDTO;

                    string msg = "Quer mesmo apagar o registro " + dto.Id + "?" +
                        "\n" + "obs: Ao apagar um departamento, todos os funcionários nele vinculados serão deletados.";

                    frmQuestion tela = new frmQuestion();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();

                    bool botaoYes = tela.BotaoYes;

                    if (botaoYes == true)
                    {
                        DeptoBusiness buss = new DeptoBusiness();

                        int IdDepto = dto.Id;
                        buss.Remover(IdDepto);

                        string msgm = "Registo removido com sucesso!";

                        frmMessage message = new frmMessage();
                        message.LoadScreen(msgm);
                        message.ShowDialog();

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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cadastro();
                CarregarGrid();
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.FromArgb(0, 116, 186), Color.FromArgb(0, 116, 186), Color.Transparent);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor, Color backgroundColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Coloque a cor do background aqui
                // g.Clear(backgroundColor);

                //Draw text
                //g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.FromArgb(0, 116, 186), Color.Transparent);
        }
    }
}
