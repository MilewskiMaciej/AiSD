using sorting_application.Properties;

namespace sorting_application
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkViolet;
            button1.Location = new Point(157, 56);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 0;
            button1.Text = "DODAJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkViolet;
            button2.Location = new Point(89, 409);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 1;
            button2.Text = "BUBBLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkViolet;
            button3.Location = new Point(195, 409);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 2;
            button3.Text = "INSERTION";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkViolet;
            button4.Location = new Point(301, 409);
            button4.Name = "button4";
            button4.Size = new Size(100, 29);
            button4.TabIndex = 3;
            button4.Text = "MERGE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkViolet;
            button5.Location = new Point(407, 409);
            button5.Name = "button5";
            button5.Size = new Size(100, 29);
            button5.TabIndex = 4;
            button5.Text = "QUICK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkViolet;
            button6.Location = new Point(513, 409);
            button6.Name = "button6";
            button6.Size = new Size(100, 29);
            button6.TabIndex = 5;
            button6.Text = "SELECTION";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkViolet;
            button7.Location = new Point(619, 409);
            button7.Name = "button7";
            button7.Size = new Size(100, 29);
            button7.TabIndex = 6;
            button7.Text = "COUNTING";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(238, 22);
            label1.TabIndex = 7;
            label1.Text = "Tu pojawi się posortowana tablica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 8;
            label2.Text = "Podaj liczbę:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(250, 0);
            label3.Name = "label3";
            label3.Size = new Size(271, 40);
            label3.TabIndex = 9;
            label3.Text = "POSORTUJ TABLICĘ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(159, 22);
            label4.TabIndex = 10;
            label4.Text = "Tu pojawi się stan listy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Snow;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(12, 157);
            label5.Name = "label5";
            label5.Size = new Size(225, 22);
            label5.TabIndex = 11;
            label5.Text = "Tu pojawi się czas posortowania";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 27);
            textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}
