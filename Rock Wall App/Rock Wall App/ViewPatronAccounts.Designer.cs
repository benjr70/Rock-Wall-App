namespace Rock_Wall_App
{
    partial class ViewPatronAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatronAccounts));
            this.patronsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.patronsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patronsDataGridView = new System.Windows.Forms.DataGridView();
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsDataSet = new Rock_Wall_App.PatronsDataSet();
            this.patronsTableAdapter = new Rock_Wall_App.PatronsDataSetTableAdapters.PatronsTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.PatronsDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Belaycert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leadcert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).BeginInit();
            this.patronsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patronsBindingNavigator
            // 
            this.patronsBindingNavigator.AddNewItem = null;
            this.patronsBindingNavigator.BindingSource = this.patronsBindingSource;
            this.patronsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patronsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patronsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.patronsBindingNavigatorSaveItem});
            this.patronsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronsBindingNavigator.MoveFirstItem = null;
            this.patronsBindingNavigator.MoveLastItem = null;
            this.patronsBindingNavigator.MoveNextItem = null;
            this.patronsBindingNavigator.MovePreviousItem = null;
            this.patronsBindingNavigator.Name = "patronsBindingNavigator";
            this.patronsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patronsBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.patronsBindingNavigator.TabIndex = 0;
            this.patronsBindingNavigator.Text = "bindingNavigator1";
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
            // patronsBindingNavigatorSaveItem
            // 
            this.patronsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patronsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patronsBindingNavigatorSaveItem.Image")));
            this.patronsBindingNavigatorSaveItem.Name = "patronsBindingNavigatorSaveItem";
            this.patronsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patronsBindingNavigatorSaveItem.Text = "Save Data";
            this.patronsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patronsBindingNavigatorSaveItem_Click);
            // 
            // patronsDataGridView
            // 
            this.patronsDataGridView.AllowUserToAddRows = false;
            this.patronsDataGridView.AutoGenerateColumns = false;
            this.patronsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn3,
            this.Belaycert,
            this.leadcert});
            this.patronsDataGridView.DataSource = this.patronsBindingSource;
            this.patronsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.patronsDataGridView.Name = "patronsDataGridView";
            this.patronsDataGridView.Size = new System.Drawing.Size(843, 356);
            this.patronsDataGridView.TabIndex = 1;
            // 
            // patronsBindingSource
            // 
            this.patronsBindingSource.DataMember = "Patrons";
            this.patronsBindingSource.DataSource = this.patronsDataSet;
            // 
            // patronsDataSet
            // 
            this.patronsDataSet.DataSetName = "PatronsDataSet";
            this.patronsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronsTableAdapter
            // 
            this.patronsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatronsTableAdapter = this.patronsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.PatronsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Suspension";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Suspension";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // Belaycert
            // 
            this.Belaycert.DataPropertyName = "Belaycert";
            this.Belaycert.HeaderText = "Belaycert";
            this.Belaycert.Name = "Belaycert";
            // 
            // leadcert
            // 
            this.leadcert.DataPropertyName = "leadcert";
            this.leadcert.HeaderText = "leadcert";
            this.leadcert.Name = "leadcert";
            // 
            // ViewPatronAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 386);
            this.Controls.Add(this.patronsDataGridView);
            this.Controls.Add(this.patronsBindingNavigator);
            this.Name = "ViewPatronAccounts";
            this.Text = "ViewPatronAccounts";
            this.Load += new System.EventHandler(this.ViewPatronAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).EndInit();
            this.patronsBindingNavigator.ResumeLayout(false);
            this.patronsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PatronsDataSet patronsDataSet;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private PatronsDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private PatronsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patronsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton patronsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        public System.Windows.Forms.DataGridView patronsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Belaycert;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leadcert;
    }
}