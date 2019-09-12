using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BL;

namespace Library
{
    public partial class ForgetPassword : Form
    {
        Operations opr = new Operations();
        public ForgetPassword()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string pos = cmb2.Text;
            string un = textBox2.Text;
            string gm = textBox3.Text;
            DataTable dt = new DataTable();
            try
            {
                dt = opr.forgetpass(pos, un, gm);
                dgvforget.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("No Account");
            }
           // opr.forgetpass(sn, un, gm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pos = cmb2.Text;
            string un = textBox2.Text;
            string gm = textBox3.Text;
            string nwpass = textBox4.Text;
            if (textBox4.Text == textBox1.Text)
            { 
                try
                {
                    if (pos == "") { throw new Exception(); }
                    if (un == "") { throw new Exception(); }
                    if (gm == "") { throw new Exception(); }
                    if (nwpass == "") { throw new Exception(); }
                    opr.changedpassword(pos, un, gm, nwpass);
                    MessageBox.Show("Your Password Successfully Changed", "Changed Paasword", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch(Exception)
                {
                    MessageBox.Show("Arise internal problem or must fullfill information ");

                }
            }
            else { MessageBox.Show("Don't matched password... Rechecked"); }

        }

        private void dgvforget_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvforget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
