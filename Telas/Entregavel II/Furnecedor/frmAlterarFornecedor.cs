using Catiotro_s.classes.Classes.Agenda;
using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Feito.Fornecedores;
using Catiotro_s.CustomException;
using Catiotro_s.CustomException.TelasException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.Telas.Entregavel_II.Furnecedor
{
    public partial class frmAlterarFornecedor : Form
    {
        public frmAlterarFornecedor()
        {
            InitializeComponent();
            CarregarCombos();
        }

        FornecedorView fornecedor;

        void CarregarCombos()
        {
            EstadoBusiness biss = new EstadoBusiness();
            List<EstadoDTO> lista = biss.Listar();

            cboEstado.ValueMember = nameof(EstadoDTO.Id);
            cboEstado.DisplayMember = nameof(EstadoDTO.Estado);
            cboEstado.DataSource = lista;
        }
        public void LoadScreen(FornecedorView view)
        {
            fornecedor = view;
            txtNome.Text = fornecedor.Nome;
            txtEmail.Text = fornecedor.Email;
            txtCnpj.Text = fornecedor.Telefone;
            txtCidade.Text = fornecedor.Cidade;
            mkbCep.Text = fornecedor.CEP;
            txtCnpj.Text = fornecedor.CNPJ;
            txtNumero.Text = fornecedor.Numero.ToString();
            txtTelefone.Text = fornecedor.Telefone;
            cboEstado.SelectedItem = fornecedor.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EstadoDTO estado = cboEstado.SelectedItem as EstadoDTO;

                FornecedoresDTO dto = new FornecedoresDTO();
                dto.Id = this.fornecedor.Id;
                
                dto.Nome = txtNome.Text;
                dto.Email = txtEmail.Text;
                dto.CNPJ = txtCnpj.Text;
                dto.Cidade = txtCidade.Text;
                dto.CEP = mkbCep.Text;
                dto.Telefone = txtTelefone.Text;
                dto.IdEstado = estado.Id;
                dto.Rua = txtRua.Text;
                dto.Numero = Convert.ToInt32(txtNumero.Text);

                FornecedoresBusiness business = new FornecedoresBusiness();
                business.Alterar(dto);

                string msg = "Fornecedor alterado com sucesso!";

                frmMessage tela = new frmMessage();
                tela.LoadScreen(msg);
                tela.ShowDialog();
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
