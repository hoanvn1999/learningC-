namespace Quan_ly_NV
{
    partial class Phong_ban
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.maphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentruongphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_tentruongphong = new System.Windows.Forms.TextBox();
            this.textBox_tenphongban = new System.Windows.Forms.TextBox();
            this.textBox_maphongban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_cap_nhap = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "PHÒNG BAN";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongban,
            this.tenphongban,
            this.tentruongphong});
            this.dataGridView.Location = new System.Drawing.Point(113, 211);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(594, 150);
            this.dataGridView.TabIndex = 22;
            // 
            // maphongban
            // 
            this.maphongban.DataPropertyName = "maphongban";
            this.maphongban.HeaderText = "Mã Phòng Ban";
            this.maphongban.Name = "maphongban";
            // 
            // tenphongban
            // 
            this.tenphongban.DataPropertyName = "tenphongban";
            this.tenphongban.HeaderText = "Tên Phòng Ban";
            this.tenphongban.Name = "tenphongban";
            // 
            // tentruongphong
            // 
            this.tentruongphong.DataPropertyName = "tentruongphong";
            this.tentruongphong.HeaderText = "Tên Trưởng Phòng";
            this.tentruongphong.Name = "tentruongphong";
            // 
            // textBox_tentruongphong
            // 
            this.textBox_tentruongphong.Location = new System.Drawing.Point(250, 151);
            this.textBox_tentruongphong.Name = "textBox_tentruongphong";
            this.textBox_tentruongphong.Size = new System.Drawing.Size(188, 20);
            this.textBox_tentruongphong.TabIndex = 21;
            // 
            // textBox_tenphongban
            // 
            this.textBox_tenphongban.Location = new System.Drawing.Point(541, 92);
            this.textBox_tenphongban.Name = "textBox_tenphongban";
            this.textBox_tenphongban.Size = new System.Drawing.Size(166, 20);
            this.textBox_tenphongban.TabIndex = 20;
            // 
            // textBox_maphongban
            // 
            this.textBox_maphongban.Location = new System.Drawing.Point(230, 92);
            this.textBox_maphongban.Name = "textBox_maphongban";
            this.textBox_maphongban.Size = new System.Drawing.Size(126, 20);
            this.textBox_maphongban.TabIndex = 19;
            this.textBox_maphongban.TextChanged += new System.EventHandler(this.textBox_maphongban_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên trưởng phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã phòng ban";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(630, 389);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(88, 33);
            this.button_exit.TabIndex = 32;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(452, 389);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(88, 33);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_cap_nhap
            // 
            this.button_cap_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cap_nhap.Location = new System.Drawing.Point(279, 389);
            this.button_cap_nhap.Name = "button_cap_nhap";
            this.button_cap_nhap.Size = new System.Drawing.Size(88, 33);
            this.button_cap_nhap.TabIndex = 30;
            this.button_cap_nhap.Text = "Thêm";
            this.button_cap_nhap.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(109, 389);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 33);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "Sửa";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // Phong_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_cap_nhap);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox_tentruongphong);
            this.Controls.Add(this.textBox_tenphongban);
            this.Controls.Add(this.textBox_maphongban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Phong_ban";
            this.Text = "Phong_ban";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_tentruongphong;
        private System.Windows.Forms.TextBox textBox_tenphongban;
        private System.Windows.Forms.TextBox textBox_maphongban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_cap_nhap;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentruongphong;
    }
}