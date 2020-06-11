namespace MidternSo2
{
    partial class NhaCungCapForm
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
            this.grd_NCC = new System.Windows.Forms.DataGridView();
            this.MA_NHACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NHA_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_DIEN_THOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // grd_NCC
            // 
            this.grd_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NHACC,
            this.TEN_NHA_CC,
            this.DIA_CHI,
            this.SO_DIEN_THOAI});
            this.grd_NCC.Location = new System.Drawing.Point(45, 141);
            this.grd_NCC.Name = "grd_NCC";
            this.grd_NCC.Size = new System.Drawing.Size(714, 285);
            this.grd_NCC.TabIndex = 14;
            this.grd_NCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_NCC_CellContentClick);
            // 
            // MA_NHACC
            // 
            this.MA_NHACC.DataPropertyName = "MA_NHACC";
            this.MA_NHACC.HeaderText = "Mã nhà cung cấp";
            this.MA_NHACC.Name = "MA_NHACC";
            this.MA_NHACC.Width = 150;
            // 
            // TEN_NHA_CC
            // 
            this.TEN_NHA_CC.DataPropertyName = "TEN_NHA_CC";
            this.TEN_NHA_CC.HeaderText = "Tên nhà cung cấp";
            this.TEN_NHA_CC.Name = "TEN_NHA_CC";
            this.TEN_NHA_CC.Width = 200;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.DataPropertyName = "DIA_CHI";
            this.DIA_CHI.HeaderText = "Địa chỉ";
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.Width = 200;
            // 
            // SO_DIEN_THOAI
            // 
            this.SO_DIEN_THOAI.DataPropertyName = "SO_DIEN_THOAI";
            this.SO_DIEN_THOAI.HeaderText = "Số điện thoại";
            this.SO_DIEN_THOAI.Name = "SO_DIEN_THOAI";
            this.SO_DIEN_THOAI.Width = 120;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(504, 56);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(102, 20);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(325, 56);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(111, 20);
            this.txt_TenNCC.TabIndex = 11;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(132, 56);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(58, 20);
            this.txt_MaNCC.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(672, 57);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(102, 20);
            this.txt_SDT.TabIndex = 10;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(174, 98);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(305, 98);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(439, 98);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(571, 98);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // NhaCungCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grd_NCC);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhaCungCapForm";
            this.Text = "NhaCungCapForm";
            this.Load += new System.EventHandler(this.NhaCungCapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_NCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_NCC;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NHACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NHA_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_DIEN_THOAI;
    }
}