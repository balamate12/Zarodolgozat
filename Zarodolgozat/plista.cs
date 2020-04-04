using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Zarodolgozat
{
    public partial class plista : Form
    {
        public plista()
        {
            InitializeComponent();
        }

        private void Plista_Load(object sender, EventArgs e)
        {

            Program.conn.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            Program.sqlparancs = Program.conn.CreateCommand();
            Program.sqlparancs.CommandText = "SELECT * FROM `users`";
            MySqlDataReader sqldatareader = Program.sqlparancs.ExecuteReader();
            MyDA.SelectCommand = new MySqlCommand("SELECT elofizetoneve, internetcsomag, fizetesimod FROM `users`", Program.conn);

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

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

        }


        private void Button1_kereses_Click_1(object sender, EventArgs e)
        {
            Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
            Program.sqlparancs.Connection = Program.conn;

            string searchValue = textBox1.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Cells[0].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            { 

                MessageBox.Show("Nincs ilyen partner!!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

 
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
            Program.sqlparancs.Connection = Program.conn;

            string searchValue = textBox1.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                       dataGridView1.ClearSelection();
                        row.Cells[0].Selected = true;


                        Program.conn.Open();
                        string sql = "SELECT * FROM users WHERE elofizetoneve = '" + searchValue + "'";
                        using (var cmd = new MySqlCommand(sql, Program.conn))
                        {
                            MySqlDataReader rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                textBox2_eloneve.Text = rdr.GetString(1);
                                textBox3_szulneve.Text = rdr.GetString(2);
                                textBox4_szulhely.Text = rdr.GetString(3);
                                dateTimePicker1_szulido.Text = rdr.GetString(4);
                                textBox3_anyjaszulneve.Text = rdr.GetString(5);
                                textBox4_szemelyiszam.Text = rdr.GetString(6);
                                textBox5_telepitesicim.Text = rdr.GetString(7);
                                textbox6_postazasicim.Text = rdr.GetString(8);
                                maskedTextBox1_telefonszam.Text = rdr.GetString(9);
                                textBox7_email.Text = rdr.GetString(10);
                                listBox1_internetcsomag.SelectedItem = rdr.GetString(11);
                                listBox2_fizetesimod.SelectedItem = rdr.GetString(12);
                                textBox8_megjegyzes.Text = rdr.GetString(13);

                            }
                        }
                        Program.conn.Close();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }




        private void button1_importcsv_Click(object sender, EventArgs e)
        {
            int darab = 0;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            desktopPath += "\\mentes.csv";

            try
            {
                using (StreamWriter bw = new StreamWriter(desktopPath))
                {
                    bw.Write(dataGridView1.Columns.Count);
                    bw.Write(dataGridView1.Rows.Count);
                    foreach (DataGridViewRow dgvR in dataGridView1.Rows)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                        {
                            darab++;
                            object val = dgvR.Cells[j].Value;
                            if (val == null)
                            {
                                bw.Write("");
                                bw.Write("");
                            }
                            else
                            {

                                bw.WriteLine(";");
                                bw.Write(val.ToString());
                            }
                        }
                        bw.WriteLine();
                    }

                    MessageBox.Show("Sikeres mentés az asztalra!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sikertelen mentés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
                
        
           
        }

        private void button1_modositas_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            string ertek = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            string elofizetoneve = textBox2_eloneve.Text;
            string szuletesineve = textBox3_szulneve.Text;
            string szuletesihely = textBox4_szulhely.Text;
            string szuletesiido = Convert.ToString(dateTimePicker1_szulido.Text);
            string anyjaszuletesineve = textBox3_anyjaszulneve.Text;
            string szemelyiszama = Convert.ToString(textBox4_szemelyiszam.Text);
            string telepitesicim = Convert.ToString(textBox5_telepitesicim.Text);
            string postazasicim = Convert.ToString(textbox6_postazasicim.Text);
            string telefonszam = Convert.ToString(maskedTextBox1_telefonszam.Text);
            string email = Convert.ToString(textBox7_email.Text);
            string intertnetcsomag = Convert.ToString(listBox1_internetcsomag.SelectedItem.ToString());
            string fizetesimod = Convert.ToString(listBox2_fizetesimod.SelectedItem.ToString());
            string megjegyzes = Convert.ToString(textBox8_megjegyzes.Text);


            Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
            Program.sqlparancs.Connection = Program.conn;


            Program.sqlparancs.CommandText = "UPDATE users SET elofizetoneve = @1, szuletesineve = @2, szuletesihely = @3 WHERE (elofizetoneve = '"+ertek+"')";



            Program.sqlparancs.Parameters.AddWithValue("@1", elofizetoneve);
            Program.sqlparancs.Parameters.AddWithValue("@2", textBox3_szulneve.Text);
            Program.sqlparancs.Parameters.AddWithValue("@3", textBox4_szulhely.Text);

            Program.conn.Open();

            Program.sqlparancs.ExecuteNonQuery();

            Program.conn.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            string ertek = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            Program.conn.Open();
            string sql = "SELECT * FROM users WHERE elofizetoneve = '" + ertek + "'";
            using (var cmd = new MySqlCommand(sql, Program.conn))
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    textBox2_eloneve.Text = rdr.GetString(1);
                    textBox3_szulneve.Text = rdr.GetString(2);
                    textBox4_szulhely.Text = rdr.GetString(3);
                    dateTimePicker1_szulido.Text = rdr.GetString(4);
                    textBox3_anyjaszulneve.Text = rdr.GetString(5);
                    textBox4_szemelyiszam.Text = rdr.GetString(6);
                    textBox5_telepitesicim.Text = rdr.GetString(7);
                    textbox6_postazasicim.Text = rdr.GetString(8);
                    maskedTextBox1_telefonszam.Text = rdr.GetString(9);
                    textBox7_email.Text = rdr.GetString(10);
                    listBox1_internetcsomag.SelectedItem = rdr.GetString(11);
                    listBox2_fizetesimod.SelectedItem = rdr.GetString(12);
                    textBox8_megjegyzes.Text = rdr.GetString(13);

                }
            }
            Program.conn.Close();

        }
    }
}
