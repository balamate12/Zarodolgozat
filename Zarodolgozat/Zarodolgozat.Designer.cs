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
            this.SuspendLayout();
            // 
            // button1_manualis
            // 
            this.button1_manualis.Location = new System.Drawing.Point(98, 148);
            this.button1_manualis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1_manualis.Name = "button1_manualis";
            this.button1_manualis.Size = new System.Drawing.Size(133, 23);
            this.button1_manualis.TabIndex = 2;
            this.button1_manualis.Text = "Partner feltöltése";
            this.button1_manualis.UseVisualStyleBackColor = true;
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
            this.button1_partnerlista.Click += new System.EventHandler(this.Button1_partnerlista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.button1_partnerlista);
            this.Controls.Add(this.button1_imap);
            this.Controls.Add(this.button1_manualis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelő";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_manualis;
        private System.Windows.Forms.Button button1_imap;
        private System.Windows.Forms.Button button1_partnerlista;
    }
}

