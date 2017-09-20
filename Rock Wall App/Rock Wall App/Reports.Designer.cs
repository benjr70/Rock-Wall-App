namespace Rock_Wall_App
{
    partial class Reports
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Rock_Wall_App.ReportsDataSet();
            this.reportsTableAdapter = new Rock_Wall_App.ReportsDataSetTableAdapters.reportsTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.ReportsDataSetTableAdapters.TableAdapterManager();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate new report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "reports";
            this.reportsBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IncidentTableAdapter = null;
            this.tableAdapterManager.reportsTableAdapter = this.reportsTableAdapter;
            this.tableAdapterManager.SuspenstionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.AllowUserToAddRows = false;
            this.reportsDataGridView.AllowUserToDeleteRows = false;
            this.reportsDataGridView.AutoGenerateColumns = false;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.reportsDataGridView.DataSource = this.reportsBindingSource;
            this.reportsDataGridView.Location = new System.Drawing.Point(205, 37);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.Size = new System.Drawing.Size(350, 344);
            this.reportsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.HeaderText = "date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 393);
            this.Controls.Add(this.reportsDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private ReportsDataSetTableAdapters.reportsTableAdapter reportsTableAdapter;
        private ReportsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView reportsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}