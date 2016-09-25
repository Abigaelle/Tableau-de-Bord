namespace TableauDeBord
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbeLitsOccupesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbeLitsTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableaudebordDataSet1 = new TableauDeBord.tableaudebordDataSet1();
            this.occupationTableAdapter = new TableauDeBord.tableaudebordDataSet1TableAdapters.OccupationTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Taux d\'occupation des lits de l\'hopital :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moisDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.nbeLitsOccupesDataGridViewTextBoxColumn,
            this.nbeLitsTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.occupationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // moisDataGridViewTextBoxColumn
            // 
            this.moisDataGridViewTextBoxColumn.DataPropertyName = "Mois";
            this.moisDataGridViewTextBoxColumn.HeaderText = "Mois";
            this.moisDataGridViewTextBoxColumn.Name = "moisDataGridViewTextBoxColumn";
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            // 
            // nbeLitsOccupesDataGridViewTextBoxColumn
            // 
            this.nbeLitsOccupesDataGridViewTextBoxColumn.DataPropertyName = "NbeLitsOccupes";
            this.nbeLitsOccupesDataGridViewTextBoxColumn.HeaderText = "NbeLitsOccupes";
            this.nbeLitsOccupesDataGridViewTextBoxColumn.Name = "nbeLitsOccupesDataGridViewTextBoxColumn";
            // 
            // nbeLitsTotalDataGridViewTextBoxColumn
            // 
            this.nbeLitsTotalDataGridViewTextBoxColumn.DataPropertyName = "NbeLitsTotal";
            this.nbeLitsTotalDataGridViewTextBoxColumn.HeaderText = "NbeLitsTotal";
            this.nbeLitsTotalDataGridViewTextBoxColumn.Name = "nbeLitsTotalDataGridViewTextBoxColumn";
            // 
            // occupationBindingSource
            // 
            this.occupationBindingSource.DataMember = "Occupation";
            this.occupationBindingSource.DataSource = this.tableaudebordDataSet1;
            // 
            // tableaudebordDataSet1
            // 
            this.tableaudebordDataSet1.DataSetName = "tableaudebordDataSet1";
            this.tableaudebordDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupationTableAdapter
            // 
            this.occupationTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afficher le pourcentage par mois";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(562, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableaudebordDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tableaudebordDataSet1 tableaudebordDataSet1;
        private System.Windows.Forms.BindingSource occupationBindingSource;
        private tableaudebordDataSet1TableAdapters.OccupationTableAdapter occupationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbeLitsOccupesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbeLitsTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}