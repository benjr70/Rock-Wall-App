namespace Rock_Wall_App
{
    partial class Incident_report_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incident_report_admin));
            this.incidentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.incidentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Rock_Wall_App.ReportsDataSet();
            this.incidentTableAdapter = new Rock_Wall_App.ReportsDataSetTableAdapters.IncidentTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.ReportsDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingNavigator)).BeginInit();
            this.incidentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentBindingNavigator
            // 
            this.incidentBindingNavigator.AddNewItem = null;
            this.incidentBindingNavigator.BindingSource = this.incidentBindingSource;
            this.incidentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incidentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incidentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.incidentBindingNavigatorSaveItem});
            this.incidentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incidentBindingNavigator.MoveFirstItem = null;
            this.incidentBindingNavigator.MoveLastItem = null;
            this.incidentBindingNavigator.MoveNextItem = null;
            this.incidentBindingNavigator.MovePreviousItem = null;
            this.incidentBindingNavigator.Name = "incidentBindingNavigator";
            this.incidentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incidentBindingNavigator.Size = new System.Drawing.Size(1257, 25);
            this.incidentBindingNavigator.TabIndex = 0;
            this.incidentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // incidentBindingNavigatorSaveItem
            // 
            this.incidentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incidentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incidentBindingNavigatorSaveItem.Image")));
            this.incidentBindingNavigatorSaveItem.Name = "incidentBindingNavigatorSaveItem";
            this.incidentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.incidentBindingNavigatorSaveItem.Text = "Save Data";
            this.incidentBindingNavigatorSaveItem.Click += new System.EventHandler(this.incidentBindingNavigatorSaveItem_Click);
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowDrop = true;
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AutoGenerateColumns = false;
            this.incidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.patronNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.incidentDataGridView.DataSource = this.incidentBindingSource;
            this.incidentDataGridView.Location = new System.Drawing.Point(12, 28);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.Size = new System.Drawing.Size(1233, 380);
            this.incidentDataGridView.TabIndex = 1;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.Width = 79;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // patronNameDataGridViewTextBoxColumn
            // 
            this.patronNameDataGridViewTextBoxColumn.DataPropertyName = "PatronName";
            this.patronNameDataGridViewTextBoxColumn.HeaderText = "PatronName";
            this.patronNameDataGridViewTextBoxColumn.Name = "patronNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MaxInputLength = 1000;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IncidentTableAdapter = this.incidentTableAdapter;
            this.tableAdapterManager.reportsTableAdapter = null;
            this.tableAdapterManager.SuspenstionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Incident_report_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 429);
            this.Controls.Add(this.incidentDataGridView);
            this.Controls.Add(this.incidentBindingNavigator);
            this.Name = "Incident_report_admin";
            this.Text = "Incident_report_admin";
            this.Load += new System.EventHandler(this.Incident_report_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingNavigator)).EndInit();
            this.incidentBindingNavigator.ResumeLayout(false);
            this.incidentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private ReportsDataSetTableAdapters.IncidentTableAdapter incidentTableAdapter;
        private ReportsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incidentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton incidentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}