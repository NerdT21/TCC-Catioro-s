using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Feito.Funcionarios;
using Catiotro_s.Consultar;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using Catiotro_s.PlugIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_I.Funcionários
{
    public partial class frmAlterarFuncionarios : Form
    {
        public frmAlterarFuncionarios()
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

        FuncionarioView dto;

        public void LoadScreen(FuncionarioView dto)
        {
            try
            {
                this.dto = dto;
                txtCidade.Text = dto.Cidade;
                txtEmail.Text = dto.Email;
                txtNome.Text = dto.Nome;
                nudSalario.Value = dto.Salario;
                mkbCEP.Text = dto.Cep;
                txtEndereco.Text = dto.Rua;
                txtNum.Text = dto.Numero.ToString();
                mkbCPF.Text = dto.Cpf;
                mkbRG.Text = dto.Rg;
                mkbTelefone.Text = dto.Telefone;
                cboDepto.SelectedItem = dto.Depto;
                cboUF.Text = dto.Estado;

                if (dto.Imagem == null)
                {
                    pbxFoto.Image = null;
                }
                else
                {
                    pbxFoto.Image = ImagemPlugIn.ConverterParaImagem(dto.Imagem);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DeptoDTO depto = cboDepto.SelectedItem as DeptoDTO;
                EstadoDTO estado = cboUF.SelectedItem as EstadoDTO;

                int funcio = this.dto.Id;

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = funcio;

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
                dto.Numero = Convert.ToInt32(txtNum.Text);
                dto.Imagem = ImagemPlugIn.ConverterParaString(pbxFoto.Image);

                FuncionarioBusiness buss = new FuncionarioBusiness();
                buss.Alterar(dto);

                string msg = "Funcionário alterado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();

                this.Close();
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

        private void pbxFoto_Click(object sender, EventArgs e)
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
    }
}
