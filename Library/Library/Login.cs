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
    public partial class Login : Form
    {
        public Informations inf = new Informations();
        public Operations opr = new Operations();
        public DataTable dt = new DataTable();
        public string usertype;
        public Login()
        {
            InitializeComponent();
        }

        private void blgnl_Click(object sender, EventArgs e)
        {
            inf.Username = tbuname.Text;
            inf.Password = tbpass.Text;
            dt = opr.Login(inf);
            if (dt.Rows.Count > 0)
            {
                usertype = dt.Rows[0][8].ToString().Trim();
                string id = dt.Rows[0][0].ToString().Trim();
                string status= dt.Rows[0][9].ToString().Trim();
                if (usertype == "A" )

                {
                    
                    this.Hide();
                    admin AD = new admin(id);
                    
                    AD.Show();
              
                }
                else if (usertype=="L")
                {
                    this.Hide();
                    LibraryEmploye le = new LibraryEmploye(id);
                    le.Show();
                   
                }
                else if(usertype =="S")
                {   if (status == "valid")
                    {
                        this.Hide();
                        Std st = new Std(id);
                        st.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are Invalid : Please Wait For Confirmation");

                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid Password or Username","Stooped ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Regstlogin rf = new Regstlogin();
            this.Hide();
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO You want Exit ??", "Enquery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                this.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
