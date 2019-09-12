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
    public partial class bookdisplaystd : Form
    {
        Std st;
        Operations opr = new Operations();
        Books b = new Books();


        public bookdisplaystd()
        {
            InitializeComponent();
        }

        public bookdisplaystd(Std st)
        {
            InitializeComponent();
            this.st = st;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            st.Show();

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

        private void bookdisplaystd_Load(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            dt = opr.displaybookfromf(b);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       public SqlDataAdapter sda;
        public SqlCommandBuilder sc;
         public DataTable dt= new DataTable();
        public DataSet ds = new DataSet();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter sda;
            sc = new SqlCommandBuilder(sda);

            try { sda.Update(ds); }
            catch
            {
                MessageBox.Show("Don't have permission");
            }
            
           
            //dt = opr.updatebook(b);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            DataTable dt = new DataTable();
            dt = opr.searchbook(b, s);
            dataGridView1.DataSource = dt;
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            DataTable dt = new DataTable();
            dt = opr.filterbook(s);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.displaybook(b);
            dataGridView1.DataSource = dt;
        }
    }
}
