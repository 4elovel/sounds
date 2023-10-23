namespace sounds
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(249, 149);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(522, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(335, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 210);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 213);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 5;
            label2.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 213);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 6;
            label3.Text = "ms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 210);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 7;
            label4.Text = "ms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 182);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 8;
            label5.Text = "set time interval";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 251);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 9;
            label6.Text = "set frequency";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 287);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 15;
            label7.Text = "Hz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 290);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 14;
            label8.Text = "Hz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 290);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 13;
            label9.Text = "to";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(107, 287);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 12;
            label10.Text = "from";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 23);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}