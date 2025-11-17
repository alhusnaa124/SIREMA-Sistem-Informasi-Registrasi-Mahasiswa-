using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace sirema.antarmuka
{
    public partial class SplashScreen : Form
    {   
        byte count = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                timer1.Enabled = false;
                LoginFrm login = new LoginFrm();
                login.Show();
                this.Hide();
            }
        }
    }
}
