namespace EMS.BaseInfo
{
    partial class frmStock
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tlCmbStockType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tlTxtFindStock = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProduce = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStandard = new System.Windows.Forms.TextBox();
            this.txtTradeCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator12,
            this.tlCmbStockType,
            this.toolStripSeparator13,
            this.tlTxtFindStock,
            this.toolStripSeparator14,
            this.tlBtnFind,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.tlBtnAdd,
            this.toolStripSeparator3,
            this.tlBtnEdit,
            this.toolStripSeparator5,
            this.tlBtnSave,
            this.toolStripSeparator11,
            this.tlBtnCancel,
            this.toolStripSeparator2,
            this.tlBtnDelete,
            this.toolStripSeparator6,
            this.toolStripSeparator8,
            this.tlBtnExit,
            this.toolStripSeparator9,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "查询类别：";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tlCmbStockType
            // 
            this.tlCmbStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tlCmbStockType.Items.AddRange(new object[] {
            "商品名称",
            "商品产地"});
            this.tlCmbStockType.Name = "tlCmbStockType";
            this.tlCmbStockType.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tlTxtFindStock
            // 
            this.tlTxtFindStock.Name = "tlTxtFindStock";
            this.tlTxtFindStock.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnFind
            // 
            this.tlBtnFind.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnFind.Image")));
            this.tlBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnFind.Name = "tlBtnFind";
            this.tlBtnFind.Size = new System.Drawing.Size(49, 22);
            this.tlBtnFind.Text = "查询";
            this.tlBtnFind.Click += new System.EventHandler(this.tlBtnFind_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnAdd
            // 
            this.tlBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnAdd.Image")));
            this.tlBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnAdd.Name = "tlBtnAdd";
            this.tlBtnAdd.Size = new System.Drawing.Size(49, 22);
            this.tlBtnAdd.Text = "添加";
            this.tlBtnAdd.Click += new System.EventHandler(this.tlBtnAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnEdit
            // 
            this.tlBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnEdit.Image")));
            this.tlBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnEdit.Name = "tlBtnEdit";
            this.tlBtnEdit.Size = new System.Drawing.Size(49, 22);
            this.tlBtnEdit.Text = "编辑";
            this.tlBtnEdit.Click += new System.EventHandler(this.tlBtnEdit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnSave
            // 
            this.tlBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnSave.Image")));
            this.tlBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnSave.Name = "tlBtnSave";
            this.tlBtnSave.Size = new System.Drawing.Size(49, 22);
            this.tlBtnSave.Text = "保存";
            this.tlBtnSave.Click += new System.EventHandler(this.tlBtnSave_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnCancel
            // 
            this.tlBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnCancel.Image")));
            this.tlBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnCancel.Name = "tlBtnCancel";
            this.tlBtnCancel.Size = new System.Drawing.Size(49, 22);
            this.tlBtnCancel.Text = "取消";
            this.tlBtnCancel.Click += new System.EventHandler(this.tlBtnCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnDelete
            // 
            this.tlBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnDelete.Image")));
            this.tlBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnDelete.Name = "tlBtnDelete";
            this.tlBtnDelete.Size = new System.Drawing.Size(49, 22);
            this.tlBtnDelete.Text = "删除";
            this.tlBtnDelete.Click += new System.EventHandler(this.tlBtnDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBtnExit
            // 
            this.tlBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnExit.Image")));
            this.tlBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnExit.Name = "tlBtnExit";
            this.tlBtnExit.Size = new System.Drawing.Size(49, 22);
            this.tlBtnExit.Text = "退出";
            this.tlBtnExit.Click += new System.EventHandler(this.tlBtnExit_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProduce);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtStandard);
            this.groupBox1.Controls.Add(this.txtTradeCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存商品---基本信息";
            // 
            // txtProduce
            // 
            this.txtProduce.Location = new System.Drawing.Point(439, 39);
            this.txtProduce.Name = "txtProduce";
            this.txtProduce.Size = new System.Drawing.Size(244, 21);
            this.txtProduce.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(439, 16);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 21);
            this.txtType.TabIndex = 4;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(245, 39);
            this.txtUnit.MaxLength = 2;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(128, 21);
            this.txtUnit.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(245, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(128, 21);
            this.txtFullName.TabIndex = 4;
            // 
            // txtStandard
            // 
            this.txtStandard.Location = new System.Drawing.Point(79, 39);
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.Size = new System.Drawing.Size(100, 21);
            this.txtStandard.TabIndex = 4;
            // 
            // txtTradeCode
            // 
            this.txtTradeCode.Location = new System.Drawing.Point(79, 17);
            this.txtTradeCode.Name = "txtTradeCode";
            this.txtTradeCode.Size = new System.Drawing.Size(100, 21);
            this.txtTradeCode.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品产地：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "商品单位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品规格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品型号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品全称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品编号：";
            // 
            // dgvStockList
            // 
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Location = new System.Drawing.Point(0, 94);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowTemplate.Height = 23;
            this.dgvStockList.Size = new System.Drawing.Size(686, 264);
            this.dgvStockList.TabIndex = 5;
            this.dgvStockList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellClick);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 359);
            this.Controls.Add(this.dgvStockList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存商品---基本信息";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripComboBox tlCmbStockType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox tlTxtFindStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tlBtnFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlBtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlBtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tlBtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlBtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tlBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProduce;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStandard;
        private System.Windows.Forms.TextBox txtTradeCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStockList;
    }
}