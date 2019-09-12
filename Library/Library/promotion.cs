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
    public partial class promotion : Form
    {
        Operations opr = new Operations();
        Informations inf = new Informations();
        admin ad = new admin();
        public promotion()
        {
            InitializeComponent();
        }

        public promotion(admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = opr.showstudent(inf);
            dgview.DataSource = dt;
            dgview.Columns[0].Visible = false;
            dgview.Columns[7].Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad.Show();
        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dgview.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dgview.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dgview.Rows[e.RowIndex].Cells[8].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
            string id;
            string pos;

            try
            {
               
                if (textBox1.Text == "") { throw new Exception(); } else { id = textBox1.Text; }
                if (comboBox1.Text == "") { throw new Exception(); } else { pos = comboBox1.Text; }
                DialogResult r = MessageBox.Show("Are You sure to promote him to Employee ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    opr.promotestudent(id, pos);
                    MessageBox.Show("Successfully Promoted ");
                }
                else if (r == DialogResult.No) { this.Show(); }
            }

            catch (Exception)
            {
                MessageBox.Show("Please Provide Full Information ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

         }

        private void button4_Click(object sender, EventArgs e)
        {
            string s;
            DataTable dt = new DataTable();

            try
            {
                if (textBox4.Text == "") { throw new Exception(); } else { s = textBox4.Text; }
                

                dt = opr.searchstudent(s);
                dgview.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("You Must provide user Name","Direction",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }

        private void button5_Click(object sender, EventArgs e)
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

