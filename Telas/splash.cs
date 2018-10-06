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
                    Login frm = new Login();
                    frm.Show();
                    Hide();

                }));

            });


        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
