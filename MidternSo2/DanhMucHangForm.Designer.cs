namespace MidternSo2
{
    partial class DanhMucHangForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grd_TTMH = new System.Windows.Forms.DataGridView();
            this.MA_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NHACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI_TINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn vị tính";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(479, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 20);
            this.textBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(673, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // grd_TTMH
            // 
            this.grd_TTMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_TTMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HANG,
            this.TEN_HANG,
            this.MA_NHACC,
            this.DON_VI_TINH});
            this.grd_TTMH.Location = new System.Drawing.Point(39, 128);
            this.grd_TTMH.Name = "grd_TTMH";
            this.grd_TTMH.Size = new System.Drawing.Size(714, 288);
            this.grd_TTMH.TabIndex = 5;
            // 
            // MA_HANG
            // 
            this.MA_HANG.DataPropertyName = "MA_HANG";
            this.MA_HANG.HeaderText = "Mã hàng";
            this.MA_HANG.Name = "MA_HANG";
            // 
            // TEN_HANG
            // 
            this.TEN_HANG.DataPropertyName = "TEN_HANG";
            this.TEN_HANG.HeaderText = "Tên hàng";
            this.TEN_HANG.Name = "TEN_HANG";
            this.TEN_HANG.Width = 300;
            // 
            // MA_NHACC
            // 
            this.MA_NHACC.DataPropertyName = "MA_NHACC";
            this.MA_NHACC.HeaderText = "Mã nhà cung cấp";
            this.MA_NHACC.Name = "MA_NHACC";
            this.MA_NHACC.Width = 150;
            // 
            // DON_VI_TINH
            // 
            this.DON_VI_TINH.DataPropertyName = "DON_VI_TINH";
            this.DON_VI_TINH.HeaderText = "Đơn vị tính";
            this.DON_VI_TINH.Name = "DON_VI_TINH";
            this.DON_VI_TINH.Width = 150;
            // 
            // DanhMucHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_TTMH);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhMucHangForm";
            this.Text = "DanhMucHangForm";
            this.Load += new System.EventHandler(this.DanhMucHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView grd_TTMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NHACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI_TINH;
    }
}