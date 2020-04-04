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
        string filter = "Pontosveszzővel tagolt(*.csv)|*.csv";

        public plista()
        {
            InitializeComponent();
        }

        //List<string> all = new List<string>();


        private void Plista_Load(object sender, EventArgs e)
        {

            Program.conn.Open();
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

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();




        }


        private void Button1_kereses_Click_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int rowIndex = -1;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[row.Index].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[row.Index].Selected = true;

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
            listBox1_internetcsomag.Items.Add("8");
            listBox1_internetcsomag.Items.Add("15");
            listBox1_internetcsomag.Items.Add("30");
            listBox1_internetcsomag.Items.Add("60");




            listBox2_fizetesimod.Items.Add("Csekk");
            listBox2_fizetesimod.Items.Add("Banki átutalás");
            listBox2_fizetesimod.Items.Add("Elektronikus számla");

            string searchValue = textBox1.Text;
            int rowIndex = -1;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[row.Index].Value.ToString().Equals(searchValue))
                    {

                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[row.Index].Selected = true;

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
                                textBox2_szulideje.Text = rdr.GetString(4);
                                textBox3_anyjaszulneve.Text = rdr.GetString(5);
                                textBox4_szemelyiszam.Text = rdr.GetString(6);
                                textBox5_telepitesicim.Text = rdr.GetString(7);
                                textbox6_postazasicim.Text = rdr.GetString(8);
                                maskedTextBox1_telefonszam.Text = rdr.GetString(9);
                                textBox7_email.Text = rdr.GetString(10);
                                listBox1_internetcsomag.Text = rdr.GetString(11);
                                listBox2_fizetesimod.Text = rdr.GetString(12);
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
                //MessageBox.Show("Nincs ilyen partner!!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

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
    }
}
