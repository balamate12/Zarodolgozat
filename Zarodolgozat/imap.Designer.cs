﻿namespace Zarodolgozat
{
    partial class imap
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
            this.label1_imap = new System.Windows.Forms.Label();
            this.label2_port = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1_bejelentkezes = new System.Windows.Forms.Button();
            this.textBox2_imap = new System.Windows.Forms.TextBox();
            this.textBox3_user = new System.Windows.Forms.TextBox();
            this.textBox5_password = new System.Windows.Forms.TextBox();
            this.button1_bezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1_port = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1_imap
            // 
            this.label1_imap.AutoSize = true;
            this.label1_imap.Location = new System.Drawing.Point(33, 26);
            this.label1_imap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_imap.Name = "label1_imap";
            this.label1_imap.Size = new System.Drawing.Size(44, 17);
            this.label1_imap.TabIndex = 1;
            this.label1_imap.Text = "IMAP:";
            // 
            // label2_port
            // 
            this.label2_port.AutoSize = true;
            this.label2_port.Location = new System.Drawing.Point(33, 79);
            this.label2_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_port.Name = "label2_port";
            this.label2_port.Size = new System.Drawing.Size(38, 17);
            this.label2_port.TabIndex = 2;
            this.label2_port.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // button1_bejelentkezes
            // 
            this.button1_bejelentkezes.Location = new System.Drawing.Point(36, 236);
            this.button1_bejelentkezes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_bejelentkezes.Name = "button1_bejelentkezes";
            this.button1_bejelentkezes.Size = new System.Drawing.Size(100, 28);
            this.button1_bejelentkezes.TabIndex = 5;
            this.button1_bejelentkezes.Text = "Belépés";
            this.button1_bejelentkezes.UseVisualStyleBackColor = true;
            this.button1_bejelentkezes.Click += new System.EventHandler(this.Button1_bejelentkezes_Click);
            // 
            // textBox2_imap
            // 
            this.textBox2_imap.Location = new System.Drawing.Point(84, 22);
            this.textBox2_imap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2_imap.Name = "textBox2_imap";
            this.textBox2_imap.Size = new System.Drawing.Size(217, 22);
            this.textBox2_imap.TabIndex = 1;
            // 
            // textBox3_user
            // 
            this.textBox3_user.Location = new System.Drawing.Point(84, 129);
            this.textBox3_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3_user.Name = "textBox3_user";
            this.textBox3_user.Size = new System.Drawing.Size(217, 22);
            this.textBox3_user.TabIndex = 3;
            // 
            // textBox5_password
            // 
            this.textBox5_password.Location = new System.Drawing.Point(84, 180);
            this.textBox5_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5_password.Name = "textBox5_password";
            this.textBox5_password.PasswordChar = '*';
            this.textBox5_password.Size = new System.Drawing.Size(217, 22);
            this.textBox5_password.TabIndex = 4;
            // 
            // button1_bezar
            // 
            this.button1_bezar.Location = new System.Drawing.Point(201, 236);
            this.button1_bezar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_bezar.Name = "button1_bezar";
            this.button1_bezar.Size = new System.Drawing.Size(100, 28);
            this.button1_bezar.TabIndex = 6;
            this.button1_bezar.Text = "Bezárás";
            this.button1_bezar.UseVisualStyleBackColor = true;
            this.button1_bezar.Click += new System.EventHandler(this.Button1_bezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // maskedTextBox1_port
            // 
            this.maskedTextBox1_port.Location = new System.Drawing.Point(84, 76);
            this.maskedTextBox1_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox1_port.Mask = "00000";
            this.maskedTextBox1_port.Name = "maskedTextBox1_port";
            this.maskedTextBox1_port.Size = new System.Drawing.Size(217, 22);
            this.maskedTextBox1_port.TabIndex = 2;
            this.maskedTextBox1_port.ValidatingType = typeof(int);
            // 
            // imap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 282);
            this.Controls.Add(this.maskedTextBox1_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_bezar);
            this.Controls.Add(this.textBox5_password);
            this.Controls.Add(this.textBox3_user);
            this.Controls.Add(this.textBox2_imap);
            this.Controls.Add(this.button1_bejelentkezes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2_port);
            this.Controls.Add(this.label1_imap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "imap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imap";
            this.Load += new System.EventHandler(this.Imap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_imap;
        private System.Windows.Forms.Label label2_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1_bejelentkezes;
        private System.Windows.Forms.TextBox textBox2_imap;
        private System.Windows.Forms.TextBox textBox3_user;
        private System.Windows.Forms.TextBox textBox5_password;
        private System.Windows.Forms.Button button1_bezar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_port;
    }
}