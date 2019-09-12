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
using System.Data.SqlClient;

namespace Library
{
    public partial class admin : Form
    {
       
        
        public Operations opr = new Operations();
        private string id;
        DataTable dt = new DataTable();


        public admin()
        {
            InitializeComponent();
        }



            public admin(string id)
            {
                InitializeComponent();
                this.id = id;
            dt = opr.adminprofilefunc(id);
            dgtv.DataSource = dt;
            dgtv.Columns[0].Visible = false;
            dgtv.Columns[7].Visible = false;
            dgtv.Columns[8].Visible = false;

            }

            private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayInfo dis = new DisplayInfo(this);
           
            
            dis.Show();
        }

        private void librarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            RgLibadmin rg = new RgLibadmin(this);
           
            rg.Show();
            

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           displaybook dis = new displaybook(this);
            
            dis.Show();
            

        }
        

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BkRegAdmin b = new BkRegAdmin(this);
            b.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Logout  ??", "Enquery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login ln = new Login();
                ln.Show();
               
            }
            else if(result == DialogResult.No){ this.Show(); }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            regstdadmin st = new regstdadmin(this);
            st.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("DO You want Exit ??", "Enquery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if (result==DialogResult.No) {
                this.Show();

            }
            
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            disstdadmin dt = new disstdadmin(this);
           dt.Show();
        }

        private void dgtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void issueDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            issueshowadmin ie = new issueshowadmin(this);
            ie.Show();
        }

        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            promotion pr = new promotion(this);
            pr.Show();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void dgtv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dgtv.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = dgtv.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbpassword.Text =dgtv.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbgmail.Text = dgtv.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbgender.Text = dgtv.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdob.Text = dgtv.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbaddress.Text = dgtv.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                    dgtv.DataSource = dt;
                    dgtv.Columns[0].Visible = false;
                    dgtv.Columns[7].Visible = false;
                    dgtv.Columns[8].Visible = false;

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
    }
}
