﻿namespace julka2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            komputerbutton = new Button();
            monitorbutton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // komputerbutton
            // 
            komputerbutton.Location = new Point(101, 69);
            komputerbutton.Name = "komputerbutton";
            komputerbutton.Size = new Size(143, 87);
            komputerbutton.TabIndex = 0;
            komputerbutton.Text = "Komputer";
            komputerbutton.UseVisualStyleBackColor = true;
            komputerbutton.Click += button1_Click;
            // 
            // monitorbutton
            // 
            monitorbutton.Location = new Point(276, 69);
            monitorbutton.Name = "monitorbutton";
            monitorbutton.Size = new Size(141, 87);
            monitorbutton.TabIndex = 1;
            monitorbutton.Text = "Monitor";
            monitorbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(563, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(583, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Cena w zł";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(521, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 175);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(monitorbutton);
            Controls.Add(komputerbutton);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button komputerbutton;
        private Button monitorbutton;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}