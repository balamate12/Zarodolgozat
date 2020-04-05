namespace Zarodolgozat
{
    partial class plista
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_kereses = new System.Windows.Forms.Button();
            this.textBox2_eloneve = new System.Windows.Forms.TextBox();
            this.textBox3_szulneve = new System.Windows.Forms.TextBox();
            this.textBox4_szulhely = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox1_internetcsomag = new System.Windows.Forms.ListBox();
            this.maskedTextBox1_telefonszam = new System.Windows.Forms.MaskedTextBox();
            this.textBox3_anyjaszulneve = new System.Windows.Forms.TextBox();
            this.textBox4_szemelyiszam = new System.Windows.Forms.TextBox();
            this.textBox5_telepitesicim = new System.Windows.Forms.TextBox();
            this.textbox6_postazasicim = new System.Windows.Forms.TextBox();
            this.textBox7_email = new System.Windows.Forms.TextBox();
            this.textBox8_megjegyzes = new System.Windows.Forms.TextBox();
            this.button1_importcsv = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1_modositas = new System.Windows.Forms.Button();
            this.dateTimePicker1_szulido = new System.Windows.Forms.DateTimePicker();
            this.listBox1_fizetesimod = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(317, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(563, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1_kereses
            // 
            this.button1_kereses.Location = new System.Drawing.Point(1042, 22);
            this.button1_kereses.Name = "button1_kereses";
            this.button1_kereses.Size = new System.Drawing.Size(75, 23);
            this.button1_kereses.TabIndex = 3;
            this.button1_kereses.Text = "Keresés";
            this.button1_kereses.UseVisualStyleBackColor = true;
            this.button1_kereses.Click += new System.EventHandler(this.Button1_kereses_Click_1);
            // 
            // textBox2_eloneve
            // 
            this.textBox2_eloneve.Location = new System.Drawing.Point(462, 77);
            this.textBox2_eloneve.Name = "textBox2_eloneve";
            this.textBox2_eloneve.Size = new System.Drawing.Size(220, 20);
            this.textBox2_eloneve.TabIndex = 4;
            // 
            // textBox3_szulneve
            // 
            this.textBox3_szulneve.Location = new System.Drawing.Point(462, 116);
            this.textBox3_szulneve.Name = "textBox3_szulneve";
            this.textBox3_szulneve.Size = new System.Drawing.Size(220, 20);
            this.textBox3_szulneve.TabIndex = 5;
            // 
            // textBox4_szulhely
            // 
            this.textBox4_szulhely.Location = new System.Drawing.Point(462, 151);
            this.textBox4_szulhely.Name = "textBox4_szulhely";
            this.textBox4_szulhely.Size = new System.Drawing.Size(220, 20);
            this.textBox4_szulhely.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Előfizető neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Születési neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Születési helye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Születési ideje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anyja születési neve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Személyi szám:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telepítési cím:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postázási cím:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(714, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefonszám:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(714, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(714, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Internetcsomag:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(714, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fizetésimód:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Megjegyzés:";
            // 
            // listBox1_internetcsomag
            // 
            this.listBox1_internetcsomag.FormattingEnabled = true;
            this.listBox1_internetcsomag.Items.AddRange(new object[] {
            "8",
            "15",
            "30",
            "60"});
            this.listBox1_internetcsomag.Location = new System.Drawing.Point(805, 221);
            this.listBox1_internetcsomag.Name = "listBox1_internetcsomag";
            this.listBox1_internetcsomag.Size = new System.Drawing.Size(220, 17);
            this.listBox1_internetcsomag.TabIndex = 20;
            // 
            // maskedTextBox1_telefonszam
            // 
            this.maskedTextBox1_telefonszam.Location = new System.Drawing.Point(805, 148);
            this.maskedTextBox1_telefonszam.Name = "maskedTextBox1_telefonszam";
            this.maskedTextBox1_telefonszam.Size = new System.Drawing.Size(220, 20);
            this.maskedTextBox1_telefonszam.TabIndex = 22;
            // 
            // textBox3_anyjaszulneve
            // 
            this.textBox3_anyjaszulneve.Location = new System.Drawing.Point(462, 221);
            this.textBox3_anyjaszulneve.Name = "textBox3_anyjaszulneve";
            this.textBox3_anyjaszulneve.Size = new System.Drawing.Size(220, 20);
            this.textBox3_anyjaszulneve.TabIndex = 24;
            // 
            // textBox4_szemelyiszam
            // 
            this.textBox4_szemelyiszam.Location = new System.Drawing.Point(462, 264);
            this.textBox4_szemelyiszam.Name = "textBox4_szemelyiszam";
            this.textBox4_szemelyiszam.Size = new System.Drawing.Size(220, 20);
            this.textBox4_szemelyiszam.TabIndex = 25;
            // 
            // textBox5_telepitesicim
            // 
            this.textBox5_telepitesicim.Location = new System.Drawing.Point(805, 77);
            this.textBox5_telepitesicim.Name = "textBox5_telepitesicim";
            this.textBox5_telepitesicim.Size = new System.Drawing.Size(220, 20);
            this.textBox5_telepitesicim.TabIndex = 26;
            // 
            // textbox6_postazasicim
            // 
            this.textbox6_postazasicim.Location = new System.Drawing.Point(805, 116);
            this.textbox6_postazasicim.Name = "textbox6_postazasicim";
            this.textbox6_postazasicim.Size = new System.Drawing.Size(220, 20);
            this.textbox6_postazasicim.TabIndex = 27;
            // 
            // textBox7_email
            // 
            this.textBox7_email.Location = new System.Drawing.Point(805, 180);
            this.textBox7_email.Name = "textBox7_email";
            this.textBox7_email.Size = new System.Drawing.Size(220, 20);
            this.textBox7_email.TabIndex = 28;
            // 
            // textBox8_megjegyzes
            // 
            this.textBox8_megjegyzes.Location = new System.Drawing.Point(462, 310);
            this.textBox8_megjegyzes.Multiline = true;
            this.textBox8_megjegyzes.Name = "textBox8_megjegyzes";
            this.textBox8_megjegyzes.Size = new System.Drawing.Size(563, 61);
            this.textBox8_megjegyzes.TabIndex = 29;
            // 
            // button1_importcsv
            // 
            this.button1_importcsv.Location = new System.Drawing.Point(1042, 263);
            this.button1_importcsv.Name = "button1_importcsv";
            this.button1_importcsv.Size = new System.Drawing.Size(75, 23);
            this.button1_importcsv.TabIndex = 30;
            this.button1_importcsv.Text = "Import CSV";
            this.button1_importcsv.UseVisualStyleBackColor = true;
            this.button1_importcsv.Click += new System.EventHandler(this.button1_importcsv_Click);
            // 
            // button1_modositas
            // 
            this.button1_modositas.Location = new System.Drawing.Point(1042, 328);
            this.button1_modositas.Name = "button1_modositas";
            this.button1_modositas.Size = new System.Drawing.Size(75, 23);
            this.button1_modositas.TabIndex = 31;
            this.button1_modositas.Text = "Módosítás";
            this.button1_modositas.UseVisualStyleBackColor = true;
            this.button1_modositas.Click += new System.EventHandler(this.button1_modositas_Click);
            // 
            // dateTimePicker1_szulido
            // 
            this.dateTimePicker1_szulido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_szulido.Location = new System.Drawing.Point(462, 187);
            this.dateTimePicker1_szulido.Name = "dateTimePicker1_szulido";
            this.dateTimePicker1_szulido.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1_szulido.TabIndex = 32;
            // 
            // listBox1_fizetesimod
            // 
            this.listBox1_fizetesimod.FormattingEnabled = true;
            this.listBox1_fizetesimod.Items.AddRange(new object[] {
            "Csekk",
            "Banki átutalás",
            "Elektronikus számla"});
            this.listBox1_fizetesimod.Location = new System.Drawing.Point(805, 264);
            this.listBox1_fizetesimod.Name = "listBox1_fizetesimod";
            this.listBox1_fizetesimod.Size = new System.Drawing.Size(220, 17);
            this.listBox1_fizetesimod.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Keresés:";
            // 
            // plista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 394);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listBox1_fizetesimod);
            this.Controls.Add(this.dateTimePicker1_szulido);
            this.Controls.Add(this.button1_modositas);
            this.Controls.Add(this.button1_importcsv);
            this.Controls.Add(this.textBox8_megjegyzes);
            this.Controls.Add(this.textBox7_email);
            this.Controls.Add(this.textbox6_postazasicim);
            this.Controls.Add(this.textBox5_telepitesicim);
            this.Controls.Add(this.textBox4_szemelyiszam);
            this.Controls.Add(this.textBox3_anyjaszulneve);
            this.Controls.Add(this.maskedTextBox1_telefonszam);
            this.Controls.Add(this.listBox1_internetcsomag);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4_szulhely);
            this.Controls.Add(this.textBox3_szulneve);
            this.Controls.Add(this.textBox2_eloneve);
            this.Controls.Add(this.button1_kereses);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "plista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "plista";
            this.Load += new System.EventHandler(this.Plista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_kereses;
        private System.Windows.Forms.TextBox textBox2_eloneve;
        private System.Windows.Forms.TextBox textBox3_szulneve;
        private System.Windows.Forms.TextBox textBox4_szulhely;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1_internetcsomag;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_telefonszam;
        private System.Windows.Forms.TextBox textBox3_anyjaszulneve;
        private System.Windows.Forms.TextBox textBox4_szemelyiszam;
        private System.Windows.Forms.TextBox textBox5_telepitesicim;
        private System.Windows.Forms.TextBox textbox6_postazasicim;
        private System.Windows.Forms.TextBox textBox7_email;
        private System.Windows.Forms.TextBox textBox8_megjegyzes;
        private System.Windows.Forms.Button button1_importcsv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1_modositas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_szulido;
        private System.Windows.Forms.ListBox listBox1_fizetesimod;
        private System.Windows.Forms.Label label14;
    }
}