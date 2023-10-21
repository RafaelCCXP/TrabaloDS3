using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsIII
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Stop();
            this.Close();
            Form1 outro = new Form1();
            outro.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
