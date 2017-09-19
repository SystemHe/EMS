namespace EMS.Stock
{
    partial class frmStockStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockStatus));
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlbtnSetStockLimit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockList
            // 
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Location = new System.Drawing.Point(0, 25);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowTemplate.Height = 23;
            this.dgvStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockList.Size = new System.Drawing.Size(554, 272);
            this.dgvStockList.TabIndex = 0;
            this.dgvStockList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbtnSetStockLimit,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tlbtnExit,
            this.toolStripSeparator3,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlbtnSetStockLimit
            // 
            this.tlbtnSetStockLimit.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnSetStockLimit.Image")));
            this.tlbtnSetStockLimit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnSetStockLimit.Name = "tlbtnSetStockLimit";
            this.tlbtnSetStockLimit.Size = new System.Drawing.Size(109, 22);
            this.tlbtnSetStockLimit.Text = "库存上下限设置";
            this.tlbtnSetStockLimit.Click += new System.EventHandler(this.tlbtnSetStockLimit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlbtnExit
            // 
            this.tlbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnExit.Image")));
            this.tlbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnExit.Name = "tlbtnExit";
            this.tlbtnExit.Size = new System.Drawing.Size(49, 22);
            this.tlbtnExit.Text = "退出";
            this.tlbtnExit.Click += new System.EventHandler(this.tlbtnExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // frmStockStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 296);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvStockList);
            this.MaximizeBox = false;
            this.Name = "frmStockStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存状况---库存管理";
            this.Load += new System.EventHandler(this.StockStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlbtnSetStockLimit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}