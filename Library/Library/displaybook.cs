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
using BEL;

namespace Library
{
    public partial class displaybook : Form
    {
        public Books b = new Books();
        public Operations opr = new Operations();
        admin ad;
        public displaybook()
        {
            InitializeComponent();
        }

        public displaybook(admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }


        private void displaybook_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.displaybookfromf(b);
            bookadmin.DataSource = dt;
            bookadmin.Columns[0].Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad.Show();
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            DataTable dt = new DataTable();
            try
            {
                if (s == "") { throw new Exception(); }

                else
                {
                    dt = opr.searchbook(b, s);
                    bookadmin.DataSource = dt;

                    tbid.Text = null;
                    tbname.Text = null;
                    tbqun.Text = null;
                    tbedition.Text = null;
                    // tbedition.Text = null;
                    comboBox1.Text = null;
                    tbdept.Text = null;
                    tbauthor.Text = null;
                    tbtile.Text = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must assigne Book Name");
            }


        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
           string s = comboBox1.Text;
            DataTable dt = new DataTable();
            try
            {
                if (s == "") { throw new Exception(); }
                else
                {
                    dt = opr.filterbook(s);
                    bookadmin.DataSource = dt;

                    tbid.Text = null;
                    tbname.Text = null;
                    tbqun.Text = null;
                    tbedition.Text = null;
                    // tbedition.Text = null;
                   // comboBox1.Text = null;
                    tbdept.Text = null;
                    tbauthor.Text = null;
                    tbtile.Text = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You have to Assign Book Department Name");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string id = tbid.Text;

            DataTable dttt = new DataTable();
            //dt = opr.displaybook(b);
            //disbooklibbb.DataSource = dt;

            DialogResult r = MessageBox.Show(tbname.Text,"Are You Sure to delete this book??",  MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
              //  if (s == "") { throw new Exception(); }
                try
                {
                    if (name == "") { throw new Exception(); }
                    if (id == "") { throw new Exception(); }
                    DataTable dt = new DataTable();
                    dt = opr.deletebook(name,id);
                    //dttt = opr.displaybook(b);
                    //bookadmin.DataSource = dttt;
                    MessageBox.Show(name, "Delete successfully");

                    tbid.Text = null;
                    tbname.Text = null;
                    tbqun.Text = null;
                    tbedition.Text = null;
                    // tbedition.Text = null;
                    comboBox1.Text = null;
                    tbdept.Text = null;
                    tbauthor.Text = null;
                    tbtile.Text = null;
                    textBox1.Text = null;
                    
                
                    dttt = opr.displaybook(b);
                    bookadmin.DataSource = dttt;
                }

                //dt = opr.deletebook(s);


                catch (Exception)
                {
                    MessageBox.Show("Please Click On  Name from Data Table");
                }
            }

            else if (r == DialogResult.No)
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.displaybook(b);
            bookadmin.DataSource = dt;
            tbid.Text = null;
            tbname.Text = null;
            tbqun.Text = null;
            tbedition.Text = null;
            // tbedition.Text = null;
             comboBox1.Text = null;
            tbdept.Text = null;
            tbauthor.Text = null;
            tbtile.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string edition = tbedition.Text;
            string author = tbauthor.Text;
            string dept = tbdept.Text;
            string title = tbtile.Text;
            string quantity = ( tbqun.Text);
            try
            {
                if (id == "") { throw new Exception(); }
                else if (name == "") { throw new Exception(); }
                else if (edition == "") { throw new Exception(); }
                else if (author == "") { throw new Exception(); }
                else if (dept == "") { throw new Exception(); }
                else if (title == "") { throw new Exception(); }
                else if (quantity == "") { throw new Exception(); }
                else
                {
                    opr.updatebookadmin(name, edition, author, dept, title, quantity, id);
                    MessageBox.Show("Book Successfully Updated", "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();
                    dt = opr.displaybook(b);
                    bookadmin.DataSource = dt;
                    tbid.Text = null;
                    tbname.Text = null;
                    tbqun.Text = null;
                    tbedition.Text = null;
                    // tbedition.Text = null;
                     comboBox1.Text = null;
                    tbdept.Text = null;
                    tbauthor.Text = null;
                    tbtile.Text = null;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Must Assign All of book info ", "Eorror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void bookadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = bookadmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = bookadmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbedition.Text = bookadmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbauthor.Text = bookadmin.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtile.Text = bookadmin.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbqun.Text = bookadmin.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbdept.Text = bookadmin.Rows[e.RowIndex].Cells[6].Value.ToString();
            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = bookadmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = bookadmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbedition.Text = bookadmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbauthor.Text = bookadmin.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtile.Text = bookadmin.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbqun.Text = bookadmin.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbdept.Text = bookadmin.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        //private void searchbook(Books b, string s)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
