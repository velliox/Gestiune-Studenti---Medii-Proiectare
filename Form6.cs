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
    public partial class Form6 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalStudenti;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.studentiRaport' table. You can move, or remove it, as needed.
            this.raportProcentTableAdapter.Fill(this.DataSet1.raportProcent);
            this.reportViewer1.RefreshReport();
            con = raportProcentTableAdapter.Connection;
            cmd.Connection = con;

            cmd.CommandText = "select count(an_facultate) as Total from studenti";

            con.Open();

            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalStudenti = rdr.GetInt32(0);
            con.Close();
            rdr.Close();


            foreach(DataRow r in DataSet1.raportProcent)
            {
                decimal x;
                x = Convert.ToDecimal(r["NumarStudenti"])/Convert.ToDecimal(totalStudenti);
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
            reportViewer1.RefreshReport();
        }
    }
}
