namespace EMS.BuyStock
{
    partial class frmRebuyStock
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtFullPayment = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.btnEixt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnSelectUnits = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectHandle = new System.Windows.Forms.Button();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "金额";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "商品单位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBalance.Location = new System.Drawing.Point(340, 326);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(60, 20);
            this.txtBalance.TabIndex = 20;
            this.txtBalance.Text = "0";
            // 
            // txtpayment
            // 
            this.txtpayment.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtpayment.Location = new System.Drawing.Point(211, 326);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(80, 20);
            this.txtpayment.TabIndex = 21;
            this.txtpayment.Text = "0";
            this.txtpayment.TextChanged += new System.EventHandler(this.txtpayment_TextChanged);
            // 
            // txtFullPayment
            // 
            this.txtFullPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFullPayment.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullPayment.Location = new System.Drawing.Point(211, 307);
            this.txtFullPayment.Name = "txtFullPayment";
            this.txtFullPayment.ReadOnly = true;
            this.txtFullPayment.Size = new System.Drawing.Size(80, 20);
            this.txtFullPayment.TabIndex = 22;
            this.txtFullPayment.Text = "0";
            // 
            // txtStockQty
            // 
            this.txtStockQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStockQty.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStockQty.Location = new System.Drawing.Point(76, 308);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.ReadOnly = true;
            this.txtStockQty.Size = new System.Drawing.Size(60, 20);
            this.txtStockQty.TabIndex = 19;
            // 
            // btnEixt
            // 
            this.btnEixt.Location = new System.Drawing.Point(524, 320);
            this.btnEixt.Name = "btnEixt";
            this.btnEixt.Size = new System.Drawing.Size(75, 23);
            this.btnEixt.TabIndex = 17;
            this.btnEixt.Text = "退出";
            this.btnEixt.UseVisualStyleBackColor = true;
            this.btnEixt.Click += new System.EventHandler(this.btnEixt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "差额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "实收金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "应收金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "进货数量：";
            // 
            // txtHandle
            // 
            this.txtHandle.Font = new System.Drawing.Font("宋体", 9F);
            this.txtHandle.Location = new System.Drawing.Point(57, 44);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(79, 21);
            this.txtHandle.TabIndex = 8;
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("宋体", 9F);
            this.txtSummary.Location = new System.Drawing.Point(57, 66);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(553, 21);
            this.txtSummary.TabIndex = 7;
            // 
            // txtBillDate
            // 
            this.txtBillDate.BackColor = System.Drawing.Color.White;
            this.txtBillDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline);
            this.txtBillDate.ForeColor = System.Drawing.Color.Blue;
            this.txtBillDate.Location = new System.Drawing.Point(528, 12);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.ReadOnly = true;
            this.txtBillDate.Size = new System.Drawing.Size(80, 21);
            this.txtBillDate.TabIndex = 6;
            this.txtBillDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnits
            // 
            this.txtUnits.Font = new System.Drawing.Font("宋体", 9F);
            this.txtUnits.Location = new System.Drawing.Point(251, 44);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(333, 21);
            this.txtUnits.TabIndex = 9;
            // 
            // btnSelectUnits
            // 
            this.btnSelectUnits.Location = new System.Drawing.Point(585, 43);
            this.btnSelectUnits.Name = "btnSelectUnits";
            this.btnSelectUnits.Size = new System.Drawing.Size(25, 23);
            this.btnSelectUnits.TabIndex = 10;
            this.btnSelectUnits.Text = "<<";
            this.btnSelectUnits.UseVisualStyleBackColor = true;
            this.btnSelectUnits.Click += new System.EventHandler(this.btnSelectUnits_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSelectUnits);
            this.groupBox1.Controls.Add(this.btnSelectHandle);
            this.groupBox1.Controls.Add(this.txtUnits);
            this.groupBox1.Controls.Add(this.txtHandle);
            this.groupBox1.Controls.Add(this.txtSummary);
            this.groupBox1.Controls.Add(this.txtBillDate);
            this.groupBox1.Controls.Add(this.txtBillCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货退货单";
            // 
            // btnSelectHandle
            // 
            this.btnSelectHandle.Location = new System.Drawing.Point(137, 43);
            this.btnSelectHandle.Name = "btnSelectHandle";
            this.btnSelectHandle.Size = new System.Drawing.Size(25, 23);
            this.btnSelectHandle.TabIndex = 10;
            this.btnSelectHandle.Text = "<<";
            this.btnSelectHandle.UseVisualStyleBackColor = true;
            this.btnSelectHandle.Click += new System.EventHandler(this.btnSelectHandle_Click);
            // 
            // txtBillCode
            // 
            this.txtBillCode.BackColor = System.Drawing.Color.White;
            this.txtBillCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Underline);
            this.txtBillCode.ForeColor = System.Drawing.Color.Blue;
            this.txtBillCode.Location = new System.Drawing.Point(346, 12);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(115, 21);
            this.txtBillCode.TabIndex = 5;
            this.txtBillCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "摘要：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "供货单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "经手人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "录单日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单据编号：";
            // 
            // dgvStockList
            // 
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvStockList.Location = new System.Drawing.Point(1, 96);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowTemplate.Height = 23;
            this.dgvStockList.Size = new System.Drawing.Size(614, 203);
            this.dgvStockList.TabIndex = 12;
            this.dgvStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellDoubleClick);
            this.dgvStockList.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvStockList_CellStateChanged);
            this.dgvStockList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // frmRebuyStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 347);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtpayment);
            this.Controls.Add(this.txtFullPayment);
            this.Controls.Add(this.txtStockQty);
            this.Controls.Add(this.btnEixt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStockList);
            this.MaximizeBox = false;
            this.Name = "frmRebuyStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货退货单－－进货管理";
            this.Load += new System.EventHandler(this.frmRebuyStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.TextBox txtFullPayment;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.Button btnEixt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtHandle;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtBillDate;
        public System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Button btnSelectUnits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectHandle;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvStockList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}