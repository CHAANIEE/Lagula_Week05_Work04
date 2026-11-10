namespace CommonControls
{
    partial class frmProduct
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaategory = new System.Windows.Forms.Label();
            this.lblOrigins = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.grpOrigins = new System.Windows.Forms.GroupBox();
            this.rdoAbroad = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.grpOrigins.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(35, 30);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(35, 104);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCaategory
            // 
            this.lblCaategory.AutoSize = true;
            this.lblCaategory.Location = new System.Drawing.Point(35, 205);
            this.lblCaategory.Name = "lblCaategory";
            this.lblCaategory.Size = new System.Drawing.Size(49, 13);
            this.lblCaategory.TabIndex = 3;
            this.lblCaategory.Text = "Category";
            // 
            // lblOrigins
            // 
            this.lblOrigins.AutoSize = true;
            this.lblOrigins.Location = new System.Drawing.Point(35, 234);
            this.lblOrigins.Name = "lblOrigins";
            this.lblOrigins.Size = new System.Drawing.Size(39, 13);
            this.lblOrigins.TabIndex = 4;
            this.lblOrigins.Text = "Origins";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(35, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(35, 341);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(139, 341);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(278, 341);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(60, 13);
            this.lblMarkup.TabIndex = 8;
            this.lblMarkup.Text = "Markup (%)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(143, 27);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(238, 20);
            this.txtBarcode.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 101);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(238, 95);
            this.txtDescription.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "food";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Households ",
            "Fashion",
            "Garden",
            "etc.."});
            this.cmbCategory.Location = new System.Drawing.Point(143, 202);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 21);
            this.cmbCategory.TabIndex = 15;
            // 
            // grpOrigins
            // 
            this.grpOrigins.Controls.Add(this.rdoAbroad);
            this.grpOrigins.Controls.Add(this.rdoLocal);
            this.grpOrigins.Location = new System.Drawing.Point(143, 234);
            this.grpOrigins.Name = "grpOrigins";
            this.grpOrigins.Size = new System.Drawing.Size(238, 60);
            this.grpOrigins.TabIndex = 16;
            this.grpOrigins.TabStop = false;
            this.grpOrigins.Text = "Manifactured";
            // 
            // rdoAbroad
            // 
            this.rdoAbroad.AutoSize = true;
            this.rdoAbroad.Location = new System.Drawing.Point(116, 29);
            this.rdoAbroad.Name = "rdoAbroad";
            this.rdoAbroad.Size = new System.Drawing.Size(59, 17);
            this.rdoAbroad.TabIndex = 17;
            this.rdoAbroad.TabStop = true;
            this.rdoAbroad.Text = "Abroad";
            this.rdoAbroad.UseVisualStyleBackColor = true;
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Location = new System.Drawing.Point(28, 29);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(51, 17);
            this.rdoLocal.TabIndex = 17;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local";
            this.rdoLocal.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(142, 306);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(38, 357);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(142, 357);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 19;
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(281, 357);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(100, 20);
            this.txtMarkup.TabIndex = 20;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 453);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.grpOrigins);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrigins);
            this.Controls.Add(this.lblCaategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBarcode);
            this.Name = "frmProduct";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.grpOrigins.ResumeLayout(false);
            this.grpOrigins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCaategory;
        private System.Windows.Forms.Label lblOrigins;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox grpOrigins;
        private System.Windows.Forms.RadioButton rdoAbroad;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMarkup;
    }
}

