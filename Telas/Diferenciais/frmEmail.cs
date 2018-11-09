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

namespace Catiotro_s.Telas.Diferenciais
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        EmailPlugin Email = new EmailPlugin();
  
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtPara.Text;
                email = email.Trim();

                Validacoes.ValidarEmail validEmail = new Validacoes.ValidarEmail();

                bool mail = validEmail.VerificarEmail(email);

                if (mail == false)
                {
                    throw new Exception();
                }

                string msg = txtMsg.Text;
                int qtdMsg = msg.Count();

                if (qtdMsg == 0)
                {
                    throw new Exception();
                }

                Email.Para = txtPara.Text;
                Email.Assunto = txtAssunto.Text;
                Email.Mensagem = txtMsg.Text;

                Email.Enviar();

                frmMessage tela = new frmMessage();
                tela.LoadScreen("E-mail enviado!");
                tela.ShowDialog();
            }
            catch (Exception)
            {
                frmAlert tela = new frmAlert();
                tela.LoadScreen("Não foi possível enviar o email. \nVerifique se o destinatário está correto.");
                tela.ShowDialog();
            }
            
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

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.FromArgb(0, 116, 186), Color.Transparent);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.FromArgb(0, 116, 186), Color.Transparent);
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog janela = new OpenFileDialog();
                janela.ShowDialog();

                txtAnexo.Text = janela.FileName;

                Email.AdicionarAnexo(janela.FileName);
            }
            catch (Exception)
            {
                frmAlert tela = new frmAlert();
                tela.LoadScreen("Não foi possível adicionar este anexo.");
                tela.ShowDialog();
            }
           
        }

        private bool mover;
        private int cX, cY;
        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void pnlTopo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mover = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTopo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlTopo.Left);
                this.Top += e.Y - (cY - pnlTopo.Top);
            }
        }
    }
}
