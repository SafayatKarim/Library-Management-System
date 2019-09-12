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
    public partial class LibraryEmploye : Form
    {
        public Operations opr = new Operations();
        private string id;
        DataTable dt = new DataTable();
        

        public LibraryEmploye()
        {
            InitializeComponent();
        }

        public LibraryEmploye(string id)
        {
            InitializeComponent();

            this.id = id;
            dt = opr.adminprofilefunc(id);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
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

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            regstLibEmp rs = new regstLibEmp();
            
            rs.Show();
            
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            BkRegLibEmp b = new BkRegLibEmp(this);
            b.Show();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            disbooklib db = new disbooklib(this);
            db.Show();
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

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // disstdfrmLib dt = new disstdfrmLib (this);
            DisStdLibrarian dt = new DisStdLibrarian(this);
            dt.Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            issue b = new issue(this);
            b.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            issueshowlibemp s = new issueshowlibemp(this);
            s.Show();

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            returnbook rb = new returnbook(this);
            rb.Show();
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fineshow fns = new fineshow(this);
            // this.Hide();
            fns.Show();

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

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
          //  tbid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string address = textBox5.Text;
            string gmail = textBox6.Text;
            string password = textBox7.Text;

            try
            {
                if (textBox1.Text == "") { throw new Exception(); }
                if (textBox2.Text == "") { throw new Exception(); }
                if (textBox5.Text == "") { throw new Exception(); }
                if (textBox6.Text == "") { throw new Exception(); }
                if (textBox7.Text == "") { throw new Exception(); }
                //if (id == "") { throw new Exception(); }
               DialogResult r= MessageBox.Show("Update Your Profile??", name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    opr.updateprofilelib(name, address, gmail, password, id);
                    DataTable dt = new DataTable();
                    dt = opr.profilelib(id,name);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    textBox6.Text = null;
                    textBox7.Text = null;
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
    }
}
