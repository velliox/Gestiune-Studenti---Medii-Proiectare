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
    public partial class Form3 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.schemaStudenti' table. You can move, or remove it, as needed.
            this.schemaStudentiTableAdapter.Fill(this.dataSet1.schemaStudenti);
            // TODO: This line of code loads data into the 'dataSet1.persoaneDeAdaugat' table. You can move, or remove it, as needed.
            this.persoaneDeAdaugatTableAdapter.Fill(this.dataSet1.persoaneDeAdaugat);
            // TODO: This line of code loads data into the 'dataSet11.schemaStudenti' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet1.persoaneDeAdaugat' table. You can move, or remove it, as needed.
            this.persoaneDeAdaugatTableAdapter.Fill(this.dataSet1.persoaneDeAdaugat);

            // TODO: This line of code loads data into the 'dataSet1.persoane' table. You can move, or remove it, as needed.
            con.ConnectionString = persoaneDeAdaugatTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;


        }

        private void btnInscriere_Click(object sender, EventArgs e)
        {
            adaugaStudent();
        }

        private void adaugaStudent()
        {
            string listaCampuri = "id_pers";
            string listaValori;

            List<String> myIDs = new List<String>();
            con.Open();
            cmd.CommandText = "select id_pers from persoane where is_student = 0";
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("My id_pers is " + rdr.GetInt32(0).ToString());
                    myIDs.Add(rdr.GetInt32(0).ToString());
                }
            }
            rdr.Close();
            con.Close();



            listaCampuri = "id_pers";

            con.Open();

            foreach (var term in myIDs)
            {
                Console.WriteLine(term);
                cmd.CommandText = "Insert into studenti(" + listaCampuri + ") " + " Values('" + term + "');";
                cmd.ExecuteNonQuery();
            }

            con.Close();



            //
            listaCampuri = "is_student";

            con.Open();

            foreach (var term in myIDs)
            {
                Console.WriteLine(term);
                cmd.CommandText = "Update persoane set is_student=1 where id_pers="+ term+"";
                cmd.ExecuteNonQuery();
            }

            con.Close();


            refreshGrid();
        }

        private void refreshGrid()
        {
            schemaStudentiTableAdapter.Fill(dataSet1.schemaStudenti);
            persoaneDeAdaugatTableAdapter.Fill(dataSet1.persoaneDeAdaugat);
        }
    }
}
