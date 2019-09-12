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
    public partial class Studentfine : Form
    {
        Std s;
        string idd;
        Operations opr = new Operations();
        public Studentfine()
        {
            InitializeComponent();
        }



        public Studentfine(Std st,string id)
        {
            InitializeComponent();
            this.s = st;
            this.idd = id;
            DataTable dt = new DataTable();
            dt = opr.stdfine(idd);
            dataGridView1.DataSource = dt;


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            s.Show();
        }
    }
}
