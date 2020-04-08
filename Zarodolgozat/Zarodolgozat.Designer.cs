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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_manualis = new System.Windows.Forms.Button();
            this.button1_imap = new System.Windows.Forms.Button();
            this.button1_partnerlista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1kilep = new System.Windows.Forms.Button();
            this.button1_belepes = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_kilepes = new System.Windows.Forms.Button();
            this.button1_felhaszhozzaad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1kilep);
            this.groupBox1.Controls.Add(this.button1_belepes);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belépés";
            // 
            // button1kilep
            // 
            this.button1kilep.Location = new System.Drawing.Point(180, 287);
            this.button1kilep.Name = "button1kilep";
            this.button1kilep.Size = new System.Drawing.Size(83, 21);
            this.button1kilep.TabIndex = 5;
            this.button1kilep.Text = "Kilépés";
            this.button1kilep.UseVisualStyleBackColor = true;
            this.button1kilep.Click += new System.EventHandler(this.Button1kilep_Click);
            // 
            // button1_belepes
            // 
            this.button1_belepes.Location = new System.Drawing.Point(43, 289);
            this.button1_belepes.Name = "button1_belepes";
            this.button1_belepes.Size = new System.Drawing.Size(83, 21);
            this.button1_belepes.TabIndex = 4;
            this.button1_belepes.Text = "Belépés";
            this.button1_belepes.UseVisualStyleBackColor = true;
            this.button1_belepes.Click += new System.EventHandler(this.button1_belepes_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // button1_kilepes
            // 
            this.button1_kilepes.Location = new System.Drawing.Point(98, 299);
            this.button1_kilepes.Name = "button1_kilepes";
            this.button1_kilepes.Size = new System.Drawing.Size(133, 23);
            this.button1_kilepes.TabIndex = 5;
            this.button1_kilepes.Text = "Kilépés";
            this.button1_kilepes.UseVisualStyleBackColor = true;
            this.button1_kilepes.Click += new System.EventHandler(this.button1_kilepes_Click);
            // 
            // button1_felhaszhozzaad
            // 
            this.button1_felhaszhozzaad.Location = new System.Drawing.Point(98, 251);
            this.button1_felhaszhozzaad.Name = "button1_felhaszhozzaad";
            this.button1_felhaszhozzaad.Size = new System.Drawing.Size(133, 23);
            this.button1_felhaszhozzaad.TabIndex = 6;
            this.button1_felhaszhozzaad.Text = "Felhasználó hozzáadás";
            this.button1_felhaszhozzaad.UseVisualStyleBackColor = true;
            this.button1_felhaszhozzaad.Click += new System.EventHandler(this.Button1_felhaszhozzaad_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 83);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 62);
            this.label4.TabIndex = 7;
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
            this.Controls.Add(this.button1_felhaszhozzaad);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelő";
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
        private System.Windows.Forms.Button button1_felhaszhozzaad;
        private System.Windows.Forms.Button button1kilep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

