using sirema.model;
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
    using model;
    using System.Collections;

    public partial class LoginFrm : Form
    {
        LoginCls login = new LoginCls();
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void btnlogin_Click_1(object sender, EventArgs e)
        {


            if (login.apakahAda(txt.Text, txtpass.Text))
            {
                DashboardFrm dashboard = new DashboardFrm();
                dashboard.userlbl.Text = login.ambilnamaPengguna(txt.Text, txtpass.Text);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, User ID / Password anda salah",
                    "KESALAHAN", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                txt.SelectAll();
                txt.Focus();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpass.SelectAll();
                txtpass.Focus();
            }
        }

        private void txtpass_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnlogin.PerformClick();
            }
        }
        
    }
}
