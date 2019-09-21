using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class BracketsCheck
        {
            private readonly string opening = "([{";
            private readonly string closing = ")]}";
            private bool cantBeBlncd;
            private Stack<int> opened = new Stack<int>();
            public bool Balanced => !cantBeBlncd && !opened.Any();

            public void Put(char ch)
            {
                if (cantBeBlncd) return;
                int index = opening.IndexOf(ch);
                if (index != -1)
                {
                    opened.Push(index);
                    return;
                }
                index = closing.IndexOf(ch);
                if (index != -1)
                {
                    if (!opened.Any() || opened.Peek() != index)
                    {
                        cantBeBlncd = true;
                        opened.Clear();
                        opened.TrimExcess();
                        return;
                    }
                    opened.Pop();
                    return;
                }
            }
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string s = inputBox.Text;
            var checker = new BracketsCheck();
            foreach (var ch in s)
                checker.Put(ch);
            outputBox.Text = Convert.ToString(checker.Balanced);
        }
    }
}
