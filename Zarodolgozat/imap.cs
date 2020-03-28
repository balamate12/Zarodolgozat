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

            using (Imap imap = new Imap())
            {
                imap.Connect("imap.gmail.com", 993, true);       
                imap.UseBestLogin("probapopclient", "PoPClient");
                
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
                    }
                    i++;
                }
                imap.Close();
            }

        }
    }
}
