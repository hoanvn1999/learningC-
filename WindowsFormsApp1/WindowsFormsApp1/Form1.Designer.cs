namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.signal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_a_mau = new System.Windows.Forms.TextBox();
            this.tb_b_mau = new System.Windows.Forms.TextBox();
            this.tb_c_mau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(12, 35);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(43, 20);
            this.tb_a.TabIndex = 0;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(104, 35);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(43, 20);
            this.tb_b.TabIndex = 0;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(180, 34);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(43, 20);
            this.tb_c.TabIndex = 0;
            // 
            // signal
            // 
            this.signal.FormattingEnabled = true;
            this.signal.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.signal.Location = new System.Drawing.Point(61, 48);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(37, 21);
            this.signal.TabIndex = 1;
            this.signal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // tb_a_mau
            // 
            this.tb_a_mau.Location = new System.Drawing.Point(12, 61);
            this.tb_a_mau.Name = "tb_a_mau";
            this.tb_a_mau.Size = new System.Drawing.Size(43, 20);
            this.tb_a_mau.TabIndex = 0;
            // 
            // tb_b_mau
            // 
            this.tb_b_mau.Location = new System.Drawing.Point(104, 61);
            this.tb_b_mau.Name = "tb_b_mau";
            this.tb_b_mau.Size = new System.Drawing.Size(43, 20);
            this.tb_b_mau.TabIndex = 0;
            // 
            // tb_c_mau
            // 
            this.tb_c_mau.Location = new System.Drawing.Point(180, 60);
            this.tb_c_mau.Name = "tb_c_mau";
            this.tb_c_mau.Size = new System.Drawing.Size(43, 20);
            this.tb_c_mau.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.tb_c_mau);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_b_mau);
            this.Controls.Add(this.tb_a_mau);
            this.Controls.Add(this.tb_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.ComboBox signal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_a_mau;
        private System.Windows.Forms.TextBox tb_b_mau;
        private System.Windows.Forms.TextBox tb_c_mau;
    }
}

