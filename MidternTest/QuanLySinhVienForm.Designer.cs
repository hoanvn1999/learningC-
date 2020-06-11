namespace MidternTest
{
    partial class QuanLySinhVienForm
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
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_XepLoai = new System.Windows.Forms.TextBox();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DiemLT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DiemTH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grd_SinhVien = new System.Windows.Forms.DataGridView();
            this.TENSINHVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMLYTHUYET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHUCHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTRUNGBINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XEPLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.openFileDialog_Avata = new System.Windows.Forms.OpenFileDialog();
            this.picture_Avata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Avata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(119, 78);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(65, 20);
            this.txt_MaSV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên";
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(342, 78);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(184, 20);
            this.txt_TenSV.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Xếp loại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(119, 121);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(131, 20);
            this.txt_DiaChi.TabIndex = 2;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.Location = new System.Drawing.Point(342, 121);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(198, 20);
            this.date_NgaySinh.TabIndex = 3;
            // 
            // txt_XepLoai
            // 
            this.txt_XepLoai.Location = new System.Drawing.Point(623, 122);
            this.txt_XepLoai.Name = "txt_XepLoai";
            this.txt_XepLoai.Size = new System.Drawing.Size(65, 20);
            this.txt_XepLoai.TabIndex = 2;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(624, 77);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(64, 21);
            this.cbb_GioiTinh.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Điểm lí thuyết";
            // 
            // txt_DiemLT
            // 
            this.txt_DiemLT.Location = new System.Drawing.Point(119, 161);
            this.txt_DiemLT.Name = "txt_DiemLT";
            this.txt_DiemLT.Size = new System.Drawing.Size(83, 20);
            this.txt_DiemLT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Điểm thực hành";
            // 
            // txt_DiemTH
            // 
            this.txt_DiemTH.Location = new System.Drawing.Point(383, 159);
            this.txt_DiemTH.Name = "txt_DiemTH";
            this.txt_DiemTH.Size = new System.Drawing.Size(83, 20);
            this.txt_DiemTH.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(502, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Điểm trung bình";
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Location = new System.Drawing.Point(605, 162);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(83, 20);
            this.txt_DiemTB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "&<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "&>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(34, 226);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(115, 24);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(221, 226);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(115, 24);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(393, 226);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(115, 24);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "&Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(573, 226);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(115, 24);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button8_Click);
            // 
            // grd_SinhVien
            // 
            this.grd_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENSINHVIEN,
            this.GIOITINH,
            this.DIACHI,
            this.NGAYSINH,
            this.DIEMLYTHUYET,
            this.DIEMTHUCHANH,
            this.DIEMTRUNGBINH,
            this.XEPLOAI});
            this.grd_SinhVien.Location = new System.Drawing.Point(1, 266);
            this.grd_SinhVien.Name = "grd_SinhVien";
            this.grd_SinhVien.Size = new System.Drawing.Size(841, 240);
            this.grd_SinhVien.TabIndex = 7;
            // 
            // TENSINHVIEN
            // 
            this.TENSINHVIEN.DataPropertyName = "TENSINHVIEN";
            this.TENSINHVIEN.HeaderText = "Tên sinh viên";
            this.TENSINHVIEN.Name = "TENSINHVIEN";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // DIEMLYTHUYET
            // 
            this.DIEMLYTHUYET.DataPropertyName = "DIEMLYTHUYET";
            this.DIEMLYTHUYET.HeaderText = "Điểm lý thuyết";
            this.DIEMLYTHUYET.Name = "DIEMLYTHUYET";
            // 
            // DIEMTHUCHANH
            // 
            this.DIEMTHUCHANH.DataPropertyName = "DIEMTHUCHANH";
            this.DIEMTHUCHANH.HeaderText = "Điểm thực hành";
            this.DIEMTHUCHANH.Name = "DIEMTHUCHANH";
            // 
            // DIEMTRUNGBINH
            // 
            this.DIEMTRUNGBINH.DataPropertyName = "DIEMTRUNGBINH";
            this.DIEMTRUNGBINH.HeaderText = "Điểm trung bình";
            this.DIEMTRUNGBINH.Name = "DIEMTRUNGBINH";
            // 
            // XEPLOAI
            // 
            this.XEPLOAI.DataPropertyName = "XEPLOAI";
            this.XEPLOAI.HeaderText = "Xếp loại";
            this.XEPLOAI.Name = "XEPLOAI";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(713, 226);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(115, 24);
            this.btn_Upload.TabIndex = 6;
            this.btn_Upload.Text = "&Upload ảnh";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // openFileDialog_Avata
            // 
            this.openFileDialog_Avata.FileName = "openFileDialog_Avata";
            // 
            // picture_Avata
            // 
            this.picture_Avata.Location = new System.Drawing.Point(713, 77);
            this.picture_Avata.Name = "picture_Avata";
            this.picture_Avata.Size = new System.Drawing.Size(115, 143);
            this.picture_Avata.TabIndex = 8;
            this.picture_Avata.TabStop = false;
            // 
            // QuanLySinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 529);
            this.Controls.Add(this.picture_Avata);
            this.Controls.Add(this.grd_SinhVien);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbb_GioiTinh);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DiemTB);
            this.Controls.Add(this.txt_DiemTH);
            this.Controls.Add(this.txt_DiemLT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_XepLoai);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLySinhVienForm";
            this.Text = "QuanLySinhVienForm";
            this.Load += new System.EventHandler(this.QuanLySinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Avata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.TextBox txt_XepLoai;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DiemLT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DiemTH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView grd_SinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSINHVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMLYTHUYET;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHUCHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTRUNGBINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn XEPLOAI;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Avata;
        private System.Windows.Forms.PictureBox picture_Avata;
    }
}