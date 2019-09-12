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
    
    public partial class fineshow : Form
    {
        LibraryEmploye le;
        Operations opr = new Operations();
        public fineshow()
        {
            InitializeComponent();
        }

        public fineshow(LibraryEmploye le)
        {
            InitializeComponent();
            this.le = le;
            DataTable dt = new DataTable();
            dt = opr.finedetails();
            showfine.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            le.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.finedetails();
            showfine.DataSource = dt;
        }

        private void showfine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           tbfid.Text = showfine.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbstdid.Text = showfine.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbstdname.Text = showfine.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbbid.Text = showfine.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbbookname.Text = showfine.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbbookqn.Text = showfine.Rows[e.RowIndex].Cells[5].Value.ToString();
           tbfine.Text = showfine.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookid;
            string fine;
            string bookname;
            string bookqun;
            string studentname;
           


            try {

                if (tbbid.Text == "") { throw new Exception(); }  else { bookid = tbbid.Text; }
                if (tbfid.Text == "") { throw new Exception(); } else { fine = tbfid.Text; }
                if (tbbookname.Text == "") { throw new Exception(); } else {bookname = tbbookname.Text; }
                if (tbbookqn.Text == "") { throw new Exception(); } else { bookqun = tbbookname.Text; }
                if ( rbyes.Checked==false && rbno.Checked==false ) { throw new Exception(); }
                else
                {
                    if (rbyes.Checked == true)
                    {
                        int bqn = Convert.ToInt32(tbbookqn.Text);
                        int x = opr.getbookqn(bookid) + bqn;
                        string passbookqn = Convert.ToString(x);
                        opr.updatebookquan(passbookqn, bookid);

                        DataTable dt = new DataTable();
                        dt = opr.deletefinedetails(fine, bookid);

                        dt = opr.finedetails();
                        showfine.DataSource = dt;

                        tbbookqn.Text = null;
                        tbfid.Text = null;
                        //tbfid.Text = null;
                        tbbookname.Text = null;
                        rbno.Checked = false;
                        rbyes.Checked = false;
                        tbbid.Text = null;
                        tbstdid.Text = null;
                        tbstdname.Text = null;
                        tbbookqn.Text = null;
                        tbfine.Text = null;

                        MessageBox.Show("Your Payment is succesfull");


                    }
                    else if (rbno.Checked == true)
                    {
                        studentname = tbstdname.Text;
                        MessageBox.Show("Pay First ",studentname);
                    }
                }

            }



            catch (Exception){
               

                MessageBox.Show("Full Fill all the information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
