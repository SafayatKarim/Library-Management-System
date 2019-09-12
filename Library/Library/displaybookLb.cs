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
    public partial class disbooklib : Form
    {
        public Books b = new Books();
        public Operations opr = new Operations();
        LibraryEmploye le;
        public disbooklib()
        {
            InitializeComponent();
        }

        public disbooklib(LibraryEmploye le)
        {
            InitializeComponent();
            this.le = le;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            le.Show();
           // this.Hide();
        }

        private void displaybookLb_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.displaybookfromf(b);
            disbooklibbb.DataSource = dt;
            disbooklibbb.Columns[0].Visible = false;
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
                    disbooklibbb.DataSource = dt;
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
                MessageBox.Show("Must Assign Book Name");
            }
            }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            DataTable dt = new DataTable();
            dt = opr.filterbook(s);
            disbooklibbb.DataSource = dt;
            //dt = opr.searchbook(b, s);
            //disbooklibbb.DataSource = dt;
            tbid.Text = null;
            tbname.Text = null;
            tbqun.Text = null;
            tbedition.Text = null;
            // tbedition.Text = null;
            //comboBox1.Text = null;
            tbdept.Text = null;
            tbauthor.Text = null;
            tbtile.Text = null;
            textBox1.Text = null;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            string name = tbname.Text;
            string id = tbid.Text;
            DataTable dtt = new DataTable();

            DialogResult r = MessageBox.Show(tbname.Text, "Are You Sure to delete this book??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
               // if (s == "") { throw new Exception(); }
                try
                {
                    if (name == "") { throw new Exception(); }
                    if (id == "") { throw new Exception(); }
                    DataTable dt = new DataTable();
                    dt = opr.deletebook(name,id);
                    MessageBox.Show(name,"Delete successfully");
                    dtt = opr.displaybook(b);
                    disbooklibbb.DataSource = dtt;
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
            disbooklibbb.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string edition = tbedition.Text;
            string author = tbauthor.Text;
            string dept = tbdept.Text;
            string title = tbtile.Text;
            string quantity = (tbqun.Text);
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

                    tbid.Text = null;
                    tbname.Text = null;
                    tbqun.Text = null;
                    tbedition.Text = null;
                    // tbedition.Text = null;
                    comboBox1.Text = null;
                    tbdept.Text = null;
                    tbauthor.Text = null;
                    tbtile.Text = null;

                    DataTable dt = new DataTable();
                    dt = opr.displaybook(b);
                    disbooklibbb.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some problems arise .. Solve First ", "Eorror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disbooklibbb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = disbooklibbb.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = disbooklibbb.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbedition.Text = disbooklibbb.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbauthor.Text = disbooklibbb.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtile.Text = disbooklibbb.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbqun.Text = disbooklibbb.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbdept.Text = disbooklibbb.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
