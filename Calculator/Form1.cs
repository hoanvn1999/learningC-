using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SuperCalc : Form
    {
        public SuperCalc()
        {
            InitializeComponent();
        }

        //Ki phap Ba Lan, chuyen Infix sang Postfix

        private static bool IsOperator(string str)
        {
            return Regex.Match(str, @"\+|\-|\*|\/|\%").Success;
        }
        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }

        public static int GetPriority(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }

        public static void FormatExpression(ref string expression)
        {
            expression = expression.Replace(" ", "");
            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\^|\)|\(", delegate (Match match)
            {
                return " " + match.Value + " ";
            });
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
        }

        public static string Infix2Postfix(string infix)
        {
            FormatExpression(ref infix);

            IEnumerable<string> str = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            StringBuilder postfix = new StringBuilder();

            foreach (string s in str)
            {
                if (IsOperand(s))
                    postfix.Append(s).Append(" ");
                else if (s == "(")
                    stack.Push(s);
                else if (s == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        postfix.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// IsOperator(s)
                {
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek()))
                        postfix.Append(stack.Pop()).Append(" ");
                    stack.Push(s);
                }
            }

            while (stack.Count > 0)
                postfix.Append(stack.Pop()).Append(" ");

            return postfix.ToString();
        }

        public static float EvaluatePostfix(string postfix)
        {
            Stack<float> stack = new Stack<float>();
            postfix = postfix.Trim();

            IEnumerable<string> enumer = postfix.Split(' ');

            foreach (string s in enumer)
            {
                if (IsOperand(s))
                    stack.Push(float.Parse(s));
                else
                {
                    float x = stack.Pop();
                    float y = stack.Pop();

                    switch (s)
                    {
                        case "+": y += x; break;
                        case "-": y -= x; break;
                        case "*": y *= x; break;
                        case "/": y /= x; break;
                        case "%": y %= x; break;
                    }
                    stack.Push(y);
                }
            }
            return stack.Pop();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "0";
            txt_screen.Text = "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text = txt_extra_screen.Text.Substring(0, txt_extra_screen.Text.Length-1);
            txt_screen.Text = "";
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            try
            {
                txt_screen.Text = (EvaluatePostfix(Infix2Postfix(txt_extra_screen.Text))).ToString();
                txt_extra_screen.Text = txt_screen.Text;
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "1";
            txt_screen.Text = "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "2";
            txt_screen.Text = "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "3";
            txt_screen.Text = "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "4";
            txt_screen.Text = "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "5";
            txt_screen.Text = "6";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "6";
            txt_screen.Text = "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "7";
            txt_screen.Text = "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "8";
            txt_screen.Text = "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "9";
            txt_screen.Text = "9";
        }

        private void btn_open_bracket_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "(";
            txt_screen.Text = "(";
        }

        private void btn_close_bracket_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += ")";
            txt_screen.Text = ")";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "+";
            txt_screen.Text = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "-";
            txt_screen.Text = "-";
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "*";
            txt_screen.Text = "x";
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text += "/";
            txt_screen.Text = "÷";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_extra_screen.Text = "";
            txt_screen.Text = "";
        }
    }
}
