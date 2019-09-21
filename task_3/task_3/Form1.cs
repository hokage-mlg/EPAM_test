using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string string_counter(string[] line)
        {
            int count;
            int n = 1;
            Dictionary<string, int> dic_line = new Dictionary<string, int>();
            int countDic;
            for (int i = 0; i < line.Length; i++)
            {
                count = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[i] == line[j])
                    {
                        count++;
                    }
                }
                if (count <= n)
                {
                    if (!dic_line.ContainsKey(line[i]))
                    {
                        countDic = 0;
                        countDic++;
                        dic_line.Add(line[i], countDic);
                    }
                    else
                    {
                        countDic = dic_line[line[i]];
                        countDic++;
                        dic_line[line[i]] = countDic;
                    }
                }
            }
            foreach (var element in dic_line)
            {
                outputBox.Text += element.Key + Environment.NewLine;
            }
            return outputBox.Text;
        }

        private string string_counter_lib(string line)
        {
            var words = line.Split(new[] {' ', '.', ',', ';', ':', '!', '?'},
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var w in words.Where(x => words.Count(y => y == x) == 1))
            {
                outputBox.Text += w + Environment.NewLine;
            }
            return outputBox.Text;
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string[] line = inputBox.Text.Split(' ');
            string_counter(line);
        }

        private void RunF_button_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            string line = inputBox.Text;
            string_counter_lib(line);
        }
    }
}
