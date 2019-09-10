namespace SCM.UserControls
{
    partial class uProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopMenuPurchase = new System.Windows.Forms.Panel();
            this.btnStockOutput = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStockInput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.pnlStockInput = new System.Windows.Forms.Panel();
            this.btnStockAdjustmentInput = new System.Windows.Forms.Button();
            this.btnTransferInput = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCustomerReturn = new System.Windows.Forms.Button();
            this.pnlStockOutput = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.sprItemReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SCM.DataSet();
            this.sprItemReportTableAdapter = new SCM.DataSetTableAdapters.SprItemReportTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.intItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strItemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strUOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strItemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monBuyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monSalesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopMenuPurchase.SuspendLayout();
            this.pnlStockInput.SuspendLayout();
            this.pnlStockOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprItemReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
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
            this.pnlTopMenuPurchase.Size = new System.Drawing.Size(881, 38);
            this.pnlTopMenuPurchase.TabIndex = 5;
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
            this.btnStockOutput.Click += new System.EventHandler(this.BtnStockOutput_Click);
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
            this.btnStockInput.Click += new System.EventHandler(this.BtnStockInput_Click);
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
            // pnlStockInput
            // 
            this.pnlStockInput.Controls.Add(this.btnStockAdjustmentInput);
            this.pnlStockInput.Controls.Add(this.btnTransferInput);
            this.pnlStockInput.Controls.Add(this.btnPurchase);
            this.pnlStockInput.Controls.Add(this.btnCustomerReturn);
            this.pnlStockInput.Location = new System.Drawing.Point(213, 36);
            this.pnlStockInput.MaximumSize = new System.Drawing.Size(140, 125);
            this.pnlStockInput.Name = "pnlStockInput";
            this.pnlStockInput.Size = new System.Drawing.Size(140, 125);
            this.pnlStockInput.TabIndex = 6;
            // 
            // btnStockAdjustmentInput
            // 
            this.btnStockAdjustmentInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStockAdjustmentInput.FlatAppearance.BorderSize = 0;
            this.btnStockAdjustmentInput.Location = new System.Drawing.Point(0, 94);
            this.btnStockAdjustmentInput.Name = "btnStockAdjustmentInput";
            this.btnStockAdjustmentInput.Size = new System.Drawing.Size(139, 30);
            this.btnStockAdjustmentInput.TabIndex = 11;
            this.btnStockAdjustmentInput.Text = "Stock Adjustment";
            this.btnStockAdjustmentInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockAdjustmentInput.UseCompatibleTextRendering = true;
            this.btnStockAdjustmentInput.UseVisualStyleBackColor = true;
            // 
            // btnTransferInput
            // 
            this.btnTransferInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTransferInput.FlatAppearance.BorderSize = 0;
            this.btnTransferInput.Location = new System.Drawing.Point(0, 63);
            this.btnTransferInput.Name = "btnTransferInput";
            this.btnTransferInput.Size = new System.Drawing.Size(139, 30);
            this.btnTransferInput.TabIndex = 10;
            this.btnTransferInput.Text = "Transfer Between Stores";
            this.btnTransferInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransferInput.UseCompatibleTextRendering = true;
            this.btnTransferInput.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.Location = new System.Drawing.Point(0, 32);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(139, 30);
            this.btnPurchase.TabIndex = 9;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseCompatibleTextRendering = true;
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnCustomerReturn
            // 
            this.btnCustomerReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCustomerReturn.FlatAppearance.BorderSize = 0;
            this.btnCustomerReturn.Location = new System.Drawing.Point(0, 1);
            this.btnCustomerReturn.Name = "btnCustomerReturn";
            this.btnCustomerReturn.Size = new System.Drawing.Size(139, 30);
            this.btnCustomerReturn.TabIndex = 8;
            this.btnCustomerReturn.Text = "Customer Return";
            this.btnCustomerReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerReturn.UseCompatibleTextRendering = true;
            this.btnCustomerReturn.UseVisualStyleBackColor = true;
            // 
            // pnlStockOutput
            // 
            this.pnlStockOutput.Controls.Add(this.button17);
            this.pnlStockOutput.Controls.Add(this.button16);
            this.pnlStockOutput.Controls.Add(this.button15);
            this.pnlStockOutput.Controls.Add(this.button11);
            this.pnlStockOutput.Controls.Add(this.button12);
            this.pnlStockOutput.Controls.Add(this.button13);
            this.pnlStockOutput.Controls.Add(this.button14);
            this.pnlStockOutput.Location = new System.Drawing.Point(333, 36);
            this.pnlStockOutput.MaximumSize = new System.Drawing.Size(140, 219);
            this.pnlStockOutput.Name = "pnlStockOutput";
            this.pnlStockOutput.Size = new System.Drawing.Size(140, 219);
            this.pnlStockOutput.TabIndex = 12;
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Location = new System.Drawing.Point(0, 187);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(139, 30);
            this.button17.TabIndex = 14;
            this.button17.Text = "Stock Adjustment";
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button17.UseCompatibleTextRendering = true;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.Location = new System.Drawing.Point(0, 156);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(139, 30);
            this.button16.TabIndex = 13;
            this.button16.Text = "Other Outputs";
            this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button16.UseCompatibleTextRendering = true;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Location = new System.Drawing.Point(0, 125);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(139, 30);
            this.button15.TabIndex = 12;
            this.button15.Text = "Internal Use";
            this.button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button15.UseCompatibleTextRendering = true;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Location = new System.Drawing.Point(0, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(139, 30);
            this.button11.TabIndex = 11;
            this.button11.Text = "Gift";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseCompatibleTextRendering = true;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Location = new System.Drawing.Point(0, 63);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(139, 30);
            this.button12.TabIndex = 10;
            this.button12.Text = "Transfer Between Stores";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseCompatibleTextRendering = true;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Location = new System.Drawing.Point(0, 32);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 30);
            this.button13.TabIndex = 9;
            this.button13.Text = "Transfer Between Stores";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseCompatibleTextRendering = true;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Location = new System.Drawing.Point(0, 1);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(139, 30);
            this.button14.TabIndex = 8;
            this.button14.Text = "Return To Supplier";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseCompatibleTextRendering = true;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AccessibleDescription = "";
            this.dgvItemList.AccessibleName = "";
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intItemIDDataGridViewTextBoxColumn,
            this.strItemCodeDataGridViewTextBoxColumn,
            this.strItemNameDataGridViewTextBoxColumn,
            this.strDescriptionDataGridViewTextBoxColumn,
            this.strUOMDataGridViewTextBoxColumn,
            this.strItemTypeDataGridViewTextBoxColumn,
            this.monBuyPriceDataGridViewTextBoxColumn,
            this.monSalesPriceDataGridViewTextBoxColumn,
            this.monDiscountDataGridViewTextBoxColumn});
            this.dgvItemList.DataSource = this.sprItemReportBindingSource;
            this.dgvItemList.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItemList.Location = new System.Drawing.Point(15, 85);
            this.dgvItemList.Name = "dgvItemList";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItemList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemList.RowTemplate.ReadOnly = true;
            this.dgvItemList.Size = new System.Drawing.Size(852, 399);
            this.dgvItemList.TabIndex = 169;
            this.dgvItemList.Tag = "";
            // 
            // sprItemReportBindingSource
            // 
            this.sprItemReportBindingSource.DataMember = "SprItemReport";
            this.sprItemReportBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprItemReportTableAdapter
            // 
            this.sprItemReportTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 22);
            this.label13.TabIndex = 179;
            this.label13.Text = "Item List :";
            // 
            // intItemIDDataGridViewTextBoxColumn
            // 
            this.intItemIDDataGridViewTextBoxColumn.DataPropertyName = "intItemID";
            this.intItemIDDataGridViewTextBoxColumn.HeaderText = "intItemID";
            this.intItemIDDataGridViewTextBoxColumn.Name = "intItemIDDataGridViewTextBoxColumn";
            this.intItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.intItemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // strItemCodeDataGridViewTextBoxColumn
            // 
            this.strItemCodeDataGridViewTextBoxColumn.DataPropertyName = "strItemCode";
            this.strItemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.strItemCodeDataGridViewTextBoxColumn.Name = "strItemCodeDataGridViewTextBoxColumn";
            this.strItemCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // strItemNameDataGridViewTextBoxColumn
            // 
            this.strItemNameDataGridViewTextBoxColumn.DataPropertyName = "strItemName";
            this.strItemNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.strItemNameDataGridViewTextBoxColumn.Name = "strItemNameDataGridViewTextBoxColumn";
            this.strItemNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // strDescriptionDataGridViewTextBoxColumn
            // 
            this.strDescriptionDataGridViewTextBoxColumn.DataPropertyName = "strDescription";
            this.strDescriptionDataGridViewTextBoxColumn.HeaderText = "strDescription";
            this.strDescriptionDataGridViewTextBoxColumn.Name = "strDescriptionDataGridViewTextBoxColumn";
            this.strDescriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // strUOMDataGridViewTextBoxColumn
            // 
            this.strUOMDataGridViewTextBoxColumn.DataPropertyName = "strUOM";
            this.strUOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.strUOMDataGridViewTextBoxColumn.Name = "strUOMDataGridViewTextBoxColumn";
            this.strUOMDataGridViewTextBoxColumn.Width = 80;
            // 
            // strItemTypeDataGridViewTextBoxColumn
            // 
            this.strItemTypeDataGridViewTextBoxColumn.DataPropertyName = "strItemType";
            this.strItemTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.strItemTypeDataGridViewTextBoxColumn.Name = "strItemTypeDataGridViewTextBoxColumn";
            // 
            // monBuyPriceDataGridViewTextBoxColumn
            // 
            this.monBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "monBuyPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.monBuyPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.monBuyPriceDataGridViewTextBoxColumn.HeaderText = "Buy Price";
            this.monBuyPriceDataGridViewTextBoxColumn.Name = "monBuyPriceDataGridViewTextBoxColumn";
            this.monBuyPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // monSalesPriceDataGridViewTextBoxColumn
            // 
            this.monSalesPriceDataGridViewTextBoxColumn.DataPropertyName = "monSalesPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.monSalesPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.monSalesPriceDataGridViewTextBoxColumn.HeaderText = "Sales Price";
            this.monSalesPriceDataGridViewTextBoxColumn.Name = "monSalesPriceDataGridViewTextBoxColumn";
            this.monSalesPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // monDiscountDataGridViewTextBoxColumn
            // 
            this.monDiscountDataGridViewTextBoxColumn.DataPropertyName = "monDiscount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.monDiscountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.monDiscountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.monDiscountDataGridViewTextBoxColumn.Name = "monDiscountDataGridViewTextBoxColumn";
            this.monDiscountDataGridViewTextBoxColumn.Width = 80;
            // 
            // uProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.pnlStockOutput);
            this.Controls.Add(this.pnlStockInput);
            this.Controls.Add(this.pnlTopMenuPurchase);
            this.Name = "uProduct";
            this.Size = new System.Drawing.Size(881, 526);
            this.Load += new System.EventHandler(this.UProduct_Load);
            this.Click += new System.EventHandler(this.UProduct_Click);
            this.pnlTopMenuPurchase.ResumeLayout(false);
            this.pnlStockInput.ResumeLayout(false);
            this.pnlStockOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprItemReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenuPurchase;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStockInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnStockOutput;
        private System.Windows.Forms.Panel pnlStockInput;
        private System.Windows.Forms.Button btnStockAdjustmentInput;
        private System.Windows.Forms.Button btnTransferInput;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCustomerReturn;
        private System.Windows.Forms.Panel pnlStockOutput;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.BindingSource sprItemReportBindingSource;
        private DataSet dataSet;
        private DataSetTableAdapters.SprItemReportTableAdapter sprItemReportTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn intItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strItemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strUOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strItemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monSalesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monDiscountDataGridViewTextBoxColumn;
    }
}
