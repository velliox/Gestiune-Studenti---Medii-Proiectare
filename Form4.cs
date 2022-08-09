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
    public partial class Form4 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public bool promov2 = false;
        public bool promov1 = false;
        public bool absolv1 = true;
        public bool flagExista = true;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.schemaStudentiNonAbs' table. You can move, or remove it, as needed.
            this.schemaStudentiNonAbsTableAdapter.Fill(this.dataSet11.schemaStudentiNonAbs);
            // TODO: This line of code loads data into the 'dataSet1.schemaStudenti' table. You can move, or remove it, as needed.
            con.ConnectionString = schemaStudentiNonAbsTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            A1();
        }

        private void A1()
        {
            btnPromovare1.Visible = promov1;
            btnPromovare2.Visible = promov2;
            btnAbsolvire.Visible = absolv1;
        }


        private void btnAbsolvire_Click(object sender, EventArgs e)
        {
            List<string> myIDs = new List<string>();
            con.Open();
            cmd.CommandText = "select id_student from studenti where an_facultate = 3";
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                //Console.WriteLine("cica are");
                while (rdr.Read())
                {
                    myIDs.Add(rdr.GetInt32(0).ToString());
                }
                flagExista = true;
            }
            else
            {
                MessageBox.Show("Nu exista studenti in anul 3 de facultate!");
            }
            rdr.Close();
            con.Close();
            if (flagExista)
            {
                con.Open();
                cmd.CommandText = "update studenti set an_facultate=0, is_absolvent=1 where an_facultate=3";
                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //cmd.CommandText = "update studenti set is_absolvent= 1 where an_facultate =0";
                //cmd.ExecuteNonQuery();
                //con.Close();

                refreshGrid();
            }

            



            promov1 = true;
            absolv1 = false;
            A1();
        }

        private void refreshGrid()
        {
            schemaStudentiNonAbsTableAdapter.Fill(dataSet11.schemaStudentiNonAbs);
        }


        private void btnPromovare1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "update studenti set an_facultate=3 where an_facultate=2";
            cmd.ExecuteNonQuery();
            con.Close();

            promov2 = true;
            promov1 = false;
            A1();
            refreshGrid();
        }

        private void btnPromovare2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "update studenti set an_facultate=2 where an_facultate=1";
            cmd.ExecuteNonQuery();
            con.Close();

            promov2 = true;
            promov1 = false;

            A1();
            refreshGrid();
        }
    }
}
