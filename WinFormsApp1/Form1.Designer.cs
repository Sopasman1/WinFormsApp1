namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            Carrer = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 261);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(124, 23);
            textBox6.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(257, 261);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(138, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(641, 390);
            button1.Name = "button1";
            button1.Size = new Size(132, 34);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(244, 25);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 9;
            label2.Text = "Paternal last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(452, 25);
            label3.Name = "label3";
            label3.Size = new Size(129, 17);
            label3.TabIndex = 10;
            label3.Text = "Maternal last name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(244, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(278, 130);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 12;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 130);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 13;
            label5.Text = "Enrollment";
            // 
            // Carrer
            // 
            Carrer.AutoSize = true;
            Carrer.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Carrer.Location = new Point(51, 243);
            Carrer.Name = "Carrer";
            Carrer.Size = new Size(48, 17);
            Carrer.TabIndex = 14;
            Carrer.Text = "Carrer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Carrer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label Carrer;
    }
}