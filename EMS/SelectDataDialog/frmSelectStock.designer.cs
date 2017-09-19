namespace EMS.SelectDataDialog
{
    partial class frmSelectStock
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
            this.dgvSelectStockList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectStockList
            // 
            this.dgvSelectStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectStockList.Location = new System.Drawing.Point(-1, 0);
            this.dgvSelectStockList.Name = "dgvSelectStockList";
            this.dgvSelectStockList.RowTemplate.Height = 23;
            this.dgvSelectStockList.Size = new System.Drawing.Size(566, 199);
            this.dgvSelectStockList.TabIndex = 1;
            this.dgvSelectStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectStockList_CellDoubleClick);
            // 
            // frmSelectStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 199);
            this.Controls.Add(this.dgvSelectStockList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择－－库存商品－－";
            this.Load += new System.EventHandler(this.SelectStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStockList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectStockList;
    }
}