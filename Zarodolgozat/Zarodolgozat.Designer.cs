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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_manualis = new System.Windows.Forms.Button();
            this.button1_imap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1_manualis
            // 
            this.button1_manualis.Location = new System.Drawing.Point(26, 580);
            this.button1_manualis.Margin = new System.Windows.Forms.Padding(2);
            this.button1_manualis.Name = "button1_manualis";
            this.button1_manualis.Size = new System.Drawing.Size(66, 19);
            this.button1_manualis.TabIndex = 1;
            this.button1_manualis.Text = "Manuális";
            this.button1_manualis.UseVisualStyleBackColor = true;
            this.button1_manualis.Click += new System.EventHandler(this.Button1_manualis_Click);
            // 
            // button1_imap
            // 
            this.button1_imap.Location = new System.Drawing.Point(128, 576);
            this.button1_imap.Name = "button1_imap";
            this.button1_imap.Size = new System.Drawing.Size(133, 23);
            this.button1_imap.TabIndex = 2;
            this.button1_imap.Text = "IMAP";
            this.button1_imap.UseVisualStyleBackColor = true;
            this.button1_imap.Click += new System.EventHandler(this.Button1_imap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 625);
            this.Controls.Add(this.button1_imap);
            this.Controls.Add(this.button1_manualis);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kezelő";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_manualis;
        private System.Windows.Forms.Button button1_imap;
    }
}

