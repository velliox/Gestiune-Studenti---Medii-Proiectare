
namespace BaciuAndreiProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnInscriere = new System.Windows.Forms.Button();
            this.dataSet1 = new BaciuAndreiProject.DataSet1();
            this.persoaneDeAdaugatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoaneDeAdaugatTableAdapter = new BaciuAndreiProject.DataSet1TableAdapters.persoaneDeAdaugatTableAdapter();
            this.idpersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isstudentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.schemaStudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schemaStudentiTableAdapter = new BaciuAndreiProject.DataSet1TableAdapters.schemaStudentiTableAdapter();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anfacultateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isabsolventDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneDeAdaugatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaStudentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.isstudentDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.persoaneDeAdaugatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn1,
            this.prenumeDataGridViewTextBoxColumn1,
            this.idstudentDataGridViewTextBoxColumn,
            this.anfacultateDataGridViewTextBoxColumn,
            this.isabsolventDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.schemaStudentiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(40, 253);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(571, 231);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnInscriere
            // 
            this.btnInscriere.Location = new System.Drawing.Point(682, 40);
            this.btnInscriere.Name = "btnInscriere";
            this.btnInscriere.Size = new System.Drawing.Size(106, 42);
            this.btnInscriere.TabIndex = 2;
            this.btnInscriere.Text = "Inscriere";
            this.btnInscriere.UseVisualStyleBackColor = true;
            this.btnInscriere.Click += new System.EventHandler(this.btnInscriere_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // persoaneDeAdaugatBindingSource
            // 
            this.persoaneDeAdaugatBindingSource.DataMember = "persoaneDeAdaugat";
            this.persoaneDeAdaugatBindingSource.DataSource = this.dataSet1;
            // 
            // persoaneDeAdaugatTableAdapter
            // 
            this.persoaneDeAdaugatTableAdapter.ClearBeforeFill = true;
            // 
            // idpersDataGridViewTextBoxColumn
            // 
            this.idpersDataGridViewTextBoxColumn.DataPropertyName = "id_pers";
            this.idpersDataGridViewTextBoxColumn.HeaderText = "id_pers";
            this.idpersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpersDataGridViewTextBoxColumn.Name = "idpersDataGridViewTextBoxColumn";
            this.idpersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isstudentDataGridViewCheckBoxColumn
            // 
            this.isstudentDataGridViewCheckBoxColumn.DataPropertyName = "is_student";
            this.isstudentDataGridViewCheckBoxColumn.HeaderText = "is_student";
            this.isstudentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isstudentDataGridViewCheckBoxColumn.Name = "isstudentDataGridViewCheckBoxColumn";
            this.isstudentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isstudentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // schemaStudentiBindingSource
            // 
            this.schemaStudentiBindingSource.DataMember = "schemaStudenti";
            this.schemaStudentiBindingSource.DataSource = this.dataSet1;
            // 
            // schemaStudentiTableAdapter
            // 
            this.schemaStudentiTableAdapter.ClearBeforeFill = true;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            this.numeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn1
            // 
            this.prenumeDataGridViewTextBoxColumn1.DataPropertyName = "prenume";
            this.prenumeDataGridViewTextBoxColumn1.HeaderText = "prenume";
            this.prenumeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn1.Name = "prenumeDataGridViewTextBoxColumn1";
            this.prenumeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prenumeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // anfacultateDataGridViewTextBoxColumn
            // 
            this.anfacultateDataGridViewTextBoxColumn.DataPropertyName = "an_facultate";
            this.anfacultateDataGridViewTextBoxColumn.HeaderText = "an_facultate";
            this.anfacultateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anfacultateDataGridViewTextBoxColumn.Name = "anfacultateDataGridViewTextBoxColumn";
            this.anfacultateDataGridViewTextBoxColumn.ReadOnly = true;
            this.anfacultateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isabsolventDataGridViewCheckBoxColumn
            // 
            this.isabsolventDataGridViewCheckBoxColumn.DataPropertyName = "is_absolvent";
            this.isabsolventDataGridViewCheckBoxColumn.HeaderText = "is_absolvent";
            this.isabsolventDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isabsolventDataGridViewCheckBoxColumn.Name = "isabsolventDataGridViewCheckBoxColumn";
            this.isabsolventDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isabsolventDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 496);
            this.Controls.Add(this.btnInscriere);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneDeAdaugatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaStudentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnInscriere;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource persoaneDeAdaugatBindingSource;
        private DataSet1TableAdapters.persoaneDeAdaugatTableAdapter persoaneDeAdaugatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isstudentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource schemaStudentiBindingSource;
        private DataSet1TableAdapters.schemaStudentiTableAdapter schemaStudentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anfacultateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isabsolventDataGridViewCheckBoxColumn;
    }
}