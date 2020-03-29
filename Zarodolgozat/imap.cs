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
using Limilabs.Client.POP3;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.MIME;
using Limilabs.Mail.Fluent;
using Limilabs.Mail.Headers;

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
        textBox1.ScrollBars = ScrollBars.Vertical;
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
                MessageBox.Show("Adjon meg felhasználónevet!","Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (String.IsNullOrEmpty(textBox4_port.Text))
            {
                MessageBox.Show("Adjon meg portszámot!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (String.IsNullOrEmpty(textBox5_password.Text))
            {
                MessageBox.Show("Adjon meg jelszót!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string imapbe = textBox2_imap.Text;
            string user = textBox3_user.Text;
            string port = Convert.ToString(textBox4_port.Text);
            string password = textBox5_password.Text;

            using (Imap imap = new Imap())
            {
                try
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

                            textBox1.Text = email.Subject;
                            textBox1.Text = email.Text;
                            if (email.Text.Length > 0)
                            {
                                MessageBox.Show("Sikeres beolvasás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Nincs beérkezett megrendelés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        i++;
                    }
                    imap.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Helytelen bejelentkezés!","Információ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void Button1_bezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
