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
    public partial class BkRegAdmin : Form
    {
        public Operations opr = new Operations();
        public Books b = new Books();
        admin ad;
        public BkRegAdmin()
        {
            InitializeComponent();
        }

        public BkRegAdmin(admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void bab_Click(object sender, EventArgs e)
        {
            b.Name = tbbn.Text;
            b.Title = tbbt.Text;
            b.Edition = tbe.Text;
            b.Author = tba.Text;
            b.Department = cmb2.Text;
            //b.Quantity = Convert.ToInt32(tbq.Text);


            try
            {
                if (tbbn.Text == "") { throw new Exception(); }// else { b.Name = tbbn.Text; }
                if (tbbt.Text == "") { throw new Exception(); }// else { b.Title = tbbn.Text; }
                if (tbe.Text == "") { throw new Exception(); } //else { b.Edition = tbe.Text; }
                if (tba.Text == "") { throw new Exception(); } //else { b.Author = tba.Text; }
                if (cmb2.Text == "") { throw new Exception(); } //else { b.Department = cmb2.Text; }
                if (tbq.Text =="") { throw new Exception(); }
                b.Quantity = Convert.ToInt32(tbq.Text);
                int row = opr.insertbook(b);
                if (row > 0) {

                    MessageBox.Show("Added Book Successfullt","Added !!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tbbn.Text = null;
                    tbbt.Text = null;
                    tbe.Text = null;
                    tba.Text = null;
                    cmb2.Text = null;
                    tbq.Text = null;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fills all the information","Warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            ad.Show();
        }

        private void tbdept_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
