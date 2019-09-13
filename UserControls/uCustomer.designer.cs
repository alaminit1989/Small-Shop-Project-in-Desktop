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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.pnlTopMenuPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenuPurchase
            // 
            this.pnlTopMenuPurchase.BackColor = System.Drawing.Color.Silver;
            this.pnlTopMenuPurchase.Controls.Add(this.btnStockOutput);
            this.pnlTopMenuPurchase.Controls.Add(this.button4);
            this.pnlTopMenuPurchase.Controls.Add(this.btnStockInput);
            this.pnlTopMenuPurchase.Controls.Add(this.button2);
            this.pnlTopMenuPurchase.Controls.Add(this.button1);
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(143, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(73, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
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
            // uCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlTopMenuPurchase);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "uCustomer";
            this.Size = new System.Drawing.Size(831, 311);
            this.pnlTopMenuPurchase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenuPurchase;
        private System.Windows.Forms.Button btnStockOutput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStockInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnItemAdd;
    }
}
