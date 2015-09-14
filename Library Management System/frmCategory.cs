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
        ILibraryManager library = new LibraryManager();
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
                if (string.IsNullOrEmpty(txtCatDesc.Text))
                {
                    MessageBox.Show("Description is required", "Validation");
                    return;
                }

                Category cat = new Category();

                cat.CategoryId = string.IsNullOrEmpty(txtCatId.Text) ? 0 : Convert.ToInt16(txtCatId.Text);
                cat.Description = txtCatDesc.Text;
                cat.AddedDate = DateTime.Now;
                cat.Inactive = chkInactive.Checked;

                //Calls the manager.
                result = library.SaveCategory(cat);

                if (result)
                {
                    MessageBox.Show("Category Saved Successfully", "Information");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCatId.Text = "";
            txtCatDesc.Text = "";
            chkInactive.Checked = false;

            txtCatId.Enabled = false;
            txtCatId.ReadOnly = true;
            btnSave.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtCatId.Enabled = true;
            txtCatId.ReadOnly = false;
            btnSave.Enabled = false;
            txtCatId.Focus();
        }

        private void txtCatId_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCatId.Text))
                {
                    Category cat = library.FindCategory(Convert.ToInt16(txtCatId.Text));

                    if (cat.CategoryId != 0)
                    {
                        txtCatDesc.Text = cat.Description;
                        chkInactive.Checked = cat.Inactive;

                        btnSave.Enabled = true;
                        txtCatId.Enabled = false;
                        txtCatId.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Category Code not found", "Information");
                        txtCatId.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
