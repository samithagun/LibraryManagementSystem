using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmBook_Registration : Form
    {
        public frmBook_Registration()
        {
            InitializeComponent();
        }
      
       
        private void btnViewBookID_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
                panel3.Visible = true;
            else
                panel3.Visible = false;

            txtFindBookId.Focus();
        }

        private void btnViewPub_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
                panel2.Visible = true;
            else
                panel2.Visible = false;

            txtfindPubId.Focus();

        }

        private void btnViewCat_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                panel1.Visible = true;
            else
                panel1.Visible = false;

            txtFindCode.Focus();
        }

       


    }
}
