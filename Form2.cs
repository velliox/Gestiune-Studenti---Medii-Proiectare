using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaciuAndreiProject
{
    public partial class Form2 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet1.persoane);
            // TODO: This line of code loads data into the 'dataSet1.persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dataSet1.persoane);
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
        }

        public bool checkBeforeAdauga()
        {
            //if (txtNume.Text == "" || !Regex.IsMatch(txtNume.Text, @"[a-zA-Z]"))
            //{
            //    MessageBox.Show("Completeaza nume");
            //    return false;
            //}

            if (Regex.IsMatch(txtNume.Text, @"[^a-zA-Z]") || txtNume.Text=="")
            {
                MessageBox.Show("Completeaza nume/ Nume incorect");
                return false;
            }



            if (Regex.IsMatch(txtPrenume.Text, @"[^a-zA-Z-]") || txtPrenume.Text == "")
            {
                MessageBox.Show("Completeaza prenume");
                return false;
            }
            return true;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (checkBeforeAdauga())
            {
                string listaCampuri = "nume, prenume";
                string listaValori;

                con.Open();
                listaValori ="'" +txtNume.Text + "', '" + txtPrenume.Text + "'";

                cmd.CommandText = "Insert into persoane(" + listaCampuri + ") " + " Values(" + listaValori + ");";

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                con.Close();
                refreshGrid();
            }
        }

        private void refreshGrid()
        {
            persoaneTableAdapter.Fill(dataSet1.persoane);
        }
    }
}
