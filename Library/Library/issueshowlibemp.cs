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
    public partial class issueshowlibemp : Form
    {
        Operations opr = new Operations();
        LibraryEmploye le = new LibraryEmploye();
        public issueshowlibemp()
        {
            InitializeComponent();
        }
        public issueshowlibemp(LibraryEmploye e)
        {
            InitializeComponent();
            this.le = e;
        }

        private void issueshowlibemp_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = opr.displayallissue();
            dgvissueemp.DataSource = dt;
           dgvissueemp.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            le.Show();
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
    }
}
