namespace EMS.SetSystem
{
    partial class frmSetOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetOP));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tltxtUserName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tltxtPwd = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvSysUserList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tltxtUserName,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.tltxtPwd,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.tlbtnAdd,
            this.toolStripSeparator7,
            this.tlbtnUpdate,
            this.toolStripSeparator2,
            this.tlbtnDel,
            this.toolStripSeparator8,
            this.tlbtnExit,
            this.toolStripSeparator10,
            this.toolStripSeparator11});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "用户名:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tltxtUserName
            // 
            this.tltxtUserName.Name = "tltxtUserName";
            this.tltxtUserName.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "密码：";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tltxtPwd
            // 
            this.tltxtPwd.Name = "tltxtPwd";
            this.tltxtPwd.Size = new System.Drawing.Size(60, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tlbtnAdd
            // 
            this.tlbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnAdd.Image")));
            this.tlbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnAdd.Name = "tlbtnAdd";
            this.tlbtnAdd.Size = new System.Drawing.Size(49, 22);
            this.tlbtnAdd.Text = "添加";
            this.tlbtnAdd.Click += new System.EventHandler(this.tlbtnAdd_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tlbtnUpdate
            // 
            this.tlbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnUpdate.Image")));
            this.tlbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnUpdate.Name = "tlbtnUpdate";
            this.tlbtnUpdate.Size = new System.Drawing.Size(49, 22);
            this.tlbtnUpdate.Text = "修改";
            this.tlbtnUpdate.Click += new System.EventHandler(this.tlbtnUpdate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlbtnDel
            // 
            this.tlbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tlbtnDel.Image")));
            this.tlbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbtnDel.Name = "tlbtnDel";
            this.tlbtnDel.Size = new System.Drawing.Size(49, 22);
            this.tlbtnDel.Text = "删除";
            this.tlbtnDel.Click += new System.EventHandler(this.tlbtnDel_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvSysUserList
            // 
            this.dgvSysUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysUserList.Location = new System.Drawing.Point(2, 25);
            this.dgvSysUserList.Name = "dgvSysUserList";
            this.dgvSysUserList.RowTemplate.Height = 23;
            this.dgvSysUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSysUserList.Size = new System.Drawing.Size(729, 326);
            this.dgvSysUserList.TabIndex = 1;
            this.dgvSysUserList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSysUserList_CellEndEdit);
            this.dgvSysUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSysUserList_CellClick);
            // 
            // frmSetOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 349);
            this.Controls.Add(this.dgvSysUserList);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmSetOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统管理设置";
            this.Load += new System.EventHandler(this.frmSetOP_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tltxtUserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tltxtPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tlbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tlbtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tlbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tlbtnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvSysUserList;
    }
}