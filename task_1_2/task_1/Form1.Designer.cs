namespace task_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dimensionBox = new System.Windows.Forms.TextBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output_arrayBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_arrayBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input array:";
            // 
            // dimensionBox
            // 
            this.dimensionBox.Location = new System.Drawing.Point(144, 41);
            this.dimensionBox.Name = "dimensionBox";
            this.dimensionBox.Size = new System.Drawing.Size(216, 22);
            this.dimensionBox.TabIndex = 1;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(131, 181);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(142, 32);
            this.button_sort.TabIndex = 2;
            this.button_sort.Text = "Sort!";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.Button_sort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(380, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // output_arrayBox
            // 
            this.output_arrayBox.Location = new System.Drawing.Point(171, 291);
            this.output_arrayBox.Multiline = true;
            this.output_arrayBox.Name = "output_arrayBox";
            this.output_arrayBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.output_arrayBox.Size = new System.Drawing.Size(509, 194);
            this.output_arrayBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dimension: ";
            // 
            // input_arrayBox
            // 
            this.input_arrayBox.Location = new System.Drawing.Point(147, 91);
            this.input_arrayBox.Name = "input_arrayBox";
            this.input_arrayBox.Size = new System.Drawing.Size(213, 22);
            this.input_arrayBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Warning! Use \",\" to split.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(463, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number to search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(631, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(165, 22);
            this.searchBox.TabIndex = 9;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(566, 91);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(157, 32);
            this.find_button.TabIndex = 10;
            this.find_button.Text = "Find!";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 519);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_arrayBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output_arrayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.dimensionBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task 1 & 2. Sorting and search.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dimensionBox;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output_arrayBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_arrayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button find_button;
    }
}

