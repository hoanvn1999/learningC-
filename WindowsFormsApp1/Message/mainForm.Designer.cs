namespace Message
{
    partial class Fo_Message
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
            this.grb_button = new System.Windows.Forms.GroupBox();
            this.rb_AbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.rb_RetryCancel = new System.Windows.Forms.RadioButton();
            this.rb_YesNoCancel = new System.Windows.Forms.RadioButton();
            this.rb_YesNo = new System.Windows.Forms.RadioButton();
            this.rb_OKCancel = new System.Windows.Forms.RadioButton();
            this.rb_OK = new System.Windows.Forms.RadioButton();
            this.gb_MessageBoxIcons = new System.Windows.Forms.GroupBox();
            this.rb_Warning = new System.Windows.Forms.RadioButton();
            this.rb_Stop = new System.Windows.Forms.RadioButton();
            this.rb_Question = new System.Windows.Forms.RadioButton();
            this.rb_None = new System.Windows.Forms.RadioButton();
            this.rb_Information = new System.Windows.Forms.RadioButton();
            this.rb_Hand = new System.Windows.Forms.RadioButton();
            this.rb_Exclamation = new System.Windows.Forms.RadioButton();
            this.rb_Error = new System.Windows.Forms.RadioButton();
            this.rb_Asterisk = new System.Windows.Forms.RadioButton();
            this.btn_CallMesage = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.grb_button.SuspendLayout();
            this.gb_MessageBoxIcons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grb_button
            // 
            this.grb_button.Controls.Add(this.rb_AbortRetryIgnore);
            this.grb_button.Controls.Add(this.rb_RetryCancel);
            this.grb_button.Controls.Add(this.rb_YesNoCancel);
            this.grb_button.Controls.Add(this.rb_YesNo);
            this.grb_button.Controls.Add(this.rb_OKCancel);
            this.grb_button.Controls.Add(this.rb_OK);
            this.grb_button.Location = new System.Drawing.Point(21, 72);
            this.grb_button.Name = "grb_button";
            this.grb_button.Size = new System.Drawing.Size(200, 164);
            this.grb_button.TabIndex = 1;
            this.grb_button.TabStop = false;
            this.grb_button.Text = "Message Box Buttons";
            // 
            // rb_AbortRetryIgnore
            // 
            this.rb_AbortRetryIgnore.AutoSize = true;
            this.rb_AbortRetryIgnore.Location = new System.Drawing.Point(20, 140);
            this.rb_AbortRetryIgnore.Name = "rb_AbortRetryIgnore";
            this.rb_AbortRetryIgnore.Size = new System.Drawing.Size(105, 17);
            this.rb_AbortRetryIgnore.TabIndex = 2;
            this.rb_AbortRetryIgnore.TabStop = true;
            this.rb_AbortRetryIgnore.Text = "AbortRetryIgnore";
            this.rb_AbortRetryIgnore.UseVisualStyleBackColor = true;
            // 
            // rb_RetryCancel
            // 
            this.rb_RetryCancel.AutoSize = true;
            this.rb_RetryCancel.Location = new System.Drawing.Point(20, 117);
            this.rb_RetryCancel.Name = "rb_RetryCancel";
            this.rb_RetryCancel.Size = new System.Drawing.Size(83, 17);
            this.rb_RetryCancel.TabIndex = 2;
            this.rb_RetryCancel.TabStop = true;
            this.rb_RetryCancel.Text = "RetryCancel";
            this.rb_RetryCancel.UseVisualStyleBackColor = true;
            // 
            // rb_YesNoCancel
            // 
            this.rb_YesNoCancel.AutoSize = true;
            this.rb_YesNoCancel.Location = new System.Drawing.Point(20, 94);
            this.rb_YesNoCancel.Name = "rb_YesNoCancel";
            this.rb_YesNoCancel.Size = new System.Drawing.Size(90, 17);
            this.rb_YesNoCancel.TabIndex = 2;
            this.rb_YesNoCancel.TabStop = true;
            this.rb_YesNoCancel.Text = "YesNoCancel";
            this.rb_YesNoCancel.UseVisualStyleBackColor = true;
            // 
            // rb_YesNo
            // 
            this.rb_YesNo.AutoSize = true;
            this.rb_YesNo.Location = new System.Drawing.Point(20, 71);
            this.rb_YesNo.Name = "rb_YesNo";
            this.rb_YesNo.Size = new System.Drawing.Size(57, 17);
            this.rb_YesNo.TabIndex = 2;
            this.rb_YesNo.TabStop = true;
            this.rb_YesNo.Text = "YesNo";
            this.rb_YesNo.UseVisualStyleBackColor = true;
            // 
            // rb_OKCancel
            // 
            this.rb_OKCancel.AutoSize = true;
            this.rb_OKCancel.Location = new System.Drawing.Point(20, 48);
            this.rb_OKCancel.Name = "rb_OKCancel";
            this.rb_OKCancel.Size = new System.Drawing.Size(76, 17);
            this.rb_OKCancel.TabIndex = 1;
            this.rb_OKCancel.TabStop = true;
            this.rb_OKCancel.Text = "OK Cancel";
            this.rb_OKCancel.UseVisualStyleBackColor = true;
            // 
            // rb_OK
            // 
            this.rb_OK.AutoSize = true;
            this.rb_OK.Location = new System.Drawing.Point(20, 25);
            this.rb_OK.Name = "rb_OK";
            this.rb_OK.Size = new System.Drawing.Size(40, 17);
            this.rb_OK.TabIndex = 0;
            this.rb_OK.TabStop = true;
            this.rb_OK.Text = "OK";
            this.rb_OK.UseVisualStyleBackColor = true;
            // 
            // gb_MessageBoxIcons
            // 
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Warning);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Stop);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Question);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_None);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Information);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Hand);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Exclamation);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Error);
            this.gb_MessageBoxIcons.Controls.Add(this.rb_Asterisk);
            this.gb_MessageBoxIcons.Location = new System.Drawing.Point(227, 72);
            this.gb_MessageBoxIcons.Name = "gb_MessageBoxIcons";
            this.gb_MessageBoxIcons.Size = new System.Drawing.Size(200, 234);
            this.gb_MessageBoxIcons.TabIndex = 1;
            this.gb_MessageBoxIcons.TabStop = false;
            this.gb_MessageBoxIcons.Text = "Message Box Icons";
            // 
            // rb_Warning
            // 
            this.rb_Warning.AutoSize = true;
            this.rb_Warning.Location = new System.Drawing.Point(20, 209);
            this.rb_Warning.Name = "rb_Warning";
            this.rb_Warning.Size = new System.Drawing.Size(65, 17);
            this.rb_Warning.TabIndex = 2;
            this.rb_Warning.TabStop = true;
            this.rb_Warning.Text = "Warning";
            this.rb_Warning.UseVisualStyleBackColor = true;
            // 
            // rb_Stop
            // 
            this.rb_Stop.AutoSize = true;
            this.rb_Stop.Location = new System.Drawing.Point(20, 186);
            this.rb_Stop.Name = "rb_Stop";
            this.rb_Stop.Size = new System.Drawing.Size(47, 17);
            this.rb_Stop.TabIndex = 2;
            this.rb_Stop.TabStop = true;
            this.rb_Stop.Text = "Stop";
            this.rb_Stop.UseVisualStyleBackColor = true;
            // 
            // rb_Question
            // 
            this.rb_Question.AutoSize = true;
            this.rb_Question.Location = new System.Drawing.Point(20, 163);
            this.rb_Question.Name = "rb_Question";
            this.rb_Question.Size = new System.Drawing.Size(67, 17);
            this.rb_Question.TabIndex = 2;
            this.rb_Question.TabStop = true;
            this.rb_Question.Text = "Question";
            this.rb_Question.UseVisualStyleBackColor = true;
            // 
            // rb_None
            // 
            this.rb_None.AutoSize = true;
            this.rb_None.Location = new System.Drawing.Point(20, 140);
            this.rb_None.Name = "rb_None";
            this.rb_None.Size = new System.Drawing.Size(51, 17);
            this.rb_None.TabIndex = 2;
            this.rb_None.TabStop = true;
            this.rb_None.Text = "None";
            this.rb_None.UseVisualStyleBackColor = true;
            // 
            // rb_Information
            // 
            this.rb_Information.AutoSize = true;
            this.rb_Information.Location = new System.Drawing.Point(20, 117);
            this.rb_Information.Name = "rb_Information";
            this.rb_Information.Size = new System.Drawing.Size(77, 17);
            this.rb_Information.TabIndex = 2;
            this.rb_Information.TabStop = true;
            this.rb_Information.Text = "Information";
            this.rb_Information.UseVisualStyleBackColor = true;
            // 
            // rb_Hand
            // 
            this.rb_Hand.AutoSize = true;
            this.rb_Hand.Location = new System.Drawing.Point(20, 94);
            this.rb_Hand.Name = "rb_Hand";
            this.rb_Hand.Size = new System.Drawing.Size(48, 17);
            this.rb_Hand.TabIndex = 2;
            this.rb_Hand.TabStop = true;
            this.rb_Hand.Text = "Hard";
            this.rb_Hand.UseVisualStyleBackColor = true;
            // 
            // rb_Exclamation
            // 
            this.rb_Exclamation.AutoSize = true;
            this.rb_Exclamation.Location = new System.Drawing.Point(20, 71);
            this.rb_Exclamation.Name = "rb_Exclamation";
            this.rb_Exclamation.Size = new System.Drawing.Size(82, 17);
            this.rb_Exclamation.TabIndex = 2;
            this.rb_Exclamation.TabStop = true;
            this.rb_Exclamation.Text = "Exclamation";
            this.rb_Exclamation.UseVisualStyleBackColor = true;
            // 
            // rb_Error
            // 
            this.rb_Error.AutoSize = true;
            this.rb_Error.Location = new System.Drawing.Point(20, 48);
            this.rb_Error.Name = "rb_Error";
            this.rb_Error.Size = new System.Drawing.Size(47, 17);
            this.rb_Error.TabIndex = 1;
            this.rb_Error.TabStop = true;
            this.rb_Error.Text = "Error";
            this.rb_Error.UseVisualStyleBackColor = true;
            // 
            // rb_Asterisk
            // 
            this.rb_Asterisk.AutoSize = true;
            this.rb_Asterisk.Location = new System.Drawing.Point(20, 25);
            this.rb_Asterisk.Name = "rb_Asterisk";
            this.rb_Asterisk.Size = new System.Drawing.Size(62, 17);
            this.rb_Asterisk.TabIndex = 0;
            this.rb_Asterisk.TabStop = true;
            this.rb_Asterisk.Text = "Asterisk";
            this.rb_Asterisk.UseVisualStyleBackColor = true;
            // 
            // btn_CallMesage
            // 
            this.btn_CallMesage.Location = new System.Drawing.Point(25, 258);
            this.btn_CallMesage.Name = "btn_CallMesage";
            this.btn_CallMesage.Size = new System.Drawing.Size(92, 40);
            this.btn_CallMesage.TabIndex = 2;
            this.btn_CallMesage.Text = "&Call Message";
            this.btn_CallMesage.UseVisualStyleBackColor = true;
            this.btn_CallMesage.Click += new System.EventHandler(this.btn_CallMesage_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(127, 258);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 40);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Fo_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 320);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_CallMesage);
            this.Controls.Add(this.gb_MessageBoxIcons);
            this.Controls.Add(this.grb_button);
            this.Controls.Add(this.label1);
            this.Name = "Fo_Message";
            this.Text = "mainForm";
            this.grb_button.ResumeLayout(false);
            this.grb_button.PerformLayout();
            this.gb_MessageBoxIcons.ResumeLayout(false);
            this.gb_MessageBoxIcons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_button;
        private System.Windows.Forms.RadioButton rb_AbortRetryIgnore;
        private System.Windows.Forms.RadioButton rb_RetryCancel;
        private System.Windows.Forms.RadioButton rb_YesNoCancel;
        private System.Windows.Forms.RadioButton rb_YesNo;
        private System.Windows.Forms.RadioButton rb_OKCancel;
        private System.Windows.Forms.RadioButton rb_OK;
        private System.Windows.Forms.GroupBox gb_MessageBoxIcons;
        private System.Windows.Forms.RadioButton rb_Warning;
        private System.Windows.Forms.RadioButton rb_Stop;
        private System.Windows.Forms.RadioButton rb_Question;
        private System.Windows.Forms.RadioButton rb_None;
        private System.Windows.Forms.RadioButton rb_Information;
        private System.Windows.Forms.RadioButton rb_Hand;
        private System.Windows.Forms.RadioButton rb_Exclamation;
        private System.Windows.Forms.RadioButton rb_Error;
        private System.Windows.Forms.RadioButton rb_Asterisk;
        private System.Windows.Forms.Button btn_CallMesage;
        private System.Windows.Forms.Button btn_Exit;
    }
}

