namespace EMS.Stock
{
    partial class frmCheckStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckStock));
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tlCmbStockType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tlTxtFindStock = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tltxtFullName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tltxtCheckStock = new System.Windows.Forms.ToolStripTextBox();
            this.tlbtnCheckStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockList
            // 
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Location = new System.Drawing.Point(0, 28);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowTemplate.Height = 23;
            this.dgvStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockList.Size = new System.Drawing.Size(857, 376);
            this.dgvStockList.TabIndex = 0;
            this.dgvStockList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellEnter);
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
            this.toolStripSeparator8,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.tltxtFullName,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator6,
            this.tltxtCheckStock,
            this.tlbtnCheckStock,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.tlBtnExit,
            this.toolStripSeparator9,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.tlTxtFindStock.Size = new System.Drawing.Size(150, 25);
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel2.Text = "盘点库存商品：";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tltxtFullName
            // 
            this.tltxtFullName.BackColor = System.Drawing.Color.White;
            this.tltxtFullName.Name = "tltxtFullName";
            this.tltxtFullName.ReadOnly = true;
            this.tltxtFullName.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "盘点数量：";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tltxtCheckStock
            // 
            this.tltxtCheckStock.Name = "tltxtCheckStock";
            this.tltxtCheckStock.Size = new System.Drawing.Size(40, 25);
            // 
            // tlbtnCheckStock
            // 
            this.tlbtnCheckStock.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnCheckStock.Image")));
            this.tlbtnCheckStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnCheckStock.Name = "tlbtnCheckStock";
            this.tlbtnCheckStock.Size = new System.Drawing.Size(73, 22);
            this.tlbtnCheckStock.Text = "保存盘点";
            this.tlbtnCheckStock.Click += new System.EventHandler(this.tlbtnCheckStock_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // frmCheckStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 404);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvStockList);
            this.MaximizeBox = false;
            this.Name = "frmCheckStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存盘点－－库存管理";
            this.Load += new System.EventHandler(this.frmCheckStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripComboBox tlCmbStockType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox tlTxtFindStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tlBtnFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tlBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tltxtFullName;
        private System.Windows.Forms.ToolStripButton tlbtnCheckStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox tltxtCheckStock;
    }
}