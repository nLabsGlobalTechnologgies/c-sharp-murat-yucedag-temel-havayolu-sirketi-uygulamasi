using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txUserName.Text == "12345678912" && txPassword.Text == "admin")
            {
                frm3 frm = new frm3();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            txUserName.Focus();
            txUserName.Text = "12345678912";
            txPassword.Text = "admin";
        }
    }
}
