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
    public partial class DisplayInfo : Form
    {
        public Informations inf = new Informations();
        public Operations opr = new Operations();
        admin ad;
        public DisplayInfo()
        {
            InitializeComponent();
        }

        public DisplayInfo(admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void DisplayInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.Display(inf);
            dgvdisplay.DataSource = dt;
            dgvdisplay.Columns[0].Visible = false;
            dgvdisplay.Columns[7].Visible = false;
            dgvdisplay.Columns[8].Visible = false;

        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbid.Text = dgvdisplay.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbname.Text = dgvdisplay.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbgender.Text = dgvdisplay.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdob.Text = dgvdisplay.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbaddress.Text = dgvdisplay.Rows[e.RowIndex].Cells[4].Value.ToString();

            tbgamil.Text = dgvdisplay.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            string s = tbsearch.Text;
            DataTable dt = new DataTable();
            try
            {
                if (s == "") { throw new Exception(); }
                dt = opr.searchlibrarian(inf, s);
                dgvdisplay.DataSource = dt;
                cmb.Text = null;
                tbid.Text = null;
                tbgender.Text = null;
                tbgamil.Text = null;
                tbdob.Text = null;
                tbaddress.Text = null;
                tbname.Text = null;
                lblsrch.Visible = false;


            }
            catch (Exception)
            {
                lblsrch.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s=cmb.Text;
            DataTable dt = new DataTable();
            dt = opr.filteremp(inf, s);
            dgvdisplay.DataSource = dt;
            lblsrch.Visible = false;
            //cmb.Text = null;
            tbid.Text = null;
            tbgender.Text = null;
            tbgamil.Text = null;
            tbdob.Text = null;
            tbaddress.Text = null;
            tbname.Text = null;
            tbsearch.Text = null;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id =tbid.Text;
            string name = tbname.Text;
            DataTable dt = new DataTable();
            lblsrch.Visible = false;
            try
            {
                if (id == "") { throw new Exception(); }
                if (name == "") { throw new Exception(); }
              DialogResult r=  MessageBox.Show("Are U sure to delete ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    dt = opr.deleteemp(id, name);
                    MessageBox.Show(name, "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    DataTable dtt = new DataTable();
                    dtt = opr.Display(inf);
                    dgvdisplay.DataSource = dtt;
                    dgvdisplay.Columns[0].Visible = false;
                    dgvdisplay.Columns[7].Visible = false;
                    dgvdisplay.Columns[8].Visible = false;
                    cmb.Text = null;
                    tbid.Text = null;
                    tbgender.Text = null;
                    tbgamil.Text = null;
                    tbdob.Text = null;
                    tbaddress.Text = null;
                    tbname.Text = null;
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You have to give librarian id nad name");
            }
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.Display(inf);
            dgvdisplay.DataSource = dt;
            dgvdisplay.Columns[0].Visible = false;
            dgvdisplay.Columns[7].Visible = false;
            dgvdisplay.Columns[8].Visible = false;
            lblsrch.Visible = false;
            cmb.Text = null;
            tbid.Text = null;
            tbgender.Text = null;
            tbgamil.Text = null;
            tbdob.Text = null;
            tbaddress.Text = null;
            tbname.Text = null;
            tbsearch.Text = null;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string gender = tbgender.Text;
            string dob = tbdob.Text;
            string address = tbaddress.Text;
            string gmail = tbgamil.Text;
            string v = "valid";
            lblsrch.Visible = false;
            try
            {
                if (id == "") { throw new Exception(); }
                if (name == "") { throw new Exception(); }
                if (gender== "") { throw new Exception(); }
                if (dob == "") { throw new Exception(); }
                if (address == "") { throw new Exception(); }
                if (gmail == "") { throw new Exception(); }

             DialogResult r=   MessageBox.Show("Are you sure to update?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    opr.updatestudent(name, gender, dob, address, gmail, id, v);
                    MessageBox.Show("Librarian Information Successfully Updated", "Confirmation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb.Text = null;
                    tbid.Text = null;
                    tbgender.Text = null;
                    tbgamil.Text = null;
                    tbdob.Text = null;
                    tbaddress.Text = null;
                    tbname.Text = null;
                    DataTable dt = new DataTable();
                    dt = opr.Display(inf);
                    dgvdisplay.DataSource = dt;
                    dgvdisplay.Columns[0].Visible = false;
                    dgvdisplay.Columns[7].Visible = false;
                    dgvdisplay.Columns[8].Visible = false;
                }
                else if (r == DialogResult.No) { this.Show(); }

            }
            catch(Exception)
            {
                MessageBox.Show("Some problems arise .. Solve First ", "Eorror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
