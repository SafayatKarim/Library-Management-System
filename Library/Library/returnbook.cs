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
    public partial class returnbook : Form
    {
        public Operations opr = new Operations();
        LibraryEmploye le = new LibraryEmploye();
       // Books bq = new Books();
        public returnbook()
        {
            InitializeComponent();
        }
        public returnbook(LibraryEmploye le)
        {
            InitializeComponent();
            this.le = le;
            DataTable dt = new DataTable();
            dt = opr.displayallissue();
            dtgvissue.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            string username = textBox2.Text;

            DataTable dt = new DataTable();
            try
            {
                if (bookname == "") { throw new Exception(); }
                if (username == "") { throw new Exception(); }
                dt = opr.srchforreturn(bookname,username);
                dtgvissue.DataSource = dt;
               

            }
            catch (Exception)
            {
                MessageBox.Show("You must have to full fill name and gmail  ", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void View_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
          dt=  opr.displayallissue();
            dtgvissue.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int rtrnbookquan;
            int tbqn;


            try
            {
                
                
                if (tbrbookqn.Text == "")
                {
                    throw new Exception();
                }
                 if (tbqunrb.Text == "") { throw new Exception(); }
                else if (tbbookid.Text == "") { throw new Exception(); }
                else if (tbbnrb.Text == "") { throw new Exception(); }
                else if (tbqunrb.Text == "") { throw new Exception(); }
                else if (tbbnissue.Text == "") { throw new Exception(); }
                else if (tbsidrb.Text == "") { throw new Exception(); }
                else if (stdnamerb.Text == "") { throw new Exception(); }
                else if (tbbbbb.Text == "") { throw new Exception(); }
                 else if (tbrbookqn.Text == "0") { throw new Exception(); }


                else
                {
                    rtrnbookquan = Convert.ToInt32(tbrbookqn.Text);
                    tbqn = Convert.ToInt32(tbqunrb.Text);
                }

                string isid = tbbbbb.Text;
                string bookid = tbbookid.Text;
                string studentid = tbsidrb.Text;
     
                int bookquan = tbqn - rtrnbookquan;

                string bookname = tbbnissue.Text;
                string studentname = stdnamerb.Text;
                DateTime returndate = tbreturn.Value.Date;
                DateTime today = tbtoday.Value.Date;
                TimeSpan sp =  today -returndate;
                int day = sp.Days;
                string booknumber = Convert.ToString(tbqn);

                if (day < 0)
                {

                    



                    if (bookquan >= 0)
                    {
                        DialogResult r = MessageBox.Show("Return Books??", "Return ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (r == DialogResult.Yes)
                        {
                            try
                            {

                                string q = rtrnbookquan.ToString();
                                int x = opr.getbookqn(bookid) + rtrnbookquan;

                                string passbookqn = Convert.ToString(x);
                                opr.updatebookquan(passbookqn, bookid);
                                if (bookquan > 0)
                                {
                                    opr.updatebookissuequan(bookquan.ToString(), isid);
                                }
                                else if (bookquan == 0)
                                {
                                    dt = opr.deletebookissuequan(studentid, bookid, isid);
                                }
                                MessageBox.Show("successfully");
                                DataTable dtttt = new DataTable();
                                dtttt = opr.displayallissue();
                                dtgvissue.DataSource = dtttt;
                            }
                            catch
                            {
                                MessageBox.Show("You Have internal Problem");
                            }


                        }
                        else if (r == DialogResult.No)
                        {
                            this.Show();
                        }
                    }
                    
                    else
                    {
                        MessageBox.Show("You Can't reeturn more than You issued books");
                    }
                }

               

                else
                    {
                    int totalissue = Convert.ToInt32(tbqunrb.Text);
                    int returnbook = Convert.ToInt32(tbrbookqn.Text);
                    int reminder = totalissue - returnbook;
                    int f = returnbook * day * 5;

                    string fn =Convert.ToString( f);
                   DialogResult r= MessageBox.Show("Fined", "Show Amount ??", MessageBoxButtons.YesNo);
                    //  MessageBox.Show()
                    if (r == DialogResult.Yes)
                    {
                        int x = opr.finedatabase(studentid, studentname, bookname, bookid, booknumber, fn);


                        DataTable dtd = new DataTable();

                        if (reminder == 0)
                        {
                            dtd = opr.deleteissuedetails(isid, bookid, studentid);
                            this.Hide();

                            DisplayFineDetails dfd = new DisplayFineDetails(studentid, bookid, this);
                            dfd.Show();

                            tbbbbb.Text = null;
                            tbbnissue.Text = null;
                            tbbookid.Text = null;
                            tbrbookqn.Text = null;
                            tbsidrb.Text = null;
                            tbqunrb.Text = null;
                            stdnamerb.Text = null;
                            tbreturn.Text = null;
                            tttttttttt.Text = null;


                        }
                        else if(reminder > 0){
                            // int bqn = Convert.ToInt32(tbbookqn.Text);
                           // string rm = Convert.ToString(reminder);
                            int upbookqn = opr.getbookqn(bookid) + returnbook;
                            string bookqn = Convert.ToString(upbookqn);

                            // string passbookqn = Convert.ToString(x);
                            string rmmmmm = Convert.ToString(reminder);
                            opr.updatebookquan(bookqn, bookid);
                            opr.fineupdate(isid,bookid,rmmmmm);


                            this.Hide();

                            DisplayFineDetails dfd = new DisplayFineDetails(studentid, bookid, this);
                            dfd.Show();

                            tbbbbb.Text = null;
                            tbbnissue.Text = null;
                            tbbookid.Text = null;
                            tbrbookqn.Text = null;
                            tbsidrb.Text = null;
                            tbqunrb.Text = null;
                            stdnamerb.Text = null;
                            tbreturn.Text = null;
                            tttttttttt.Text = null;


                        }

                        else if (reminder < 0)
                        {
                            MessageBox.Show("You can not return more then your  book issue", studentname);
                        }

                        //this.Hide();

                        //DisplayFineDetails dfd = new DisplayFineDetails(studentid, bookid,this);
                        //dfd.Show();

                        //tbbbbb.Text = null;
                        //tbbnissue.Text = null;
                        //tbbookid.Text = null;
                        //tbrbookqn.Text = null;
                        //tbsidrb.Text = null;
                        //tbqunrb.Text = null;
                        //stdnamerb.Text = null;
                        //tbreturn.Text = null;
                        //tttttttttt.Text = null;

                        
                    }
                    else if (r==DialogResult.No)
                    {
                        this.Show();
                    }



                }



                //else
                //{
                //    MessageBox.Show("You Can not return  this book ","Fined !!!",MessageBoxButtons.OK);
                //}


            }



            catch (Exception)
            {
                if (tbrbookqn.Text == "0")
                {
                    MessageBox.Show(tbrbookqn.Text, "Can not return book");
                }
                else
                {
                    MessageBox.Show("You must show all information");
                }
                }
             


            }

        string quantityzero;
        private void dtgvissue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            tbbbbb.Text = dtgvissue.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbbnissue.Text = dtgvissue.Rows[e.RowIndex].Cells[5].Value.ToString();
            stdnamerb.Text = dtgvissue.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbqunrb.Text = dtgvissue.Rows[e.RowIndex].Cells[7].Value.ToString();
            tttttttttt.Text = dtgvissue.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbbookid.Text = dtgvissue.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbsidrb.Text = dtgvissue.Rows[e.RowIndex].Cells[8].Value.ToString();
           quantityzero = dtgvissue.Rows[e.RowIndex].Cells[7].Value.ToString();
           tbreturn.Text= dtgvissue.Rows[e.RowIndex].Cells[10].Value.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            le.Show();

        }

        private void dtgvissue_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbbbbb.Text = dtgvissue.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbbnissue.Text = dtgvissue.Rows[e.RowIndex].Cells[5].Value.ToString();
            stdnamerb.Text = dtgvissue.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbqunrb.Text = dtgvissue.Rows[e.RowIndex].Cells[7].Value.ToString();
            tttttttttt.Text = dtgvissue.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbbookid.Text = dtgvissue.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbsidrb.Text = dtgvissue.Rows[e.RowIndex].Cells[8].Value.ToString();
            quantityzero = dtgvissue.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbreturn.Text = dtgvissue.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void returnbook_Load(object sender, EventArgs e)
        {

        }

       
    }
}
