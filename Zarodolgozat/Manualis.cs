﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zarodolgozat
{
    public partial class Manualis : Form
    {
        public Manualis()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Manualis_Load(object sender, EventArgs e)
        {
            listBox1_internetcsomag.Items.Add("8");
            listBox1_internetcsomag.Items.Add("15");
            listBox1_internetcsomag.Items.Add("30");
            listBox1_internetcsomag.Items.Add("60");
            listBox1_internetcsomag.SelectedItem = "8";



            listBox2_fizetesimod.Items.Add("Posta");
            listBox2_fizetesimod.Items.Add("Banki átutalás");
            listBox2_fizetesimod.Items.Add("Elektronikus számla");
            listBox2_fizetesimod.SelectedItem = "Posta";

        }

        private void Button1_kuld_Click(object sender, EventArgs e)
        {
            string elofizetoneve = textBox1_elofizetoneve.Text;
            string szuletesineve = textBox1_szuletesineve.Text;
            string szuletesihely = textBox1_szuletesihelye.Text;
            string szuletesiido = Convert.ToString(dateTimePicker1_szuletesiideje.Text);
            string anyjaszuletesineve = textBox1_anyjaszuletesineve.Text;
            string szemelyiszama = Convert.ToString(textBox1_szemelyigazolvanyszama.Text);
            string telepitesicim = Convert.ToString(textBox2_telepitesicim.Text);
            string postazasicim = Convert.ToString(textBox3_postazasicim.Text);
            string telefonszam = Convert.ToString(maskedTextBox2_telefonszam.Text);
            string email = Convert.ToString(textBox5_email.Text);
            string intertnetcsomag = Convert.ToString(listBox1_internetcsomag.SelectedItem.ToString());
            string fizetesimod = Convert.ToString(listBox2_fizetesimod.SelectedItem.ToString());
            string megjegyzes = Convert.ToString(textBox6_megjegyzes.Text);

            Program.conn.Open();
            Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
            Program.sqlparancs.Connection = Program.conn;


            Program.sqlparancs.CommandText = "INSERT INTO `users` (`id`, `elofizetoneve`, `szuletesineve`, `szuletesihely`, `szuletesiido`, `anyjaszuletesineve`, `szemelyiszam`, `telepitesicim`, `postazasicim`, `telefonszam`, `email`, `internetcsomag`, `fizetesimod`, `megjegyzes`) VALUES(NULL, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
            Program.sqlparancs.Parameters.Add("elofizetoneve", MySqlDbType.VarChar).Value = elofizetoneve;
            Program.sqlparancs.Parameters.Add("szuletesineve", MySqlDbType.VarChar).Value = szuletesineve;
            Program.sqlparancs.Parameters.Add("szuletesihely", MySqlDbType.VarChar).Value = szuletesihely;
            Program.sqlparancs.Parameters.Add("szuletesiido", MySqlDbType.VarChar).Value = szuletesiido;
            Program.sqlparancs.Parameters.Add("anyjaszuletesineve", MySqlDbType.VarChar).Value = anyjaszuletesineve;
            Program.sqlparancs.Parameters.Add("szemelyiszam", MySqlDbType.VarChar).Value = szemelyiszama;
            Program.sqlparancs.Parameters.Add("telepitesicim", MySqlDbType.VarChar).Value = telepitesicim;
            Program.sqlparancs.Parameters.Add("postazasicim", MySqlDbType.VarChar).Value = postazasicim;
            Program.sqlparancs.Parameters.Add("telefonszam", MySqlDbType.VarChar).Value = telefonszam;
            Program.sqlparancs.Parameters.Add("email", MySqlDbType.VarChar).Value = email;
            Program.sqlparancs.Parameters.Add("internetcsomag", MySqlDbType.String).Value = intertnetcsomag;
            Program.sqlparancs.Parameters.Add("fizetesimod", MySqlDbType.String).Value = fizetesimod;
            Program.sqlparancs.Parameters.Add("megjegyzes", MySqlDbType.VarChar).Value = megjegyzes;
            Program.sqlparancs.ExecuteNonQuery();
            Program.conn.Close();


            if (!this.textBox5_email.Text.Contains('@') || !this.textBox5_email.Text.Contains('.'))
            {
                MessageBox.Show("Kérem adjon meg egy helyes email címet!", "Hibaüzent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.Close();


        }

        private void ListBox1_internetcsomag_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void ListBox2_fizetesimod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
