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
    public partial class frmSite : Form
    {
        public frmSite()
        {
            InitializeComponent();
        }

        private bool mover;
        private int cX, cY;
        private void pnlTopo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - pnlTopo.Left);
                this.Top += e.Y - (cY - pnlTopo.Top);
            }
        }

        private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTopo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mover = false;
            }
        }
    }
}
