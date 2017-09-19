namespace EMS.BuyStock
{
    partial class frmUnitsList
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
            this.dgvUnitsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnitsList
            // 
            this.dgvUnitsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsList.Location = new System.Drawing.Point(1, 2);
            this.dgvUnitsList.Name = "dgvUnitsList";
            this.dgvUnitsList.RowTemplate.Height = 23;
            this.dgvUnitsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitsList.Size = new System.Drawing.Size(461, 286);
            this.dgvUnitsList.TabIndex = 0;
            this.dgvUnitsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitsList_CellDoubleClick);
            // 
            // frmUnitsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Controls.Add(this.dgvUnitsList);
            this.MaximizeBox = false;
            this.Name = "frmUnitsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "往来单位列表";
            this.Load += new System.EventHandler(this.frmUnitsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnitsList;
    }
}