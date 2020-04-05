namespace Zarodolgozat
{
    partial class Form1
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
            this.button1_manualis = new System.Windows.Forms.Button();
            this.button1_imap = new System.Windows.Forms.Button();
            this.button1_partnerlista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1_belepes = new System.Windows.Forms.Button();
            this.button1_kilepes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_manualis
            // 
            this.button1_manualis.Location = new System.Drawing.Point(98, 148);
            this.button1_manualis.Margin = new System.Windows.Forms.Padding(2);
            this.button1_manualis.Name = "button1_manualis";
            this.button1_manualis.Size = new System.Drawing.Size(133, 23);
            this.button1_manualis.TabIndex = 2;
            this.button1_manualis.Text = "Partner feltöltése";
            this.button1_manualis.UseVisualStyleBackColor = true;
            this.button1_manualis.Visible = false;
            this.button1_manualis.Click += new System.EventHandler(this.Button1_manualis_Click);
            // 
            // button1_imap
            // 
            this.button1_imap.Location = new System.Drawing.Point(98, 201);
            this.button1_imap.Name = "button1_imap";
            this.button1_imap.Size = new System.Drawing.Size(133, 23);
            this.button1_imap.TabIndex = 3;
            this.button1_imap.Text = "Email megrendelés";
            this.button1_imap.UseVisualStyleBackColor = true;
            this.button1_imap.Visible = false;
            this.button1_imap.Click += new System.EventHandler(this.Button1_imap_Click);
            // 
            // button1_partnerlista
            // 
            this.button1_partnerlista.CausesValidation = false;
            this.button1_partnerlista.Location = new System.Drawing.Point(98, 96);
            this.button1_partnerlista.Name = "button1_partnerlista";
            this.button1_partnerlista.Size = new System.Drawing.Size(133, 23);
            this.button1_partnerlista.TabIndex = 1;
            this.button1_partnerlista.Text = "Partnerlista";
            this.button1_partnerlista.UseVisualStyleBackColor = true;
            this.button1_partnerlista.Visible = false;
            this.button1_partnerlista.Click += new System.EventHandler(this.Button1_partnerlista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_belepes);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belépés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1_belepes
            // 
            this.button1_belepes.Location = new System.Drawing.Point(108, 218);
            this.button1_belepes.Name = "button1_belepes";
            this.button1_belepes.Size = new System.Drawing.Size(83, 21);
            this.button1_belepes.TabIndex = 4;
            this.button1_belepes.Text = "Belépés";
            this.button1_belepes.UseVisualStyleBackColor = true;
            this.button1_belepes.Click += new System.EventHandler(this.button1_belepes_Click);
            // 
            // button1_kilepes
            // 
            this.button1_kilepes.Location = new System.Drawing.Point(98, 253);
            this.button1_kilepes.Name = "button1_kilepes";
            this.button1_kilepes.Size = new System.Drawing.Size(133, 23);
            this.button1_kilepes.TabIndex = 5;
            this.button1_kilepes.Text = "Kilépés";
            this.button1_kilepes.UseVisualStyleBackColor = true;
            this.button1_kilepes.Click += new System.EventHandler(this.button1_kilepes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1_partnerlista);
            this.Controls.Add(this.button1_imap);
            this.Controls.Add(this.button1_manualis);
            this.Controls.Add(this.button1_kilepes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelő";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_manualis;
        private System.Windows.Forms.Button button1_imap;
        private System.Windows.Forms.Button button1_partnerlista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1_belepes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_kilepes;
    }
}

