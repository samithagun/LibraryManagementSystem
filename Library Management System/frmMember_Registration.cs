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
    public partial class frmMember_Registration : Form
    {
        public frmMember_Registration()
        {
            InitializeComponent();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                panel1.Visible = true;
            else
                panel1.Visible = false;

            txtMemberID.Focus();
        }
    }
}
