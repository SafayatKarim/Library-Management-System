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
    public partial class DisStdFrmAdmin : Form
    {
        public Informations inf = new Informations();
        public Operations opr = new Operations();
        admin ad;
        public DisStdFrmAdmin()
        {
            InitializeComponent();
        }
        public DisStdFrmAdmin(admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad.Show();
        }

        private void DisStdFrmAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.showstudent(inf);
            dgvstdfrmadmin.DataSource = dt;
            dgvstdfrmadmin.Columns[0].Visible = false;
            dgvstdfrmadmin.Columns[7].Visible = false;
            dgvstdfrmadmin.Columns[8].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = cmb.Text;
            DataTable dt = new DataTable();
            dt = opr.filterstudent( s);
            dgvstdfrmadmin.DataSource = dt;
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

        private void btnview_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.showstudent(inf);
            dgvstdfrmadmin.DataSource = dt;
            dgvstdfrmadmin.Columns[0].Visible = false;
            dgvstdfrmadmin.Columns[7].Visible = false;
            dgvstdfrmadmin.Columns[8].Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string s = tbdelete.Text;
            DataTable dt = new DataTable();
            dt = opr.deletestudent(s);
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            string s = tbsearch.Text;
            DataTable dt = new DataTable();
            dt = opr.searchstudent(s);
            dgvstdfrmadmin.DataSource = dt;
        }

        private void dgvstdfrmadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbgender.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdob.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbaddress.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[4].Value.ToString();
           
            tbgamil.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbvalid.Text = dgvstdfrmadmin.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbid.Text; 
            string name = tbname.Text;
            string gender = tbgender.Text; 
            string dob =tbdob.Text; 
            string address = tbaddress.Text; 
            string gmail = tbgamil.Text; 
            string validity = tbvalid.Text; 
            try
            {
                if (validity == "") { throw new Exception(); }
                if (gmail == "") { throw new Exception(); }
                if (address == "") { throw new Exception(); }
                if (dob == "") { throw new Exception(); }
                if (gender == "") { throw new Exception(); }
                if (name == "") { throw new Exception(); }
                if (id == "") { throw new Exception(); }
                opr.updatestudent(name, gender, dob, address, gmail, id,validity);
               MessageBox.Show("Student Information Successfully Updated", "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Some problems arise .. Solve First ", "Eorror", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

       
    }
}
