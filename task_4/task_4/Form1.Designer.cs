namespace task_4
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(392, 68);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(158, 22);
            this.inputBox.TabIndex = 1;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(324, 121);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(139, 41);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run!";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.Run_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(351, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(223, 248);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(327, 140);
            this.outputBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task 4. Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputBox;
    }
}

