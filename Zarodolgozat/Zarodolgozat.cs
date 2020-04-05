﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Zarodolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Program.conn.Close();
            this.Refresh();
        }


        private void Button1_manualis_Click(object sender, EventArgs e)
        {
            var Manualis = new Manualis();
            Manualis.Show();
        }

        private void Button1_imap_Click(object sender, EventArgs e)
        {
            var imap = new imap();
            imap.Show();

        }


        private void Button1_partnerlista_Click(object sender, EventArgs e)
        {
            var plista = new plista();
            plista.Show();
        }

        private void button1_belepes_Click(object sender, EventArgs e)
        { 

                Program.conn.Open();

                Program.sqlparancs.CommandText = "SELECT felhasznalonev, jelszo FROM login";

            MySqlDataReader rdr = Program.sqlparancs.ExecuteReader();

            while (rdr.Read())
                {
                    if (textBox1.Text == (rdr["felhasznalonev"].ToString()) && textBox2.Text == (rdr["jelszo"].ToString()))
                    {
                    groupBox1.Visible = false;

                    button1_imap.Visible = true;
                    button1_manualis.Visible = true;
                    button1_partnerlista.Visible = true;
                    button1_kilepes.Visible = true;

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                    {

                        MessageBox.Show("Helytelen felhasználónév vagy jelszó!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

            Program.conn.Close();


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = true;

                Program.conn.Open();

                Program.sqlparancs.CommandText = "SELECT felhasznalonev, jelszo FROM login";

                MySqlDataReader rdr = Program.sqlparancs.ExecuteReader();

                while (rdr.Read())
                {
                    if (textBox1.Text == (rdr["felhasznalonev"].ToString()) && textBox2.Text == (rdr["jelszo"].ToString()))
                    {
                        groupBox1.Visible = false;

                        button1_imap.Visible = true;
                        button1_manualis.Visible = true;
                        button1_partnerlista.Visible = true;
                        button1_kilepes.Visible = true;

                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Rossz felhasználónév vagy jelszó!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

                Program.conn.Close();
            }
        }

        private void button1_kilepes_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            button1_imap.Visible = false;
            button1_manualis.Visible = false;
            button1_partnerlista.Visible = false;
            button1_kilepes.Visible = false;

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

