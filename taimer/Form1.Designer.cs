namespace taimer
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(105, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 85);
            textBox1.TabIndex = 3;
            textBox1.Text = "00";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(327, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 85);
            textBox2.TabIndex = 4;
            textBox2.Text = "00";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(560, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 85);
            textBox3.TabIndex = 5;
            textBox3.Text = "00";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(189, 323);
            button1.Name = "button1";
            button1.Size = new Size(146, 73);
            button1.TabIndex = 6;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(415, 323);
            button2.Name = "button2";
            button2.Size = new Size(146, 73);
            button2.TabIndex = 7;
            button2.Text = "Сброс";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(237, 141);
            label7.Name = "label7";
            label7.Size = new Size(46, 78);
            label7.TabIndex = 11;
            label7.Text = ":";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(473, 141);
            label4.Name = "label4";
            label4.Size = new Size(46, 78);
            label4.TabIndex = 12;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(560, 78);
            button3.Name = "button3";
            button3.Size = new Size(85, 29);
            button3.TabIndex = 13;
            button3.Text = "^";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(327, 78);
            button4.Name = "button4";
            button4.Size = new Size(85, 29);
            button4.TabIndex = 14;
            button4.Text = "^";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(105, 78);
            button5.Name = "button5";
            button5.Size = new Size(85, 29);
            button5.TabIndex = 15;
            button5.Text = "^";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(105, 254);
            button6.Name = "button6";
            button6.Size = new Size(85, 29);
            button6.TabIndex = 16;
            button6.Text = "˅";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(327, 254);
            button7.Name = "button7";
            button7.Size = new Size(85, 29);
            button7.TabIndex = 17;
            button7.Text = "˅";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(560, 254);
            button8.Name = "button8";
            button8.Size = new Size(85, 29);
            button8.TabIndex = 18;
            button8.Text = "˅";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}