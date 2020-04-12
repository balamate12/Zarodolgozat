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

namespace Zarodolgozat
{
    public partial class useradd : Form
    {
        public useradd()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string felhasznalonev = textBox1_felhasznev.Text;
            string jelszo = textBox2_jelszo.Text;
            string jelszomegegyszer = textBox1_jelszomegegyszer.Text;

            if (String.IsNullOrEmpty(textBox1_felhasznev.Text))
            {
                MessageBox.Show("Adjon meg felhasználónevet!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(textBox2_jelszo.Text))
            {
                MessageBox.Show("Adjon meg jelszót!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(textBox1_jelszomegegyszer.Text))
            {
                MessageBox.Show("Adja meg a jelszót mégegyszer!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox2_jelszo.Text != textBox1_jelszomegegyszer.Text)
            {
                MessageBox.Show("A két jelszó nem egyezik meg!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    Program.conn.Open();
                    Program.sqlparancs = new MySqlCommand(Program.conn.ToString());
                    Program.sqlparancs.Connection = Program.conn;


                    Program.sqlparancs.CommandText = "INSERT INTO `login` (`id`,`felhasznalonev`, `jelszo`) VALUES(NULL, ?, ?);";
                    Program.sqlparancs.Parameters.Add("elofizetoneve", MySqlDbType.VarChar).Value = felhasznalonev;
                    Program.sqlparancs.Parameters.Add("szuletesineve", MySqlDbType.VarChar).Value = jelszo;

                    Program.sqlparancs.ExecuteNonQuery();
                    Program.conn.Close();
                    MessageBox.Show("Sikeres hozzáadás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Sikertelen hozzáadás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }
    }
}
