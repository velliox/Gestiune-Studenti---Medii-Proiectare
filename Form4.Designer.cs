
namespace BaciuAndreiProject
{
    partial class Form4
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
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anfacultateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schemaStudentiNonAbsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new BaciuAndreiProject.DataSet1();
            this.btnPromovare2 = new System.Windows.Forms.Button();
            this.btnPromovare1 = new System.Windows.Forms.Button();
            this.btnAbsolvire = new System.Windows.Forms.Button();
            this.dataSet1 = new BaciuAndreiProject.DataSet1();
            this.schemaStudentiNonAbsTableAdapter = new BaciuAndreiProject.DataSet1TableAdapters.schemaStudentiNonAbsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaStudentiNonAbsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.idstudentDataGridViewTextBoxColumn,
            this.anfacultateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.schemaStudentiNonAbsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 207);
            this.dataGridView1.TabIndex = 0;
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
            // schemaStudentiNonAbsBindingSource
            // 
            this.schemaStudentiNonAbsBindingSource.DataMember = "schemaStudentiNonAbs";
            this.schemaStudentiNonAbsBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPromovare2
            // 
            this.btnPromovare2.Location = new System.Drawing.Point(979, 62);
            this.btnPromovare2.Name = "btnPromovare2";
            this.btnPromovare2.Size = new System.Drawing.Size(98, 23);
            this.btnPromovare2.TabIndex = 1;
            this.btnPromovare2.Text = "Promovare";
            this.btnPromovare2.UseVisualStyleBackColor = true;
            this.btnPromovare2.Click += new System.EventHandler(this.btnPromovare2_Click);
            // 
            // btnPromovare1
            // 
            this.btnPromovare1.Location = new System.Drawing.Point(979, 60);
            this.btnPromovare1.Name = "btnPromovare1";
            this.btnPromovare1.Size = new System.Drawing.Size(98, 23);
            this.btnPromovare1.TabIndex = 2;
            this.btnPromovare1.Text = "Promovare";
            this.btnPromovare1.UseVisualStyleBackColor = true;
            this.btnPromovare1.Click += new System.EventHandler(this.btnPromovare1_Click);
            // 
            // btnAbsolvire
            // 
            this.btnAbsolvire.Location = new System.Drawing.Point(979, 62);
            this.btnAbsolvire.Name = "btnAbsolvire";
            this.btnAbsolvire.Size = new System.Drawing.Size(98, 27);
            this.btnAbsolvire.TabIndex = 3;
            this.btnAbsolvire.Text = "Absolvire";
            this.btnAbsolvire.UseVisualStyleBackColor = true;
            this.btnAbsolvire.Click += new System.EventHandler(this.btnAbsolvire_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schemaStudentiNonAbsTableAdapter
            // 
            this.schemaStudentiNonAbsTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 476);
            this.Controls.Add(this.btnAbsolvire);
            this.Controls.Add(this.btnPromovare1);
            this.Controls.Add(this.btnPromovare2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaStudentiNonAbsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btnPromovare2;
        private System.Windows.Forms.Button btnPromovare1;
        private System.Windows.Forms.Button btnAbsolvire;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource schemaStudentiNonAbsBindingSource;
        private DataSet1TableAdapters.schemaStudentiNonAbsTableAdapter schemaStudentiNonAbsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anfacultateDataGridViewTextBoxColumn;
    }
}