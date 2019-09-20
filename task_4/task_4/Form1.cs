using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fact(long n)
        {
            if (n >= 0)
            {
                long res = 1;
                for (long i = 2; i <= n; i++)
                    res *= i;
                return outputBox.Text = res.ToString();
            }
            else
                MessageBox.Show("Please enter a positive number.");
            return outputBox.Text = "Error!";
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            long n = long.Parse(inputBox.Text);
            fact(n);
        }
    }
}
