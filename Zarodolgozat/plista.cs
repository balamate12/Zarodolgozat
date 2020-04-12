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
using System.Data.SqlClient;

namespace Zarodolgozat
{
    public partial class Partnerlista : Form
    {

        public Partnerlista()
        {
            InitializeComponent();
        }

        private void Plista_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

            textBox2_eloneve.Enabled = false;
            textBox3_szulneve.Enabled = false;
            textBox4_szulhely.Enabled = false;
            dateTimePicker1_szulido.Enabled = false;
            textBox3_anyjaszulneve.Enabled = false;
            textBox4_szemelyiszam.Enabled = false;
            textBox5_telepitesicim.Enabled = false;
            textbox6_postazasicim.Enabled = false;
            maskedTextBox1_telefonszam.Enabled = false;
            textBox7_email.Enabled = false;
            listBox1_internetcsomag.Enabled = false;
            listBox1_fizetesimod.Enabled = false;
            textBox8_megjegyzes.Enabled = false;

            button1_modositas.Enabled = false;
            button1_torles.Enabled = false;

            Adattabla_beallitasai();
            Adattabla_Update();
        }

        private void Adattabla_beallitasai()
        {
 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

            DataGridViewColumn column_id = new DataGridViewColumn();
            {
                column_id.HeaderText = "ID";
                column_id.Name = "id";
                column_id.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(0, column_id);

            DataGridViewColumn column_elofizetoneve = new DataGridViewColumn();
            {
                column_elofizetoneve.HeaderText = "Név";
                column_elofizetoneve.Name = "elofizetoneve";
                column_elofizetoneve.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(1, column_elofizetoneve);

            DataGridViewColumn column_szuletesihely = new DataGridViewColumn();
            {
                column_szuletesihely.HeaderText = "Születési hely";
                column_szuletesihely.Name = "szuletesihely";
                column_szuletesihely.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(2, column_szuletesihely);

            DataGridViewColumn column_szuletesiido = new DataGridViewColumn();
            {
                column_szuletesiido.HeaderText = "Születési idő";
                column_szuletesiido.Name = "szuletesiido";
                column_szuletesiido.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(3, column_szuletesiido);

            DataGridViewColumn column_anyjaszuletesineve = new DataGridViewColumn();
            {
                column_anyjaszuletesineve.HeaderText = "Anyja születési neve";
                column_anyjaszuletesineve.Name = "anyjaszuletesineve";
                column_anyjaszuletesineve.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(4, column_anyjaszuletesineve);

            DataGridViewColumn column_szemelyiszam = new DataGridViewColumn();
            {
                column_szemelyiszam.HeaderText = "Személyi szám";
                column_szemelyiszam.Name = "szemelyiszam";
                column_szemelyiszam.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(5, column_szemelyiszam);

            DataGridViewColumn column_telepitesicim = new DataGridViewColumn();
            {
                column_telepitesicim.HeaderText = "Telepítési cím";
                column_telepitesicim.Name = "telepitesicim";
                column_telepitesicim.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(6, column_telepitesicim);

            DataGridViewColumn column_postazasicim = new DataGridViewColumn();
            {
                column_postazasicim.HeaderText = "Postázási cím";
                column_postazasicim.Name = "postazasicim";
                column_postazasicim.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(7, column_postazasicim);

            DataGridViewColumn column_telefonszam = new DataGridViewColumn();
            {
                column_telefonszam.HeaderText = "Telefonszám";
                column_telefonszam.Name = "telefonszam";
                column_telefonszam.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(8, column_telefonszam);

            DataGridViewColumn column_email = new DataGridViewColumn();
            {
                column_email.HeaderText = "Email";
                column_email.Name = "email";
                column_email.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(9, column_email);

            DataGridViewColumn column_internetcsomag = new DataGridViewColumn();
            {
                column_internetcsomag.HeaderText = "Internetcsomag";
                column_internetcsomag.Name = "internetcsomag";
                column_internetcsomag.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(10, column_internetcsomag);

            DataGridViewColumn column_fizetesimod = new DataGridViewColumn();
            {
                column_fizetesimod.HeaderText = "Fizetési mód";
                column_fizetesimod.Name = "fizetesimod";
                column_fizetesimod.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(11, column_fizetesimod);

            DataGridViewColumn column_megjegyzes = new DataGridViewColumn();
            {
                column_megjegyzes.HeaderText = "Megjegyzés";
                column_megjegyzes.Name = "megjegyzes";
                column_megjegyzes.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView1.Columns.Insert(12, column_megjegyzes);
        }

        private void Adattabla_Update()
        {
            Program.conn.Open();

            Program.sqlparancs.CommandText = "SELECT `id`,`elofizetoneve`,`szuletesihely`,`szuletesiido`,`anyjaszuletesineve`,`szemelyiszam`,`telepitesicim`,`postazasicim`,`telefonszam`,`email`,`internetcsomag`,`fizetesimod`,`megjegyzes` FROM `users`;";
            using (MySqlDataReader dr = Program.sqlparancs.ExecuteReader())
            {
                while (dr.Read())
                {
                    int uj_sor_index = dataGridView1.Rows.Add();

                    DataGridViewRow uj_sor = dataGridView1.Rows[uj_sor_index];
                    uj_sor.Cells["id"].Value = dr.GetString("id");
                    uj_sor.Cells["elofizetoneve"].Value = dr.GetString("elofizetoneve");
                    uj_sor.Cells["szuletesihely"].Value = dr.GetString("szuletesihely");
                    uj_sor.Cells["szuletesiido"].Value = dr.GetString("szuletesiido");
                    uj_sor.Cells["anyjaszuletesineve"].Value = dr.GetString("anyjaszuletesineve");
                    uj_sor.Cells["szemelyiszam"].Value = dr.GetString("szemelyiszam");
                    uj_sor.Cells["telepitesicim"].Value = dr.GetString("telepitesicim");
                    uj_sor.Cells["postazasicim"].Value = dr.GetString("postazasicim");
                    uj_sor.Cells["telefonszam"].Value = dr.GetString("telefonszam");
                    uj_sor.Cells["email"].Value = dr.GetString("email");
                    uj_sor.Cells["internetcsomag"].Value = dr.GetString("internetcsomag");
                    uj_sor.Cells["fizetesimod"].Value = dr.GetString("fizetesimod");
                    uj_sor.Cells["megjegyzes"].Value = dr.GetString("megjegyzes");

                }
            }
            Program.conn.Close();
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

        private void button1_importcsv_Click(object sender, EventArgs e)
        {
            int darab = 0;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) ;
            desktopPath += "\\mentes.csv";
            try
            {
                using (StreamWriter bw = new StreamWriter(desktopPath, false,Encoding.UTF8))
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
            try
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
                string fizetesimod = Convert.ToString(listBox1_fizetesimod.SelectedItem.ToString());
                string megjegyzes = Convert.ToString(textBox8_megjegyzes.Text);


                Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
                Program.sqlparancs.Connection = Program.conn;



                Program.sqlparancs.CommandText = "UPDATE `users` SET elofizetoneve = @1, szuletesineve = @2, szuletesihely = @3, szuletesiido = @4, anyjaszuletesineve = @5,  szemelyiszam = @6,  telepitesicim = @7, postazasicim = @8,  telefonszam = @9,  email = @10, internetcsomag = @11,  fizetesimod = @12,  megjegyzes = @13 WHERE (id = '" + ertek + "')"; // elofizetoneve


                Program.sqlparancs.Parameters.AddWithValue("@1", elofizetoneve);
                Program.sqlparancs.Parameters.AddWithValue("@2", szuletesineve);
                Program.sqlparancs.Parameters.AddWithValue("@3", szuletesihely);
                Program.sqlparancs.Parameters.AddWithValue("@4", szuletesiido);
                Program.sqlparancs.Parameters.AddWithValue("@5", anyjaszuletesineve);
                Program.sqlparancs.Parameters.AddWithValue("@6", szemelyiszama);
                Program.sqlparancs.Parameters.AddWithValue("@7", telepitesicim);
                Program.sqlparancs.Parameters.AddWithValue("@8", postazasicim);
                Program.sqlparancs.Parameters.AddWithValue("@9", telefonszam);
                Program.sqlparancs.Parameters.AddWithValue("@10", email);
                Program.sqlparancs.Parameters.AddWithValue("@11", intertnetcsomag);
                Program.sqlparancs.Parameters.AddWithValue("@12", fizetesimod);
                Program.sqlparancs.Parameters.AddWithValue("@13", megjegyzes);

                Program.conn.Open();

                Program.sqlparancs.ExecuteNonQuery();

                Program.conn.Close();

                MessageBox.Show("Sikeres módosítás", "információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox2_eloneve.Text = "";


            }
            catch (Exception)
            {
                MessageBox.Show("Sikertelen módosítás!","információ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            dataGridView1.Rows.Clear();
            Adattabla_Update();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox2_eloneve.Enabled = true;
                textBox3_szulneve.Enabled = true;
                textBox4_szulhely.Enabled = true;
                dateTimePicker1_szulido.Enabled = true;
                textBox3_anyjaszulneve.Enabled = true;
                textBox4_szemelyiszam.Enabled = true;
                textBox5_telepitesicim.Enabled = true;
                textbox6_postazasicim.Enabled = true;
                maskedTextBox1_telefonszam.Enabled = true;
                textBox7_email.Enabled = true;
                listBox1_internetcsomag.Enabled = true;
                listBox1_fizetesimod.Enabled = true;
                textBox8_megjegyzes.Enabled = true;

                button1_modositas.Enabled = true;
                button1_torles.Enabled = true;

                dataGridView1.CurrentRow.Selected = true;

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                string ertek = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();


                Program.conn.Open();
                string sql = "SELECT * FROM users WHERE id = '" + ertek + "'";
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
                            listBox1_fizetesimod.SelectedItem = rdr.GetString(12);
                            textBox8_megjegyzes.Text = rdr.GetString(13);

                        }

                        if (textBox2_eloneve.Text == "")
                        {
                            button1_modositas.Enabled = false;
                            button1_torles.Enabled = false;
                        }
                        Program.conn.Close();
                }
            }
            catch (Exception)
            {
                textBox2_eloneve.Enabled = false;
                textBox3_szulneve.Enabled = false;
                textBox4_szulhely.Enabled = false;
                dateTimePicker1_szulido.Enabled = false;
                textBox3_anyjaszulneve.Enabled = false;
                textBox4_szemelyiszam.Enabled = false;
                textBox5_telepitesicim.Enabled = false;
                textbox6_postazasicim.Enabled = false;
                maskedTextBox1_telefonszam.Enabled = false;
                textBox7_email.Enabled = false;
                listBox1_internetcsomag.Enabled = false;
                listBox1_fizetesimod.Enabled = false;
                textBox8_megjegyzes.Enabled = false;

                button1_modositas.Enabled = false;
                button1_torles.Enabled = false;


                textBox2_eloneve.Text = "";
                textBox3_szulneve.Text = "";
                textBox4_szulhely.Text = "";
                dateTimePicker1_szulido.Text = "";
                textBox3_anyjaszulneve.Text = "";
                textBox4_szemelyiszam.Text = "";
                textBox5_telepitesicim.Text = "";
                textbox6_postazasicim.Text = "";
                maskedTextBox1_telefonszam.Text = "";
                textBox7_email.Text = "";
                textBox8_megjegyzes.Text = "";
                MessageBox.Show("Nincs partner kijelölve!", "információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            dataGridView1.ClearSelection();
            if (searchValue.Length != 0)
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string tesztNev = "";
                        if (searchValue.Length <= row.Cells[1].Value.ToString().Length)
                            for (int i = 0; i < searchValue.Length; i++)
                            {
                                tesztNev += row.Cells[1].Value.ToString()[i];
                                
                            }
                        if (tesztNev == searchValue)
                        {
                            dataGridView1.Rows[row.Index].Selected = true;

                        }
                    }
                }
                catch
                {
                    return;
                }
            }

        }

        private void button1_bezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_torles_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            string ertek = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            try
            {
                Program.conn.Open();
                Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
                Program.sqlparancs.Connection = Program.conn;
                Program.sqlparancs.CommandText = "DELETE FROM `users` WHERE id= '" + ertek + "'";
                Program.sqlparancs.ExecuteNonQuery();
                MessageBox.Show("Sikeres eltávolítás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Az eltávolítás sikertelen volt!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.conn.Close();

            dataGridView1.Rows.Clear();
            Adattabla_Update();
        }
    }
}
