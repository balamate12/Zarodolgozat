using System;
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
    }
}

