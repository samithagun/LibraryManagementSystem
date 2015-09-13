namespace Library_Management_System
{
    partial class frmBook_Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook_Registration));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindCode = new System.Windows.Forms.TextBox();
            this.txtFindCat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindBookId = new System.Windows.Forms.TextBox();
            this.txtFindIsbn = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuther = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.lblPublisherDate = new System.Windows.Forms.Label();
            this.dtPubDate = new System.Windows.Forms.DateTimePicker();
            this.lblNoofPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.lblNoofCopies = new System.Windows.Forms.Label();
            this.txtTotCoppies = new System.Windows.Forms.TextBox();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.txtAvilable = new System.Windows.Forms.TextBox();
            this.lblISBNNO = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnViewCat = new System.Windows.Forms.Button();
            this.btnViewPub = new System.Windows.Forms.Button();
            this.btnViewBookID = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFindPub = new System.Windows.Forms.TextBox();
            this.txtfindPubId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFirstCopyID = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripButton3,
            this.tsbNew,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(400, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(51, 22);
            this.tsbNew.Text = "Clear";
            // 
            // tsbSave
            // 
            this.tsbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "Save";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton3.Text = "Edit";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton4.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(225, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.Width = 165;
            // 
            // txtFindCode
            // 
            this.txtFindCode.Location = new System.Drawing.Point(1, 3);
            this.txtFindCode.Name = "txtFindCode";
            this.txtFindCode.Size = new System.Drawing.Size(61, 18);
            this.txtFindCode.TabIndex = 1;
            // 
            // txtFindCat
            // 
            this.txtFindCat.Location = new System.Drawing.Point(63, 3);
            this.txtFindCat.Name = "txtFindCat";
            this.txtFindCat.Size = new System.Drawing.Size(164, 18);
            this.txtFindCat.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFindCat);
            this.panel1.Controls.Add(this.txtFindCode);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(122, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 246);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dataGridView3.Location = new System.Drawing.Point(0, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(230, 282);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ISBN";
            this.Column6.Name = "Column6";
            this.Column6.Width = 167;
            // 
            // txtFindBookId
            // 
            this.txtFindBookId.Location = new System.Drawing.Point(1, 1);
            this.txtFindBookId.Name = "txtFindBookId";
            this.txtFindBookId.Size = new System.Drawing.Size(60, 18);
            this.txtFindBookId.TabIndex = 1;
            // 
            // txtFindIsbn
            // 
            this.txtFindIsbn.Location = new System.Drawing.Point(63, 1);
            this.txtFindIsbn.Name = "txtFindIsbn";
            this.txtFindIsbn.Size = new System.Drawing.Size(165, 18);
            this.txtFindIsbn.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFindIsbn);
            this.panel3.Controls.Add(this.txtFindBookId);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Location = new System.Drawing.Point(121, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 305);
            this.panel3.TabIndex = 26;
            this.panel3.Visible = false;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(109, 18);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(132, 18);
            this.txtBookId.TabIndex = 0;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(8, 18);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(46, 13);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 208);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(10, 238);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(109, 205);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 18);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuther
            // 
            this.txtAuther.Location = new System.Drawing.Point(109, 235);
            this.txtAuther.Name = "txtAuther";
            this.txtAuther.Size = new System.Drawing.Size(132, 18);
            this.txtAuther.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(10, 267);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(109, 264);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(132, 18);
            this.txtPub.TabIndex = 7;
            // 
            // lblPublisherDate
            // 
            this.lblPublisherDate.AutoSize = true;
            this.lblPublisherDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherDate.Location = new System.Drawing.Point(10, 293);
            this.lblPublisherDate.Name = "lblPublisherDate";
            this.lblPublisherDate.Size = new System.Drawing.Size(79, 13);
            this.lblPublisherDate.TabIndex = 8;
            this.lblPublisherDate.Text = "Published Date";
            // 
            // dtPubDate
            // 
            this.dtPubDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPubDate.Location = new System.Drawing.Point(109, 293);
            this.dtPubDate.Name = "dtPubDate";
            this.dtPubDate.Size = new System.Drawing.Size(132, 18);
            this.dtPubDate.TabIndex = 9;
            // 
            // lblNoofPages
            // 
            this.lblNoofPages.AutoSize = true;
            this.lblNoofPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoofPages.Location = new System.Drawing.Point(10, 347);
            this.lblNoofPages.Name = "lblNoofPages";
            this.lblNoofPages.Size = new System.Drawing.Size(66, 13);
            this.lblNoofPages.TabIndex = 10;
            this.lblNoofPages.Text = "No of Pages";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(109, 347);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(132, 18);
            this.txtPages.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(10, 320);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(109, 320);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 18);
            this.txtPrice.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(10, 180);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category";
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(109, 178);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(132, 18);
            this.t.TabIndex = 15;
            // 
            // lblNoofCopies
            // 
            this.lblNoofCopies.AutoSize = true;
            this.lblNoofCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoofCopies.Location = new System.Drawing.Point(10, 81);
            this.lblNoofCopies.Name = "lblNoofCopies";
            this.lblNoofCopies.Size = new System.Drawing.Size(68, 13);
            this.lblNoofCopies.TabIndex = 16;
            this.lblNoofCopies.Text = "No of Copies";
            // 
            // txtTotCoppies
            // 
            this.txtTotCoppies.Location = new System.Drawing.Point(109, 76);
            this.txtTotCoppies.Name = "txtTotCoppies";
            this.txtTotCoppies.Size = new System.Drawing.Size(132, 18);
            this.txtTotCoppies.TabIndex = 17;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.AutoSize = true;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCopies.Location = new System.Drawing.Point(10, 370);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(85, 13);
            this.lblAvailableCopies.TabIndex = 18;
            this.lblAvailableCopies.Text = "Available Copies";
            // 
            // txtAvilable
            // 
            this.txtAvilable.Location = new System.Drawing.Point(109, 370);
            this.txtAvilable.Name = "txtAvilable";
            this.txtAvilable.Size = new System.Drawing.Size(132, 18);
            this.txtAvilable.TabIndex = 19;
            // 
            // lblISBNNO
            // 
            this.lblISBNNO.AutoSize = true;
            this.lblISBNNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNNO.Location = new System.Drawing.Point(10, 48);
            this.lblISBNNO.Name = "lblISBNNO";
            this.lblISBNNO.Size = new System.Drawing.Size(49, 13);
            this.lblISBNNO.TabIndex = 20;
            this.lblISBNNO.Text = "ISBN No";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(109, 48);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(132, 18);
            this.txtIsbn.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(263, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Refer Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnViewCat
            // 
            this.btnViewCat.Location = new System.Drawing.Point(94, 178);
            this.btnViewCat.Name = "btnViewCat";
            this.btnViewCat.Size = new System.Drawing.Size(15, 18);
            this.btnViewCat.TabIndex = 23;
            this.btnViewCat.UseVisualStyleBackColor = true;
            this.btnViewCat.Click += new System.EventHandler(this.btnViewCat_Click);
            // 
            // btnViewPub
            // 
            this.btnViewPub.Location = new System.Drawing.Point(94, 263);
            this.btnViewPub.Name = "btnViewPub";
            this.btnViewPub.Size = new System.Drawing.Size(15, 18);
            this.btnViewPub.TabIndex = 24;
            this.btnViewPub.UseVisualStyleBackColor = true;
            this.btnViewPub.Click += new System.EventHandler(this.btnViewPub_Click);
            // 
            // btnViewBookID
            // 
            this.btnViewBookID.Location = new System.Drawing.Point(94, 18);
            this.btnViewBookID.Name = "btnViewBookID";
            this.btnViewBookID.Size = new System.Drawing.Size(15, 18);
            this.btnViewBookID.TabIndex = 25;
            this.btnViewBookID.UseVisualStyleBackColor = true;
            this.btnViewBookID.Click += new System.EventHandler(this.btnViewBookID_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.txtFindPub);
            this.panel2.Controls.Add(this.txtfindPubId);
            this.panel2.Location = new System.Drawing.Point(111, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 142);
            this.panel2.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(0, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(224, 131);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Publisher";
            this.Column4.Name = "Column4";
            this.Column4.Width = 165;
            // 
            // txtFindPub
            // 
            this.txtFindPub.Location = new System.Drawing.Point(63, 3);
            this.txtFindPub.Name = "txtFindPub";
            this.txtFindPub.Size = new System.Drawing.Size(160, 18);
            this.txtFindPub.TabIndex = 2;
            // 
            // txtfindPubId
            // 
            this.txtfindPubId.Location = new System.Drawing.Point(2, 3);
            this.txtfindPubId.Name = "txtfindPubId";
            this.txtfindPubId.Size = new System.Drawing.Size(59, 18);
            this.txtfindPubId.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblFirstCopyID);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnViewBookID);
            this.groupBox1.Controls.Add(this.btnViewPub);
            this.groupBox1.Controls.Add(this.btnViewCat);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.lblISBNNO);
            this.groupBox1.Controls.Add(this.txtAvilable);
            this.groupBox1.Controls.Add(this.lblAvailableCopies);
            this.groupBox1.Controls.Add(this.txtTotCoppies);
            this.groupBox1.Controls.Add(this.lblNoofCopies);
            this.groupBox1.Controls.Add(this.t);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtPages);
            this.groupBox1.Controls.Add(this.lblNoofPages);
            this.groupBox1.Controls.Add(this.dtPubDate);
            this.groupBox1.Controls.Add(this.lblPublisherDate);
            this.groupBox1.Controls.Add(this.txtPub);
            this.groupBox1.Controls.Add(this.lblPublisher);
            this.groupBox1.Controls.Add(this.txtAuther);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblBookID);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 18);
            this.textBox1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Copy ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 18);
            this.textBox2.TabIndex = 30;
            // 
            // lblFirstCopyID
            // 
            this.lblFirstCopyID.AutoSize = true;
            this.lblFirstCopyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstCopyID.Location = new System.Drawing.Point(11, 117);
            this.lblFirstCopyID.Name = "lblFirstCopyID";
            this.lblFirstCopyID.Size = new System.Drawing.Size(67, 13);
            this.lblFirstCopyID.TabIndex = 27;
            this.lblFirstCopyID.Text = "First Copy ID";
            // 
            // frmBook_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 472);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBook_Registration";
            this.Text = "Book_Registration";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtFindCode;
        private System.Windows.Forms.TextBox txtFindCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtFindBookId;
        private System.Windows.Forms.TextBox txtFindIsbn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuther;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Label lblPublisherDate;
        private System.Windows.Forms.DateTimePicker dtPubDate;
        private System.Windows.Forms.Label lblNoofPages;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Label lblNoofCopies;
        private System.Windows.Forms.TextBox txtTotCoppies;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.TextBox txtAvilable;
        private System.Windows.Forms.Label lblISBNNO;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnViewCat;
        private System.Windows.Forms.Button btnViewPub;
        private System.Windows.Forms.Button btnViewBookID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtFindPub;
        private System.Windows.Forms.TextBox txtfindPubId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFirstCopyID;
    }
}