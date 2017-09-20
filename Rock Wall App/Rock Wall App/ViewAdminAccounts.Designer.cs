namespace Rock_Wall_App
{
    partial class ViewAdminAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAdminAccounts));
            this.accountsDBDataSet = new Rock_Wall_App.AccountsDBDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new Rock_Wall_App.AccountsDBDataSetTableAdapters.AdminsTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.AccountsDBDataSetTableAdapters.TableAdapterManager();
            this.adminsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.adminsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adminsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingNavigator)).BeginInit();
            this.adminsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsDBDataSet
            // 
            this.accountsDBDataSet.DataSetName = "AccountsDBDataSet";
            this.accountsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.accountsDBDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminsTableAdapter = this.adminsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.AccountsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminsBindingNavigator
            // 
            this.adminsBindingNavigator.AddNewItem = null;
            this.adminsBindingNavigator.BindingSource = this.adminsBindingSource;
            this.adminsBindingNavigator.CountItem = null;
            this.adminsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adminsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.adminsBindingNavigatorSaveItem});
            this.adminsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adminsBindingNavigator.MoveFirstItem = null;
            this.adminsBindingNavigator.MoveLastItem = null;
            this.adminsBindingNavigator.MoveNextItem = null;
            this.adminsBindingNavigator.MovePreviousItem = null;
            this.adminsBindingNavigator.Name = "adminsBindingNavigator";
            this.adminsBindingNavigator.PositionItem = null;
            this.adminsBindingNavigator.Size = new System.Drawing.Size(656, 25);
            this.adminsBindingNavigator.TabIndex = 0;
            this.adminsBindingNavigator.Text = "bindingNavigator1";
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
            // adminsBindingNavigatorSaveItem
            // 
            this.adminsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adminsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adminsBindingNavigatorSaveItem.Image")));
            this.adminsBindingNavigatorSaveItem.Name = "adminsBindingNavigatorSaveItem";
            this.adminsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.adminsBindingNavigatorSaveItem.Text = "Save Data";
            this.adminsBindingNavigatorSaveItem.Click += new System.EventHandler(this.adminsBindingNavigatorSaveItem_Click);
            // 
            // adminsDataGridView
            // 
            this.adminsDataGridView.AutoGenerateColumns = false;
            this.adminsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.adminsDataGridView.DataSource = this.adminsBindingSource;
            this.adminsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.adminsDataGridView.Name = "adminsDataGridView";
            this.adminsDataGridView.Size = new System.Drawing.Size(643, 471);
            this.adminsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ViewAdminAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 511);
            this.Controls.Add(this.adminsDataGridView);
            this.Controls.Add(this.adminsBindingNavigator);
            this.Name = "ViewAdminAccounts";
            this.Text = "ViewAdminAccounts";
            this.Load += new System.EventHandler(this.ViewAdminAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingNavigator)).EndInit();
            this.adminsBindingNavigator.ResumeLayout(false);
            this.adminsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountsDBDataSet accountsDBDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private AccountsDBDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private AccountsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adminsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton adminsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView adminsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}