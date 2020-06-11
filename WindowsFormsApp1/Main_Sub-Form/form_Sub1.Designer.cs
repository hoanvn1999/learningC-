namespace Main_Sub_Form
{
    partial class form_Sub1
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
            this.btn_Form_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sub Form 1";
            // 
            // btn_Form_1
            // 
            this.btn_Form_1.Location = new System.Drawing.Point(91, 96);
            this.btn_Form_1.Name = "btn_Form_1";
            this.btn_Form_1.Size = new System.Drawing.Size(156, 23);
            this.btn_Form_1.TabIndex = 3;
            this.btn_Form_1.Text = "Open main form";
            this.btn_Form_1.UseVisualStyleBackColor = true;
            this.btn_Form_1.Click += new System.EventHandler(this.btn_Form_1_Click);
            // 
            // form_Sub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 170);
            this.Controls.Add(this.btn_Form_1);
            this.Controls.Add(this.label1);
            this.Name = "form_Sub1";
            this.Text = "form_Sub1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Form_1;
    }
}