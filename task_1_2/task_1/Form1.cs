using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] nums;

        private int[] Sort_array(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }

        private string Search_in_array(int num)
        {
            bool flag = false;
            foreach (int x in nums)
            {
                if (x == num)
                    flag = true;
            }
            if (flag == true)
            {
                return output_arrayBox.Text += "Number " + Convert.ToString(num)
                    + " is in the array." + Environment.NewLine;
            }
            else
                return output_arrayBox.Text += "Number " + Convert.ToString(num)
                    + " is not contained in the array." + Environment.NewLine;
        }

        private void Button_sort_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(dimensionBox.Text);
            string[] sNums = input_arrayBox.Text.Split(',');
            if (dim > sNums.Length)
            {
                MessageBox.Show("The length of the array does not match the entered! " +
                    "\n Please correct and try again.");
                return;
            }
            nums = new int[dim];
            for (int i = 0; i < dim; i++)
                nums[i] = int.Parse(sNums[i]);
            for (int i = 0; i < dim; i++)
            {
                Sort_array(nums);
                output_arrayBox.Text += "Array[" + Convert.ToString(i + 1) + "] = "
                                     + Convert.ToString(nums[i]) + Environment.NewLine;
            }
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            int num = int.Parse(searchBox.Text);
            Search_in_array(num);
        }
    }
}
