using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UpdateForm : Form
    {
       

        public UpdateForm(Books b)
        {
            InitializeComponent();
            
            
            txtBook.Text = b.Name;
        }
    }
}
