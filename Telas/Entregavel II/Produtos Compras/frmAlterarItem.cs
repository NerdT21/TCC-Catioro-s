using Catiotro_s.classes.Classes.Cliente;
using Catiotro_s.classes.Classes.Compras.Item;
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

namespace Catiotro_s.Telas.Entregavel_II.Produtos_Compras
{
    public partial class frmAlterarItem : Form
    {
        public frmAlterarItem()
        {
            InitializeComponent();
        }

        void CarregarCombos()
        {
            FornecedoresBusiness buss = new FornecedoresBusiness();
            List<FornecedoresDTO> lista = buss.ListarPraCombo();

            cboFornecedor.ValueMember = nameof(FornecedoresDTO.Id);
            cboFornecedor.DisplayMember = nameof(FornecedoresDTO.Nome);
            cboFornecedor.DataSource = lista;
        }

        ItemView item;
        public void LoadScreen(ItemView dto)
        {
            this.item = dto;
            txtNome.Text = dto.Nome;
            txtDescricao.Text = dto.Descricao;
            cboFornecedor.SelectedItem = dto.Fornecedor;
            nudPreco.Value = dto.Preco;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FornecedoresDTO fornecedor = cboFornecedor.SelectedItem as FornecedoresDTO;

            ItemDTO dto = new ItemDTO();
            dto.Id = this.item.Id;

            dto.Nome = txtNome.Text;
            dto.FornecedorId = fornecedor.Id;
            dto.Descricao = txtDescricao.Text;
            dto.Preco = Convert.ToDecimal(nudPreco.Value);

            ItemBusiness buss = new ItemBusiness();
            buss.Alterar(dto);

            string msg = "Item alterado com sucesso!";

            frmMessage tela = new frmMessage();
            tela.LoadScreen(msg);
            tela.ShowDialog();
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
