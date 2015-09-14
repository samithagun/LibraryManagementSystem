using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryBLL;
using LibraryBLL.Entities;

namespace Library_Management_System
{
    public partial class frmCategory : Form
    {
        LibraryFacade lf = new LibraryFacade();
        private bool result;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = new Category();

                cat.Description = txtCatDesc.Text;
                cat.AddedDate = DateTime.Now;
                cat.Inactive = chkInactive.Checked;

                result = lf.ManageCategory(cat);

                if (result)
                {
                    MessageBox.Show("Category Added Successfully","Information");
                }
            }
            catch (Exception ex)
            {               
                throw ex;
            }
        }

    }
}
