namespace Rock_Wall_App
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.inventoryTableDataSet = new Rock_Wall_App.InventoryTableDataSet();
            this.inventoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableTableAdapter = new Rock_Wall_App.InventoryTableDataSetTableAdapters.InventoryTableTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.InventoryTableDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.inventoryTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventoryTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.inventoryTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingNavigator)).BeginInit();
            this.inventoryTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTableDataSet
            // 
            this.inventoryTableDataSet.DataSetName = "InventoryTableDataSet";
            this.inventoryTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableBindingSource
            // 
            this.inventoryTableBindingSource.DataMember = "InventoryTable";
            this.inventoryTableBindingSource.DataSource = this.inventoryTableDataSet;
            // 
            // inventoryTableTableAdapter
            // 
            this.inventoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InventoryTableTableAdapter = this.inventoryTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.InventoryTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // inventoryTableBindingNavigatorSaveItem
            // 
            this.inventoryTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryTableBindingNavigatorSaveItem.Image")));
            this.inventoryTableBindingNavigatorSaveItem.Name = "inventoryTableBindingNavigatorSaveItem";
            this.inventoryTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventoryTableBindingNavigatorSaveItem.Text = "Save Data";
            this.inventoryTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventoryTableBindingNavigatorSaveItem_Click);
            // 
            // inventoryTableBindingNavigator
            // 
            this.inventoryTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventoryTableBindingNavigator.BindingSource = this.inventoryTableBindingSource;
            this.inventoryTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventoryTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventoryTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inventoryTableBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.inventoryTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryTableBindingNavigator.MoveFirstItem = null;
            this.inventoryTableBindingNavigator.MoveLastItem = null;
            this.inventoryTableBindingNavigator.MoveNextItem = null;
            this.inventoryTableBindingNavigator.MovePreviousItem = null;
            this.inventoryTableBindingNavigator.Name = "inventoryTableBindingNavigator";
            this.inventoryTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventoryTableBindingNavigator.Size = new System.Drawing.Size(566, 25);
            this.inventoryTableBindingNavigator.TabIndex = 4;
            this.inventoryTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // inventoryTableDataGridView
            // 
            this.inventoryTableDataGridView.AutoGenerateColumns = false;
            this.inventoryTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.inventoryTableDataGridView.DataSource = this.inventoryTableBindingSource;
            this.inventoryTableDataGridView.Location = new System.Drawing.Point(0, 40);
            this.inventoryTableDataGridView.Name = "inventoryTableDataGridView";
            this.inventoryTableDataGridView.Size = new System.Drawing.Size(545, 446);
            this.inventoryTableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "item";
            this.dataGridViewTextBoxColumn1.HeaderText = "item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Purchase Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Purchase Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Replacement Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Replacement Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 510);
            this.Controls.Add(this.inventoryTableDataGridView);
            this.Controls.Add(this.inventoryTableBindingNavigator);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingNavigator)).EndInit();
            this.inventoryTableBindingNavigator.ResumeLayout(false);
            this.inventoryTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private InventoryTableDataSet inventoryTableDataSet;
        private System.Windows.Forms.BindingSource inventoryTableBindingSource;
        private InventoryTableDataSetTableAdapters.InventoryTableTableAdapter inventoryTableTableAdapter;
        private InventoryTableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton inventoryTableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator inventoryTableBindingNavigator;
        private System.Windows.Forms.DataGridView inventoryTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}