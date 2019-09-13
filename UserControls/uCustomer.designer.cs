namespace SCM.UserControls
{
    partial class uCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCustomer));
            this.pnlTopMenuPurchase = new System.Windows.Forms.Panel();
            this.btnStockOutput = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStockInput = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpennngBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopMenuPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopMenuPurchase
            // 
            this.pnlTopMenuPurchase.BackColor = System.Drawing.Color.Silver;
            this.pnlTopMenuPurchase.Controls.Add(this.btnStockOutput);
            this.pnlTopMenuPurchase.Controls.Add(this.button4);
            this.pnlTopMenuPurchase.Controls.Add(this.btnStockInput);
            this.pnlTopMenuPurchase.Controls.Add(this.btnDelete);
            this.pnlTopMenuPurchase.Controls.Add(this.btnEdit);
            this.pnlTopMenuPurchase.Controls.Add(this.btnItemAdd);
            this.pnlTopMenuPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenuPurchase.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenuPurchase.Name = "pnlTopMenuPurchase";
            this.pnlTopMenuPurchase.Size = new System.Drawing.Size(831, 38);
            this.pnlTopMenuPurchase.TabIndex = 6;
            // 
            // btnStockOutput
            // 
            this.btnStockOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStockOutput.FlatAppearance.BorderSize = 0;
            this.btnStockOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnStockOutput.Image")));
            this.btnStockOutput.Location = new System.Drawing.Point(331, 4);
            this.btnStockOutput.Name = "btnStockOutput";
            this.btnStockOutput.Size = new System.Drawing.Size(117, 30);
            this.btnStockOutput.TabIndex = 9;
            this.btnStockOutput.Text = "Stock Output";
            this.btnStockOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockOutput.UseCompatibleTextRendering = true;
            this.btnStockOutput.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(448, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add Expiration Date";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnStockInput
            // 
            this.btnStockInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStockInput.FlatAppearance.BorderSize = 0;
            this.btnStockInput.Image = ((System.Drawing.Image)(resources.GetObject("btnStockInput.Image")));
            this.btnStockInput.Location = new System.Drawing.Point(213, 4);
            this.btnStockInput.Name = "btnStockInput";
            this.btnStockInput.Size = new System.Drawing.Size(117, 30);
            this.btnStockInput.TabIndex = 7;
            this.btnStockInput.Text = "Stock Input";
            this.btnStockInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockInput.UseCompatibleTextRendering = true;
            this.btnStockInput.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(143, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(73, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnItemAdd.FlatAppearance.BorderSize = 0;
            this.btnItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.Image")));
            this.btnItemAdd.Location = new System.Drawing.Point(3, 4);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(69, 30);
            this.btnItemAdd.TabIndex = 4;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemAdd.UseCompatibleTextRendering = true;
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.BtnItemAdd_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.strName,
            this.MobileNo,
            this.Address,
            this.CreditBalance,
            this.OpennngBalance,
            this.Date});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 38);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(831, 273);
            this.dgvCustomer.TabIndex = 7;
            this.dgvCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomer_CellMouseClick);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "ID";
            this.intID.Name = "intID";
            // 
            // strName
            // 
            this.strName.DataPropertyName = "strCustomer";
            this.strName.HeaderText = "Name";
            this.strName.Name = "strName";
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "strMobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "strAddress";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // CreditBalance
            // 
            this.CreditBalance.DataPropertyName = "decCreditBlance";
            this.CreditBalance.HeaderText = "Credit Balance";
            this.CreditBalance.Name = "CreditBalance";
            // 
            // OpennngBalance
            // 
            this.OpennngBalance.DataPropertyName = "decOpeningBlance";
            this.OpennngBalance.HeaderText = "Opennng Balance";
            this.OpennngBalance.Name = "OpennngBalance";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "dteActionTime";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // uCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.pnlTopMenuPurchase);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "uCustomer";
            this.Size = new System.Drawing.Size(831, 311);
            this.pnlTopMenuPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenuPurchase;
        private System.Windows.Forms.Button btnStockOutput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStockInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn strName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpennngBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
