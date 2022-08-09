using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaciuAndreiProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.graphTA' table. You can move, or remove it, as needed.
            this.graphTATableAdapter.Fill(this.dataSet1.graphTA);
            // TODO: This line of code loads data into the 'dataSet1.studenti' table. You can move, or remove it, as needed.

        }
    }
}
