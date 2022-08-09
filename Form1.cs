using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaciuAndreiProject
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            //lblTitlu.Visible = !v;
            /*            lblAutor.Visible = v;
                        lblTitlu.Visible = v;*/
            lblPass.Visible = v;
            txtPass.Visible = v;
            lblUser.Visible = v;
            txtUser.Visible = v;
            if (v) btnStart.Text = "Let me in";
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUser.Focus();
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtPass.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Sebi\\Documents\\University\\MPP\\BaciuAndrei-Proiect\\Database3.accdb";

            cmd.Connection = con;
            cmd.CommandText = "Select username, password from users " +
                              "where username='" + txtUser.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtPass.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtPass.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                MessageBox.Show("Logare efectuata");
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUser.Focus();
                con.Close();
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Let me in")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nForm = new Form2();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void inscrieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nForm = new Form3();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void evaluareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm = new Form4();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 nForm = new Form5();
            nForm.TopLevel = true;
            nForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 nForm = new Form6();
            nForm.TopLevel = true;
            nForm.Show();
        }
    }
}
