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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1_kereses = new System.Windows.Forms.Label();
            this.button1_kereses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 665);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1_manualis
            // 
            this.button1_manualis.Location = new System.Drawing.Point(15, 716);
            this.button1_manualis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_manualis.Name = "button1_manualis";
            this.button1_manualis.Size = new System.Drawing.Size(177, 28);
            this.button1_manualis.TabIndex = 1;
            this.button1_manualis.Text = "Manuális";
            this.button1_manualis.UseVisualStyleBackColor = true;
            this.button1_manualis.Click += new System.EventHandler(this.Button1_manualis_Click);
            // 
            // button1_imap
            // 
            this.button1_imap.Location = new System.Drawing.Point(247, 716);
            this.button1_imap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_imap.Name = "button1_imap";
            this.button1_imap.Size = new System.Drawing.Size(177, 28);
            this.button1_imap.TabIndex = 2;
            this.button1_imap.Text = "IMAP";
            this.button1_imap.UseVisualStyleBackColor = true;
            this.button1_imap.Click += new System.EventHandler(this.Button1_imap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1244, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1_kereses
            // 
            this.label1_kereses.AutoSize = true;
            this.label1_kereses.Location = new System.Drawing.Point(1240, 30);
            this.label1_kereses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_kereses.Name = "label1_kereses";
            this.label1_kereses.Size = new System.Drawing.Size(64, 17);
            this.label1_kereses.TabIndex = 4;
            this.label1_kereses.Text = "Keresés:";
            // 
            // button1_kereses
            // 
            this.button1_kereses.Location = new System.Drawing.Point(1363, 121);
            this.button1_kereses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_kereses.Name = "button1_kereses";
            this.button1_kereses.Size = new System.Drawing.Size(100, 28);
            this.button1_kereses.TabIndex = 5;
            this.button1_kereses.Text = "Keresés";
            this.button1_kereses.UseVisualStyleBackColor = true;
            this.button1_kereses.Click += new System.EventHandler(this.Button1_kereses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 759);
            this.Controls.Add(this.button1_kereses);
            this.Controls.Add(this.label1_kereses);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1_imap);
            this.Controls.Add(this.button1_manualis);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1603, 806);
            this.MinimumSize = new System.Drawing.Size(1603, 806);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kezelő";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_manualis;
        private System.Windows.Forms.Button button1_imap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1_kereses;
        private System.Windows.Forms.Button button1_kereses;
    }
}

