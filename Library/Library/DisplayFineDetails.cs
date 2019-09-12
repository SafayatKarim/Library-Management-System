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
    public partial class DisplayFineDetails : Form
    {
        Operations opr = new Operations();
        returnbook rb;
        public DisplayFineDetails()
        {
            InitializeComponent();
        }
        public DisplayFineDetails(string stdid ,string bkid,returnbook rb)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
           dt= opr.showstudentfine(stdid, bkid);
            dataGridView1.DataSource = dt;
            this.rb = rb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rb.Show();
        }
    }
}
