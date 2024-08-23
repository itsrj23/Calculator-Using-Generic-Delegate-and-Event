namespace CalculatorApplication
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbOperator = new ComboBox();
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            lblDisplayAnswer = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 140);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 207);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Answer: ";
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(317, 87);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(93, 28);
            cbOperator.TabIndex = 3;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(228, 37);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(182, 27);
            textBoxInput1.TabIndex = 4;
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(228, 140);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(182, 27);
            textBoxInput2.TabIndex = 5;
            // 
            // lblDisplayAnswer
            // 
            lblDisplayAnswer.AutoSize = true;
            lblDisplayAnswer.BackColor = Color.Transparent;
            lblDisplayAnswer.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayAnswer.FlatStyle = FlatStyle.System;
            lblDisplayAnswer.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayAnswer.Location = new Point(263, 198);
            lblDisplayAnswer.Name = "lblDisplayAnswer";
            lblDisplayAnswer.Size = new Size(2, 29);
            lblDisplayAnswer.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(307, 247);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 288);
            Controls.Add(btnCalculate);
            Controls.Add(lblDisplayAnswer);
            Controls.Add(textBoxInput2);
            Controls.Add(textBoxInput1);
            Controls.Add(cbOperator);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculator";
            Text = "frmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbOperator;
        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private Label lblDisplayAnswer;
        private Button btnCalculate;
    }
}
