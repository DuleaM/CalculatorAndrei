namespace Calculator
{
    partial class Form1
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
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            eight = new Button();
            seven = new Button();
            six = new Button();
            nine = new Button();
            calc = new TextBox();
            zero = new Button();
            plus = new Button();
            minus = new Button();
            equals = new Button();
            SuspendLayout();
            // 
            // one
            // 
            one.Location = new Point(26, 43);
            one.Margin = new Padding(3, 2, 3, 2);
            one.Name = "one";
            one.Size = new Size(99, 68);
            one.TabIndex = 0;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // two
            // 
            two.Location = new Point(131, 43);
            two.Margin = new Padding(3, 2, 3, 2);
            two.Name = "two";
            two.Size = new Size(99, 68);
            two.TabIndex = 1;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.Location = new Point(236, 43);
            three.Margin = new Padding(3, 2, 3, 2);
            three.Name = "three";
            three.Size = new Size(99, 68);
            three.TabIndex = 2;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // four
            // 
            four.Location = new Point(26, 115);
            four.Margin = new Padding(3, 2, 3, 2);
            four.Name = "four";
            four.Size = new Size(99, 68);
            four.TabIndex = 3;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // five
            // 
            five.Location = new Point(131, 115);
            five.Margin = new Padding(3, 2, 3, 2);
            five.Name = "five";
            five.Size = new Size(99, 68);
            five.TabIndex = 4;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // eight
            // 
            eight.Location = new Point(131, 187);
            eight.Margin = new Padding(3, 2, 3, 2);
            eight.Name = "eight";
            eight.Size = new Size(99, 68);
            eight.TabIndex = 5;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Location = new Point(26, 187);
            seven.Margin = new Padding(3, 2, 3, 2);
            seven.Name = "seven";
            seven.Size = new Size(99, 68);
            seven.TabIndex = 6;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // six
            // 
            six.Location = new Point(236, 115);
            six.Margin = new Padding(3, 2, 3, 2);
            six.Name = "six";
            six.Size = new Size(99, 68);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // nine
            // 
            nine.Location = new Point(236, 187);
            nine.Margin = new Padding(3, 2, 3, 2);
            nine.Name = "nine";
            nine.Size = new Size(99, 68);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // calc
            // 
            calc.Location = new Point(362, 43);
            calc.Name = "calc";
            calc.Size = new Size(195, 23);
            calc.TabIndex = 10;
            // 
            // zero
            // 
            zero.Location = new Point(236, 259);
            zero.Margin = new Padding(3, 2, 3, 2);
            zero.Name = "zero";
            zero.Size = new Size(99, 68);
            zero.TabIndex = 11;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // plus
            // 
            plus.Location = new Point(131, 259);
            plus.Margin = new Padding(3, 2, 3, 2);
            plus.Name = "plus";
            plus.Size = new Size(99, 68);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Location = new Point(26, 259);
            minus.Margin = new Padding(3, 2, 3, 2);
            minus.Name = "minus";
            minus.Size = new Size(99, 68);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // equals
            // 
            equals.Location = new Point(341, 259);
            equals.Margin = new Padding(3, 2, 3, 2);
            equals.Name = "equals";
            equals.Size = new Size(99, 68);
            equals.TabIndex = 14;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(equals);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(zero);
            Controls.Add(calc);
            Controls.Add(nine);
            Controls.Add(six);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button eight;
        private Button seven;
        private Button six;
        private Button nine;
        private TextBox calc;
        private Button zero;
        private Button plus;
        private Button minus;
        private Button equals;
    }
}