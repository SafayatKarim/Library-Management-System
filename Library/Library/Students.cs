using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL;
using BEL;

namespace Library
{
    public partial class Std : Form
    {
        public Operations opr = new Operations();
        private string id;
        DataTable dt = new DataTable();
       // string status="invalid";
        string studentid;
        // string welcomename;
        string stiddd;

        public Std()
        {
            InitializeComponent();
           // lblwelcome.Visible = true;
        }

        public Std(string ad)
        {
            InitializeComponent();
            this.id = ad;
            dt = opr.adminprofilefunc(id);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
           // lblwelcome.Text = welcomename;
           // lblwelcome.Visible = true;
            //status = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Logout  ??", "Enquery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login ln = new Login();
                ln.Show();

            }
            else if (result == DialogResult.No) { this.Show(); }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookdisplaystd st = new bookdisplaystd(this);
            st.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbpassword.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbgmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbgender.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdob.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           // status = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            studentid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           // welcomename = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string address = tbaddress.Text;
            string gmail = tbgmail.Text;
            string password = tbpassword.Text;

            try
            {
                if (tbid.Text == "") { throw new Exception(); }
                if (tbname.Text == "") { throw new Exception(); }
                if (tbaddress.Text == "") { throw new Exception(); }
                if (tbgmail.Text == "") { throw new Exception(); }
                if (tbpassword.Text == "") { throw new Exception(); }
                //if (id == "") { throw new Exception(); }
                DialogResult r = MessageBox.Show("Update Your Profile??", name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    opr.updateprofilelib(name, address, gmail, password, id);
                    DataTable dt = new DataTable();
                    dt = opr.profilelib(id, name);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;

                    tbaddress.Text = null;
                    tbdob.Text = null;
                    tbgender.Text = null;
                    tbdob.Text = null;
                    tbid.Text = null;
                    tbpassword.Text = null;
                    tbname.Text = null;
                    tbgmail.Text = null;

                }
                else if (r == DialogResult.No)
                {
                    this.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fulfill all information", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            DialogResult result = MessageBox.Show("Are You Sure To Logout  ??", "Enquery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login ln = new Login();
                ln.Show();

            }
            else if (result == DialogResult.No) { this.Show(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         DialogResult r=   MessageBox.Show("Deactive your account??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (tbid.Text == "") { MessageBox.Show("You must be assign your id number", "You Id??", MessageBoxButtons.OK); }
                else
                {
                    string status = "invalid";
                    opr.deactivestudent(status, studentid);
                    MessageBox.Show("Can't login again", "Deactivated Successfully ");
                    this.Hide();
                    Login lg = new Login();
                    lg.Show();
                }
            }
            else if (r == DialogResult.No)
            {
                this.Show();
            }
        }

        private void Std_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            stiddd = tbid.Text;

            if (tbid.Text == "")
            {
                MessageBox.Show("You must Enter you ID", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Studentfine st = new Studentfine(this, stiddd);
                st.Show();
            }
        }
    }
}
