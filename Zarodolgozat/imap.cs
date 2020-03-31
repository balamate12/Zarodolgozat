using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Mail;
using MySql.Data.MySqlClient;


namespace Zarodolgozat
{
    public partial class imap : Form
    {
        public imap()
        {
            InitializeComponent();
        }

        private void Imap_Load(object sender, EventArgs e)
        {

        }

        private void Button1_bejelentkezes_Click(object sender, EventArgs e)
        {
            //imap.gmail.com || 993
            if (String.IsNullOrEmpty(textBox2_imap.Text))
            {
                MessageBox.Show("Adjon meg imap elérhetőséget!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (String.IsNullOrEmpty(textBox3_user.Text))
            {
                MessageBox.Show("Adjon meg felhasználónevet!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (String.IsNullOrEmpty(maskedTextBox1_port.Text))
            {
                MessageBox.Show("Adjon meg portszámot!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (String.IsNullOrEmpty(textBox5_password.Text))
            {
                MessageBox.Show("Adjon meg jelszót!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string imapbe = textBox2_imap.Text;
            string user = textBox3_user.Text;
            string port = Convert.ToString(maskedTextBox1_port.Text);
            string password = textBox5_password.Text;

            List<string> uzenet = new List<string>();

            try
            {
                using (Imap imap = new Imap())
                {
                    imap.Connect(imapbe, Convert.ToInt32(port), true);
                    imap.UseBestLogin(user, password);

                    imap.SelectInbox();

                    SimpleImapQuery query = new SimpleImapQuery();
                    query.Subject = "Megrendelés";
                    query.Unseen = true;
                    List<long> uidList = imap.Search(query);

                    int i = 0;
                    foreach (long uid in uidList)
                    {
                        if (i == 0)
                        {
                            IMail email = new MailBuilder()
                                .CreateFromEml(imap.GetMessageByUID(uid));
  

                            label1.Text = Convert.ToString(email.Text);

                            if (!String.IsNullOrEmpty(label1.Text))
                            {
                                label1.Text = " ";
                            }

                            uzenet.Add(email.Text);

                            imap.Close();
                        }
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Helytelen bejelentkezés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (label1.Text == "")
            {
                MessageBox.Show("Nincs beérkezett megrendelés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (label1.Text == " ")
            {
                MessageBox.Show("Sikeres feltöltés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "";
            }



            foreach (var item in uzenet)
            {
                string[] lines = item.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
                );

                string[] sor = lines[5].Split(':');
                string elofizetoneve = sor[1];

                string[] sor1 = lines[6].Split(':');
                string szuletesineve = sor1[1];

                string[] sor2 = lines[7].Split(':',' ');
                string szuletesihely = sor2[4]; // születési hely
                string szuletesiido = sor2[5]+"."+ sor2[6]+"."+sor2[7]; //születési idő 

                string[] sor3 = lines[8].Split(':');
                string anyjaszuletesineve = sor3[1];

                string[] sor4 = lines[9].Split(':');
                string szemelyiszama = sor4[1];

                string[] sor5 = lines[10].Split(':');
                string telepitesicim = sor5[1];

                string[] sor6 = lines[11].Split(':');
                string postazasicim = sor6[1];

                string[] sor7 = lines[12].Split(':');
                string telefonszam = sor7[1];

                string[] sor8 = lines[13].Split(':');
                string email = sor8[1];

                string[] sor9 = lines[14].Split(':');
                string intertnetcsomag = sor9[1];

                string[] sor10 = lines[15].Split(':');
                string fizetesimod = sor10[1];

                string[] sor11 = lines[16].Split(':');
                string megjegyzes = sor11[1];

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

            }

        }

        private void Button1_bezar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
