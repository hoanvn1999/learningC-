using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message
{
    public partial class Fo_Message : Form
    {
        public Fo_Message()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CallMesage_Click(object sender, EventArgs e)
        {
            if (this.rb_OK.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (this.rb_OK.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (this.rb_OK.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (this.rb_OK.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (this.rb_OK.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (this.rb_OK.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (this.rb_OK.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (this.rb_OK.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (this.rb_OK.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (this.rb_OKCancel.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (this.rb_OKCancel.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (this.rb_OKCancel.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (this.rb_OKCancel.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (this.rb_OKCancel.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (this.rb_OKCancel.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            if (this.rb_OKCancel.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (this.rb_OKCancel.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (this.rb_OKCancel.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (this.rb_YesNo.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (this.rb_YesNo.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (this.rb_YesNo.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (this.rb_YesNo.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (this.rb_YesNo.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (this.rb_YesNo.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (this.rb_YesNo.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (this.rb_YesNo.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (this.rb_YesNo.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (this.rb_YesNoCancel.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (this.rb_YesNoCancel.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (this.rb_YesNoCancel.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (this.rb_YesNoCancel.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            if (this.rb_YesNoCancel.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (this.rb_YesNoCancel.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (this.rb_YesNoCancel.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (this.rb_YesNoCancel.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (this.rb_YesNoCancel.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (this.rb_RetryCancel.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            if (this.rb_RetryCancel.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            if (this.rb_RetryCancel.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            if (this.rb_RetryCancel.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            if (this.rb_RetryCancel.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (this.rb_RetryCancel.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            if (this.rb_RetryCancel.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            if (this.rb_RetryCancel.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            if (this.rb_RetryCancel.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Asterisk.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Error.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Exclamation.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Hand.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Information.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_None.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.None);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Question.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Stop.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            if (this.rb_AbortRetryIgnore.Checked && this.rb_Warning.Checked)
                MessageBox.Show("Hello world!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            subForm a = new subForm(/*this*/);
            a.Show();
            this.Visible=false;
        }
    }
}
