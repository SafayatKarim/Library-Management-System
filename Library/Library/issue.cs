using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Library
{
    public partial class issue : Form
    {
        public Operations opr = new Operations();
        LibraryEmploye le = new LibraryEmploye();
        

        public issue()
        {
            InitializeComponent();
            
            
        }

        public issue(LibraryEmploye e)
        {
            InitializeComponent();
            this.le = e;


        }


        private void issue_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = tbuname.Text;
           // string t = tbgmail.Text;

            DataTable dt = new DataTable();
            try
            {
                if (s == "") { throw new Exception(); }
              //  if (t == "") { throw new Exception(); }
                dt = opr.srchstdissue(s);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("fill name box ","Informtion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            tbsid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbstdname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbgender.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbstdgmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbstdaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbstdusername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

           // tbgamil.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void tbsb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbbid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbbookname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbbqun.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = tbsbissue.Text;
            DataTable dt = new DataTable();
            try
            {
                dt = opr.srchbookissue(s);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Exception Occured in search book issue ");
            }
           

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
            string stdname;
            string stdgmail;
            string stdusername;
            string stdadd;
            string bookname;
            string issuedate;
            string bookid;
            string stdid;
            string returndate;
           // int r =Convert.ToInt32(tbiquantity);
            try {
                int r = Convert.ToInt32(tbiquantity.Text);

                // string bid = tbbid.Text;
                if (tbstdname.Text == "") { throw new Exception(); } else { stdname = tbstdname.Text; }
                if (tbstdgmail.Text == "") { throw new Exception(); } else { stdgmail = tbstdgmail.Text; }
                if (tbstdusername.Text == "") { throw new Exception(); } else { stdusername = tbstdusername.Text; }
                if (tbstdaddress.Text == "") { throw new Exception(); } else { stdadd = tbstdaddress.Text; }
                if (tbbookname.Text == "") { throw new Exception(); } else { bookname = tbbookname.Text; }

                if (tbissuedate.Text == "") { throw new Exception(); } else { issuedate = tbissuedate.Text; }
                if (tbsid.Text == "") { throw new Exception(); } else { stdid = tbsid.Text; }
                if (tbbid.Text == "") { throw new Exception(); } else { bookid = tbbid.Text; }
                if (tbiquantity.Text == "") { throw new Exception(); }
                if (tbreturndate.Text == "") { throw new Exception(); } else { returndate = tbreturndate.Text; }

                //##########
                string bid = tbbid.Text;
            int bq = Convert.ToInt32(tbbqun.Text);
            int bookreminder = bq - r;
            string br = Convert.ToString(bookreminder);
                string bookquan = Convert.ToString(r);


                DialogResult resu= MessageBox.Show(bookname, "Sure To issue it", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resu == DialogResult.Yes)
                {
                    if (bookreminder >= 0)
                    {
                        opr.insertissuedetails(stdname, stdgmail, stdusername, stdadd, bookname, bookquan, issuedate, stdid, bookid,returndate);
                        opr.updatebookissue(bid, br);
                        MessageBox.Show("Issued Book Successfully");
                        DataTable dt = new DataTable();

                        dt = opr.displaybook(b);
                        dataGridView2.DataSource = dt;
                        dataGridView2.Columns[0].Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Insuficient Book");
                    }
                }
                else { this.Show(); }
            }
            catch(Exception )
            {
                MessageBox.Show("Query problem or any of informations miissed","Can't Issue",MessageBoxButtons.OK,MessageBoxIcon.Error);

             //   if (tbiquantity.Text == "") { }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            le.Show();
        }
        Books b = new Books();
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = opr.displaybook(b);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
        }

        Informations inf = new Informations();
        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.showstudent(inf);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbsid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbstdname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbgender.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbstdgmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbstdaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbstdusername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbbid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbbookname.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbbqun.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sb = textBox1.Text;
            DataTable dt = new DataTable();
            try
            {
                if (sb == "") { throw new Exception(); }
                //  if (t == "") { throw new Exception(); }
                dt = opr.searchbookforissue(sb);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
                //dataGridView1.Columns[8].Visible = false;

               

            }
            catch (Exception)
            {
                MessageBox.Show("fill name box ", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tbuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
