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
    public partial class BkRegLibEmp : Form
    {
        public Operations opr = new Operations();
        public Books b = new Books();
        LibraryEmploye le;
        public BkRegLibEmp()
        {
            InitializeComponent();
        }
        public BkRegLibEmp(LibraryEmploye l)
        {
            InitializeComponent();
            this.le = l;
        }

        private void bab_Click(object sender, EventArgs e)
        {

            try {
                if (tbbn.Text == ""){throw new Exception();}else { b.Name = tbbn.Text;}
                if (tbbt.Text=="") { throw new Exception(); } else{b.Title = tbbn.Text;}
                if (tbe.Text == "") { throw new Exception(); } else { b.Edition = tbe.Text; }
                if (tba.Text == "") { throw new Exception(); } else { b.Author = tba.Text; }
                if (comboBox1.Text == "") { throw new Exception(); } else { b.Department = comboBox1.Text; }
                b.Quantity = Convert.ToInt32(tbq.Text);
                int row = opr.insertbook(b);
                if (row > 0) {
                    MessageBox.Show("Added Book Successfully", "Added !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbbn.Text = null;
                    tbbt.Text = null;
                    tbe.Text = null;
                    tba.Text = null;
                    comboBox1.Text = null;
                    tbq.Text = null;
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Fills all the information", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  LibraryEmploye lbe = new LibraryEmploye();
            le.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
