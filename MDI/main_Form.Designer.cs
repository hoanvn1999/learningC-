namespace MDI
{
    partial class main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSubFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFormToolStripMenuItem
            // 
            this.openFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubFormToolStripMenuItem});
            this.openFormToolStripMenuItem.Name = "openFormToolStripMenuItem";
            this.openFormToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.openFormToolStripMenuItem.Text = "Open Form";
            this.openFormToolStripMenuItem.Click += new System.EventHandler(this.openFormToolStripMenuItem_Click);
            // 
            // openSubFormToolStripMenuItem
            // 
            this.openSubFormToolStripMenuItem.Name = "openSubFormToolStripMenuItem";
            this.openSubFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSubFormToolStripMenuItem.Text = "Open sub form";
            this.openSubFormToolStripMenuItem.Click += new System.EventHandler(this.openSubFormToolStripMenuItem_Click);
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 272);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_Form";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSubFormToolStripMenuItem;
    }
}

