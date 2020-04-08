namespace Zarodolgozat
{
    partial class useradd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_felhasznev = new System.Windows.Forms.TextBox();
            this.textBox2_jelszo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Írjon be egy felhasználónevet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Írjon be egy jelszót:";
            // 
            // textBox1_felhasznev
            // 
            this.textBox1_felhasznev.Location = new System.Drawing.Point(32, 58);
            this.textBox1_felhasznev.Name = "textBox1_felhasznev";
            this.textBox1_felhasznev.Size = new System.Drawing.Size(241, 20);
            this.textBox1_felhasznev.TabIndex = 2;
            // 
            // textBox2_jelszo
            // 
            this.textBox2_jelszo.Location = new System.Drawing.Point(32, 132);
            this.textBox2_jelszo.Name = "textBox2_jelszo";
            this.textBox2_jelszo.PasswordChar = '*';
            this.textBox2_jelszo.Size = new System.Drawing.Size(241, 20);
            this.textBox2_jelszo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // useradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_jelszo);
            this.Controls.Add(this.textBox1_felhasznev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "useradd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasználó hozzáadás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_felhasznev;
        private System.Windows.Forms.TextBox textBox2_jelszo;
        private System.Windows.Forms.Button button1;
    }
}