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
using Catiotro_s.PlugIn;
using MySql.Data.MySqlClient;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.CustomException;

namespace Catiotro_s.Telas.Entregavel_I.Funcionários
{
    public partial class frmCadastrarFuncionario : UserControl
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            EstadoBusiness buss = new EstadoBusiness();
            List<EstadoDTO> lista = buss.Listar();

            cboUF.ValueMember = nameof(EstadoDTO.Id);
            cboUF.DisplayMember = nameof(EstadoDTO.Estado);
            cboUF.DataSource = lista;

            DeptoBusiness business = new DeptoBusiness();
            List<DeptoDTO> list = business.Listar();

            cboDepto.ValueMember = nameof(DeptoDTO.Id);
            cboDepto.DisplayMember = nameof(DeptoDTO.Nome);
            cboDepto.DataSource = list;
        }

        private void frmCadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mkbCEP_KeyUp(object sender, KeyEventArgs e)
        {       
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(mkbCEP.Text);

                    txtEndereco.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboUF.Text = resposta.uf;

                }
                catch (Exception cex)
                {
                    string msg = "Não foi possível encontrar o CEP";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
        }

        private void frmCadastrarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        } 

        private void mkbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DeptoDTO depto = cboDepto.SelectedItem as DeptoDTO;
                EstadoDTO estado = cboUF.SelectedItem as EstadoDTO;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Nome = txtNome.Text;
                dto.Rg = mkbRG.Text;
                dto.Salario = nudSalario.Value;
                dto.Cpf = mkbCPF.Text;
                dto.Telefone = mkbTelefone.Text;
                dto.Email = txtEmail.Text;
                dto.IdDepto = depto.Id;
                dto.Cidade = txtCidade.Text;
                dto.IdEstado = estado.Id;
                dto.Cep = mkbCEP.Text;
                dto.Rua = txtEndereco.Text;

                if (txtNum.Text == string.Empty)
                {
                    dto.Numero = 0;
                }
                else
                {
                    dto.Numero = Convert.ToInt32(txtNum.Text);
                }

                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxFoto.Image);

                FuncionarioBusiness buss = new FuncionarioBusiness();
                buss.Salvar(dto);

                frmMessage tela = new frmMessage();
                tela.LoadScreen("Funcionário cadastrado com sucesso!");
                tela.ShowDialog();
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1062)
                {
                    string msg = "Funcionario já está cadastrado. Verifique se o CPF está corretamente preenchido ou se ele já esta no sistema.";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
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

        private void pbxFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxFoto.ImageLocation = dialog.FileName;
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.FromArgb(0, 116, 186), Color.Transparent);

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

                // Draw text
                // g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

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

        private void mkbCEP_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    var ws = new WSCorreios.AtendeClienteClient();
                    var resposta = ws.consultaCEP(mkbCEP.Text);

                    txtEndereco.Text = resposta.end;
                    txtCidade.Text = resposta.cidade;
                    cboUF.Text = resposta.uf;

                }
                catch (Exception cex)
                {
                    string msg = "Não foi possível encontrar o CEP";

                    frmAlert tela = new frmAlert();
                    tela.LoadScreen(msg);
                    tela.ShowDialog();
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsWhiteSpace(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
