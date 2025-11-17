using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirema.antarmuka
{
    public partial class DashboardFrm : Form
    {
        int geser = 0;
        public DashboardFrm()
        {
            InitializeComponent();
            
        }

        private void DashboardFrm_Load(object sender, EventArgs e)
        {
            tgllbl.Text=DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geser += 5;
            if(geser >= 900)
            {
                geser = -400;
            }
            label1.Left = geser;
        }

        private void jurusanbtn_Click(object sender, EventArgs e)
        {
            Form1 jurusan = new Form1();
            jurusan.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(jurusan);
            jurusan.Show();
            jurusan.FormBorderStyle = FormBorderStyle.None;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            jamlbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prodibtn_Click(object sender, EventArgs e)
        {
            Prodi prodi = new Prodi();
            prodi.TopLevel = false;
            panel3.Controls.Clear();
           // panel3.Controls.Add(prodi);
            prodi.Show();
            prodi.FormBorderStyle = FormBorderStyle.None;
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
