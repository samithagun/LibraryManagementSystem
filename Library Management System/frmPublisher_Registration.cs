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
    public partial class frmPublisher_Registration : Form
    {
        public frmPublisher_Registration()
        {
            InitializeComponent();
        }

        private void btnViewPub_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                panel1.Visible = true;
            else
                panel1.Visible = false;
                txtPublisherID.Focus();
        }

        
    }
}
