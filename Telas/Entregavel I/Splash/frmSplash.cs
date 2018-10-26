using Catiotro_s.Telas.Entregavel_I.LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

            Task.Factory.StartNew(() =>
            {
                //Espara 5000 = 2 segundos 
                System.Threading.Thread.Sleep(5000);

                Invoke(new Action(() =>
                {
                    //Abre a Form de login
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();

                }));

            });


        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
