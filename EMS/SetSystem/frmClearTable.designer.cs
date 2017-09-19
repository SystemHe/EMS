namespace EMS.SetSystem
{
    partial class frmClearTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClearTable));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUnit = new System.Windows.Forms.CheckBox();
            this.chkResell = new System.Windows.Forms.CheckBox();
            this.chkRewarehouse = new System.Windows.Forms.CheckBox();
            this.chkCurrent = new System.Windows.Forms.CheckBox();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.chkSell = new System.Windows.Forms.CheckBox();
            this.chkWarehouse = new System.Windows.Forms.CheckBox();
            this.chkUnits = new System.Windows.Forms.CheckBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUnit);
            this.groupBox1.Controls.Add(this.chkResell);
            this.groupBox1.Controls.Add(this.chkRewarehouse);
            this.groupBox1.Controls.Add(this.chkCurrent);
            this.groupBox1.Controls.Add(this.chkEmployee);
            this.groupBox1.Controls.Add(this.chkUser);
            this.groupBox1.Controls.Add(this.chkSell);
            this.groupBox1.Controls.Add(this.chkWarehouse);
            this.groupBox1.Controls.Add(this.chkUnits);
            this.groupBox1.Controls.Add(this.chkStock);
            this.groupBox1.Location = new System.Drawing.Point(208, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkUnit
            // 
            this.chkUnit.AutoSize = true;
            this.chkUnit.ForeColor = System.Drawing.Color.Blue;
            this.chkUnit.Location = new System.Drawing.Point(119, 103);
            this.chkUnit.Name = "chkUnit";
            this.chkUnit.Size = new System.Drawing.Size(96, 16);
            this.chkUnit.TabIndex = 0;
            this.chkUnit.Text = "本单位信息表";
            this.chkUnit.UseVisualStyleBackColor = true;
            // 
            // chkResell
            // 
            this.chkResell.AutoSize = true;
            this.chkResell.Checked = true;
            this.chkResell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResell.Enabled = false;
            this.chkResell.ForeColor = System.Drawing.Color.Red;
            this.chkResell.Location = new System.Drawing.Point(119, 78);
            this.chkResell.Name = "chkResell";
            this.chkResell.Size = new System.Drawing.Size(84, 16);
            this.chkResell.TabIndex = 0;
            this.chkResell.Text = "销售退货表";
            this.chkResell.UseVisualStyleBackColor = true;
            // 
            // chkRewarehouse
            // 
            this.chkRewarehouse.AutoSize = true;
            this.chkRewarehouse.Checked = true;
            this.chkRewarehouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRewarehouse.Enabled = false;
            this.chkRewarehouse.ForeColor = System.Drawing.Color.Red;
            this.chkRewarehouse.Location = new System.Drawing.Point(119, 59);
            this.chkRewarehouse.Name = "chkRewarehouse";
            this.chkRewarehouse.Size = new System.Drawing.Size(84, 16);
            this.chkRewarehouse.TabIndex = 0;
            this.chkRewarehouse.Text = "进货退货表";
            this.chkRewarehouse.UseVisualStyleBackColor = true;
            // 
            // chkCurrent
            // 
            this.chkCurrent.AutoSize = true;
            this.chkCurrent.Checked = true;
            this.chkCurrent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCurrent.Enabled = false;
            this.chkCurrent.ForeColor = System.Drawing.Color.Red;
            this.chkCurrent.Location = new System.Drawing.Point(119, 34);
            this.chkCurrent.Name = "chkCurrent";
            this.chkCurrent.Size = new System.Drawing.Size(96, 16);
            this.chkCurrent.TabIndex = 0;
            this.chkCurrent.Text = "往来账明细表";
            this.chkCurrent.UseVisualStyleBackColor = true;
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.ForeColor = System.Drawing.Color.Blue;
            this.chkEmployee.Location = new System.Drawing.Point(119, 15);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(84, 16);
            this.chkEmployee.TabIndex = 0;
            this.chkEmployee.Text = "职员信息表";
            this.chkEmployee.UseVisualStyleBackColor = true;
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.ForeColor = System.Drawing.Color.Blue;
            this.chkUser.Location = new System.Drawing.Point(10, 103);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(60, 16);
            this.chkUser.TabIndex = 0;
            this.chkUser.Text = "权限表";
            this.chkUser.UseVisualStyleBackColor = true;
            // 
            // chkSell
            // 
            this.chkSell.AutoSize = true;
            this.chkSell.Checked = true;
            this.chkSell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSell.Enabled = false;
            this.chkSell.ForeColor = System.Drawing.Color.Red;
            this.chkSell.Location = new System.Drawing.Point(10, 78);
            this.chkSell.Name = "chkSell";
            this.chkSell.Size = new System.Drawing.Size(60, 16);
            this.chkSell.TabIndex = 0;
            this.chkSell.Text = "销售表";
            this.chkSell.UseVisualStyleBackColor = true;
            // 
            // chkWarehouse
            // 
            this.chkWarehouse.AutoSize = true;
            this.chkWarehouse.Checked = true;
            this.chkWarehouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarehouse.Enabled = false;
            this.chkWarehouse.ForeColor = System.Drawing.Color.Red;
            this.chkWarehouse.Location = new System.Drawing.Point(10, 59);
            this.chkWarehouse.Name = "chkWarehouse";
            this.chkWarehouse.Size = new System.Drawing.Size(60, 16);
            this.chkWarehouse.TabIndex = 0;
            this.chkWarehouse.Text = "进货表";
            this.chkWarehouse.UseVisualStyleBackColor = true;
            // 
            // chkUnits
            // 
            this.chkUnits.AutoSize = true;
            this.chkUnits.ForeColor = System.Drawing.Color.Blue;
            this.chkUnits.Location = new System.Drawing.Point(10, 34);
            this.chkUnits.Name = "chkUnits";
            this.chkUnits.Size = new System.Drawing.Size(108, 16);
            this.chkUnits.TabIndex = 0;
            this.chkUnits.Text = "往来单位信息表";
            this.chkUnits.UseVisualStyleBackColor = true;
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.ForeColor = System.Drawing.Color.Blue;
            this.chkStock.Location = new System.Drawing.Point(10, 15);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(108, 16);
            this.chkStock.TabIndex = 0;
            this.chkStock.Text = "库存商品信息表";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 155);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "                                        \r\n　　　注意：系统数据清理，将清理\r\n　　　　　　　　　　　　　　　　　　系统所" +
                "有的数据以及帐本数据都\r\n　　　　　　　　　　　　　　　　　　不存在，在系统清理磁盘前，请\r\n　　　　　　　　　　　　　　　　　　作好备份工作，否则造成大量数\r" +
                "\n　　　　　　　　　　　　　　　　　　据丢失带来不必要的损失。";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(231, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清理";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmClearTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 158);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmClearTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统数据清理－－系统维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUnit;
        private System.Windows.Forms.CheckBox chkResell;
        private System.Windows.Forms.CheckBox chkRewarehouse;
        private System.Windows.Forms.CheckBox chkCurrent;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.CheckBox chkSell;
        private System.Windows.Forms.CheckBox chkWarehouse;
        private System.Windows.Forms.CheckBox chkUnits;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}