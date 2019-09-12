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
    public partial class Regstlogin : Form
    {
        Informations inf = new Informations();
        Operations opr = new Operations();
         string gender,pass,retype;
        public Regstlogin()
        {
            InitializeComponent();
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            if (tbemail.Text.Contains("@") && tbemail.Text.Contains(".com"))
            {
                if (char.IsUpper(tbname.Text[0]))
            {
                try
                {
                    if (tbname.Text == " ") { throw new Exception(); } else { inf.Name = tbname.Text; };
                    if (rbmale.Checked == false && rbfemale.Checked == false) { throw new Exception(); }
                    else
                    {
                        if (rbmale.Checked == true)
                        {
                            gender = "Male";
                        }
                        if (rbfemale.Checked == true)
                        {
                            gender = "Female";
                        }
                        inf.Gender = gender;
                    }
                    inf.Dob = Convert.ToString(dtp.Value.ToShortDateString());

                    if (tbadd.Text == "") { throw new Exception(); } else { inf.Address = tbadd.Text; }
                    if (tbuser.Text == "") { throw new Exception(); } else { inf.Username = tbuser.Text; }
                    if (tbemail.Text == "") { throw new Exception(); } else { inf.Email = tbemail.Text; }
                    if (tbpassword.Text == "") { throw new Exception(); } else { inf.Password = tbpassword.Text; }
                    if (tbretype.Text == "") { throw new Exception(); }
                    this.pass = tbpassword.Text;
                    this.retype = tbretype.Text;
                    if (pass == retype)
                    {
                        lblpasscon.ForeColor = Color.Green;
                        lblpasscon.Text = "Matched";
                    }
                    else
                    {
                        lblpasscon.ForeColor = Color.Red;
                        lblpasscon.Text = "Don't Matched";
                    }
                    if (this.pass.ToString() == this.retype.ToString())
                    {
                        int row = opr.insertstudentlogin(inf);
                        if (row > 0)
                        {
                            MessageBox.Show("Registration Successfully", "Congratz !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            tbadd.Text = null;
                            tbemail.Text = null;
                            tbname.Text = null;
                            tbpassword.Text = null;
                            rbfemale.Text = null;
                            rbmale.Text = null;
                            tbretype.Text = null;
                            tbuser.Text = null;


                        }
                        else { MessageBox.Show("Error ", "Retry !! ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Passwords don't matched  !!!", "Retry !! ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception) { MessageBox.Show("Do Fills All Requirements ", "Notification !! ", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        else
            {
                MessageBox.Show("Name Must be Capital");
            }
       }
    else{
                MessageBox.Show("Email should be aa@aa.com");
        }
        }


            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
