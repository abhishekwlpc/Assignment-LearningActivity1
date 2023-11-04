using System.ComponentModel;

namespace WinformApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            number1 = new Label();
            number2 = new Label();
            result = new Label();
            textBox1 = new TextBox();
            btnSum = new Button();
            textBox2 = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Location = new Point(117, 96);
            number1.Name = "number1";
            number1.Size = new Size(81, 20);
            number1.TabIndex = 0;
            number1.Text = "Number 1*";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(117, 185);
            number2.Name = "number2";
            number2.Size = new Size(81, 20);
            number2.TabIndex = 1;
            number2.Text = "Number 2*";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(117, 273);
            result.Name = "result";
            result.Size = new Size(49, 20);
            result.TabIndex = 2;
            result.Text = "Result";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "0";
            textBox1.Click += textBox1_Click;
            textBox1.Validating += textBox1_Validating;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(364, 345);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(146, 25);
            btnSum.TabIndex = 6;
            btnSum.Text = "Sum";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "0";
            textBox2.Click += textBox2_Click;
            textBox2.Validating += textBox1_Validating;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(364, 266);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(146, 27);
            txtResult.TabIndex = 7;
            txtResult.Text = "0";
            txtResult.Click += txtResult_Click;
            txtResult.Validating += txtResult_Validating;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnSum);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(result);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Form2";
            Text = "Aggregate Functions - Sum";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Label number1;
        private Label number2;
        private Label result;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtResult;
        private Button btnSum;

    }
}