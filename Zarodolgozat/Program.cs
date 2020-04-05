using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Zarodolgozat
{
    static class Program
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand sqlparancs = null;

        [STAThread]
        static void Main()
        {
            MySqlBaseConnectionStringBuilder sb = null;
            sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tesztuzem";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sqlparancs = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);  
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
