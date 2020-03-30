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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static MySqlConnection conn = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //id
            DataGridViewTextBoxColumn column_id = new DataGridViewTextBoxColumn();
            {
                column_id.HeaderText = "ID";
                column_id.Name = "id";
                column_id.CellTemplate = new DataGridViewTextBoxCell();
                column_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(0, column_id);

            //név
            DataGridViewTextBoxColumn column_ElofizetoNev = new DataGridViewTextBoxColumn();
            {
                column_ElofizetoNev.HeaderText = "Név";
                column_ElofizetoNev.Name = "elofizetoneve";
                column_ElofizetoNev.CellTemplate = new DataGridViewTextBoxCell();
                column_ElofizetoNev.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(1, column_ElofizetoNev);

            //születési név
            DataGridViewTextBoxColumn column_Szuletesineve = new DataGridViewTextBoxColumn();
            {
                column_Szuletesineve.HeaderText = "Születési név";
                column_Szuletesineve.Name = "szuletesineve";
                column_Szuletesineve.CellTemplate = new DataGridViewTextBoxCell();
                column_Szuletesineve.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_Szuletesineve.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(2, column_Szuletesineve);

            //születésiihely
            DataGridViewTextBoxColumn column_Szuletesihely = new DataGridViewTextBoxColumn();
            {
                column_Szuletesihely.HeaderText = "Születési hely";
                column_Szuletesihely.Name = "szuletesihely";
                column_Szuletesihely.CellTemplate = new DataGridViewTextBoxCell();
                column_Szuletesihely.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_Szuletesihely.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(3, column_Szuletesihely);

            //születesiidő
            DataGridViewTextBoxColumn column_Szuletesiido = new DataGridViewTextBoxColumn();
            {
                column_Szuletesiido.HeaderText = "Születési idő";
                column_Szuletesiido.Name = "szuletesiido";
                column_Szuletesiido.CellTemplate = new DataGridViewTextBoxCell();
                column_Szuletesiido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_Szuletesiido.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(4, column_Szuletesiido);

            //anyjaneve
            DataGridViewTextBoxColumn column_Anyjaneve = new DataGridViewTextBoxColumn();
            {
                column_Anyjaneve.HeaderText = "Anyja neve";
                column_Anyjaneve.Name = "anyjaneve";
                column_Anyjaneve.CellTemplate = new DataGridViewTextBoxCell();
                column_Anyjaneve.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_Anyjaneve.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(5, column_Anyjaneve);

            //személyiszám
            DataGridViewTextBoxColumn column_szemelyigazolvanszam = new DataGridViewTextBoxColumn();
            {
                column_szemelyigazolvanszam.HeaderText = "Személyi szám";
                column_szemelyigazolvanszam.Name = "szemelyiszam";
                column_szemelyigazolvanszam.CellTemplate = new DataGridViewTextBoxCell();
                column_szemelyigazolvanszam.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_szemelyigazolvanszam.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(6, column_szemelyigazolvanszam);

            //telepítési cím
            DataGridViewTextBoxColumn column_telepitesicim = new DataGridViewTextBoxColumn();
            {
                column_telepitesicim.HeaderText = "Telepítési cím";
                column_telepitesicim.Name = "telepitesicim";
                column_telepitesicim.CellTemplate = new DataGridViewTextBoxCell();
                column_telepitesicim.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_telepitesicim.AutoSizeMode= DataGridViewAutoSizeColumnMode.DisplayedCells;
                column_telepitesicim.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(7, column_telepitesicim);

            //postázási cím
            DataGridViewTextBoxColumn column_postazasicim = new DataGridViewTextBoxColumn();
            {
                column_postazasicim.HeaderText = "Postázási cím";
                column_postazasicim.Name = "postazasicim";
                column_postazasicim.CellTemplate = new DataGridViewTextBoxCell();
                column_postazasicim.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_postazasicim.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(8, column_postazasicim);

            //telefon
            DataGridViewTextBoxColumn column_telefon = new DataGridViewTextBoxColumn();
            {
                column_telefon.HeaderText = "Telefon";
                column_telefon.Name = "telefon";
                column_telefon.CellTemplate = new DataGridViewTextBoxCell();
                column_telefon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_telefon.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(9, column_telefon);

            //email
            DataGridViewTextBoxColumn column_email = new DataGridViewTextBoxColumn();
            {
                column_email.HeaderText = "Email";
                column_email.Name = "email";
                column_email.CellTemplate = new DataGridViewTextBoxCell();
                column_email.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(10, column_email);

            //internetcsomag
            DataGridViewTextBoxColumn column_internetcsomag = new DataGridViewTextBoxColumn();
            {
                column_internetcsomag.HeaderText = "Internetcsomag";
                column_internetcsomag.Name = "internetcsomag";
                column_internetcsomag.CellTemplate = new DataGridViewTextBoxCell();
                column_internetcsomag.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_internetcsomag.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(11, column_internetcsomag);

            //fizetesi mod
            DataGridViewTextBoxColumn column_fizetesimod = new DataGridViewTextBoxColumn();
            {
                column_fizetesimod.HeaderText = "Fizetési mód";
                column_fizetesimod.Name = "fizetesimod";
                column_fizetesimod.CellTemplate = new DataGridViewTextBoxCell();
                column_fizetesimod.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_fizetesimod.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(12, column_fizetesimod);

            //megjegyzés
            DataGridViewTextBoxColumn column_megjegyzes = new DataGridViewTextBoxColumn();
            {
                column_megjegyzes.HeaderText = "Megjegyzés";
                column_megjegyzes.Name = "megjegyzes";
                column_megjegyzes.CellTemplate = new DataGridViewTextBoxCell();
                column_megjegyzes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column_megjegyzes.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dataGridView1.Columns.Insert(13, column_megjegyzes);

            Program.sqlparancs = Program.conn.CreateCommand();
            Program.sqlparancs.CommandText = "SELECT * FROM `users`";
            MySqlDataReader sqldatareader = Program.sqlparancs.ExecuteReader();


            //cellafeltöltés
            while (sqldatareader.Read())
            {

                int uj_sor_index = dataGridView1.Rows.Add();
                DataGridViewRow uj_sor = dataGridView1.Rows[uj_sor_index];
                uj_sor.Cells["id"].Value = sqldatareader.GetInt32("id");
                uj_sor.Cells["elofizetoneve"].Value = sqldatareader.GetString("elofizetoneve");
                uj_sor.Cells["szuletesineve"].Value = sqldatareader.GetString("szuletesineve");
                uj_sor.Cells["szuletesihely"].Value = sqldatareader.GetString("szuletesihely");
                uj_sor.Cells["szuletesiido"].Value = sqldatareader.GetString("szuletesiido");
                uj_sor.Cells["anyjaneve"].Value = sqldatareader.GetString("anyjaszuletesineve");
                uj_sor.Cells["szemelyiszam"].Value = sqldatareader.GetString("szemelyiszam");
                uj_sor.Cells["telepitesicim"].Value = sqldatareader.GetString("telepitesicim");
                uj_sor.Cells["postazasicim"].Value = sqldatareader.GetString("postazasicim");
                uj_sor.Cells["telefon"].Value = sqldatareader.GetString("telefonszam");
                uj_sor.Cells["email"].Value = sqldatareader.GetString("email");
                uj_sor.Cells["internetcsomag"].Value = sqldatareader.GetInt32("internetcsomag");
                uj_sor.Cells["fizetesimod"].Value = sqldatareader.GetString("fizetesimod");
                uj_sor.Cells["megjegyzes"].Value = sqldatareader.GetString("megjegyzes");

            }

            Program.conn.Close();


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
    }
}

