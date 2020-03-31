using System;
using System.Data;
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
            datagrid();

        }

        public void datagrid()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            Program.sqlparancs = Program.conn.CreateCommand();
            Program.sqlparancs.CommandText = "SELECT * FROM `users`";
            MySqlDataReader sqldatareader = Program.sqlparancs.ExecuteReader();
            MyDA.SelectCommand = new MySqlCommand("SELECT * FROM `users`", Program.conn);

            Program.conn.Close();
            Program.conn.Open();

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView1.DataSource = bSource;
            Program.conn.Close();
            DataSet ds = new DataSet();
            ds.Clear();//clear before fill

            MyDA.Fill(ds);


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

        private void Button1_kereses_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}

