using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catiotro_s.CustomException.TelasException
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        //private void playSimpleSound()
        //{
        //    SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
        //    simpleSound.Play();
        //}

        public void LoadScreen(string msg)
        {
            txtMsg.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
