namespace EMS.SelectDataDialog
{
    partial class frmSelectOrderby
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSaleSum = new System.Windows.Forms.RadioButton();
            this.rdbSaleQty = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStar = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbHandle = new System.Windows.Forms.ComboBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSaleSum);
            this.groupBox1.Controls.Add(this.rdbSaleQty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpStar);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.cmbHandle);
            this.groupBox1.Controls.Add(this.cmbUnits);
            this.groupBox1.Location = new System.Drawing.Point(9, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbSaleSum
            // 
            this.rdbSaleSum.AutoSize = true;
            this.rdbSaleSum.Location = new System.Drawing.Point(217, 45);
            this.rdbSaleSum.Name = "rdbSaleSum";
            this.rdbSaleSum.Size = new System.Drawing.Size(107, 16);
            this.rdbSaleSum.TabIndex = 3;
            this.rdbSaleSum.Text = "按销售金额排行";
            this.rdbSaleSum.UseVisualStyleBackColor = true;
            // 
            // rdbSaleQty
            // 
            this.rdbSaleQty.AutoSize = true;
            this.rdbSaleQty.Checked = true;
            this.rdbSaleQty.Location = new System.Drawing.Point(217, 22);
            this.rdbSaleQty.Name = "rdbSaleQty";
            this.rdbSaleQty.Size = new System.Drawing.Size(107, 16);
            this.rdbSaleQty.TabIndex = 3;
            this.rdbSaleQty.TabStop = true;
            this.rdbSaleQty.Text = "按销售数量排行";
            this.rdbSaleQty.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "日　　期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "经 手 人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "往来单位：";
            // 
            // dtpStar
            // 
            this.dtpStar.Location = new System.Drawing.Point(74, 69);
            this.dtpStar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpStar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpStar.Name = "dtpStar";
            this.dtpStar.Size = new System.Drawing.Size(111, 21);
            this.dtpStar.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(213, 69);
            this.dtpEnd.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(111, 21);
            this.dtpEnd.TabIndex = 1;
            // 
            // cmbHandle
            // 
            this.cmbHandle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandle.FormattingEnabled = true;
            this.cmbHandle.Location = new System.Drawing.Point(76, 43);
            this.cmbHandle.Name = "cmbHandle";
            this.cmbHandle.Size = new System.Drawing.Size(128, 20);
            this.cmbHandle.TabIndex = 0;
            // 
            // cmbUnits
            // 
            this.cmbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(76, 20);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(128, 20);
            this.cmbUnits.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "注意：往来单位和经手人不选择，为查询所有！";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(144, 137);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSelectOrderby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectOrderby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择排行榜条件";
            this.Load += new System.EventHandler(this.frmSelectOrderby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStar;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbHandle;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbSaleSum;
        private System.Windows.Forms.RadioButton rdbSaleQty;
    }
}