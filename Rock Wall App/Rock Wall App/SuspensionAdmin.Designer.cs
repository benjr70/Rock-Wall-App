namespace Rock_Wall_App
{
    partial class SuspensionAdmin
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
            System.Windows.Forms.Label idnumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label belayLabel;
            System.Windows.Forms.Label leadLabel;
            System.Windows.Forms.Label suspensionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuspensionAdmin));
            this.suspensionsDataSet = new Rock_Wall_App.suspensionsDataSet();
            this.suspensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suspensionTableAdapter = new Rock_Wall_App.suspensionsDataSetTableAdapters.suspensionTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.suspensionsDataSetTableAdapters.TableAdapterManager();
            this.suspensionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.idnumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.belayCheckBox = new System.Windows.Forms.CheckBox();
            this.leadCheckBox = new System.Windows.Forms.CheckBox();
            this.suspensionCheckBox = new System.Windows.Forms.CheckBox();
            this.Grant = new System.Windows.Forms.Button();
            this.Deny = new System.Windows.Forms.Button();
            idnumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            belayLabel = new System.Windows.Forms.Label();
            leadLabel = new System.Windows.Forms.Label();
            suspensionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suspensionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspensionBindingNavigator)).BeginInit();
            this.suspensionBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idnumberLabel
            // 
            idnumberLabel.AutoSize = true;
            idnumberLabel.Location = new System.Drawing.Point(119, 109);
            idnumberLabel.Name = "idnumberLabel";
            idnumberLabel.Size = new System.Drawing.Size(57, 13);
            idnumberLabel.TabIndex = 1;
            idnumberLabel.Text = "Id number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(119, 135);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // belayLabel
            // 
            belayLabel.AutoSize = true;
            belayLabel.Location = new System.Drawing.Point(119, 163);
            belayLabel.Name = "belayLabel";
            belayLabel.Size = new System.Drawing.Size(36, 13);
            belayLabel.TabIndex = 5;
            belayLabel.Text = "Belay:";
            // 
            // leadLabel
            // 
            leadLabel.AutoSize = true;
            leadLabel.Location = new System.Drawing.Point(119, 193);
            leadLabel.Name = "leadLabel";
            leadLabel.Size = new System.Drawing.Size(30, 13);
            leadLabel.TabIndex = 7;
            leadLabel.Text = "lead:";
            // 
            // suspensionLabel
            // 
            suspensionLabel.AutoSize = true;
            suspensionLabel.Location = new System.Drawing.Point(119, 223);
            suspensionLabel.Name = "suspensionLabel";
            suspensionLabel.Size = new System.Drawing.Size(65, 13);
            suspensionLabel.TabIndex = 9;
            suspensionLabel.Text = "Suspension:";
            // 
            // suspensionsDataSet
            // 
            this.suspensionsDataSet.DataSetName = "suspensionsDataSet";
            this.suspensionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suspensionBindingSource
            // 
            this.suspensionBindingSource.DataMember = "suspension";
            this.suspensionBindingSource.DataSource = this.suspensionsDataSet;
            // 
            // suspensionTableAdapter
            // 
            this.suspensionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.suspensionTableAdapter = this.suspensionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rock_Wall_App.suspensionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suspensionBindingNavigator
            // 
            this.suspensionBindingNavigator.AddNewItem = null;
            this.suspensionBindingNavigator.BindingSource = this.suspensionBindingSource;
            this.suspensionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suspensionBindingNavigator.DeleteItem = null;
            this.suspensionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem});
            this.suspensionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suspensionBindingNavigator.MoveFirstItem = null;
            this.suspensionBindingNavigator.MoveLastItem = null;
            this.suspensionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suspensionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suspensionBindingNavigator.Name = "suspensionBindingNavigator";
            this.suspensionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suspensionBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.suspensionBindingNavigator.TabIndex = 0;
            this.suspensionBindingNavigator.Text = "bindingNavigator1";
            this.suspensionBindingNavigator.RefreshItems += new System.EventHandler(this.suspensionBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // idnumberTextBox
            // 
            this.idnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suspensionBindingSource, "Idnumber", true));
            this.idnumberTextBox.Enabled = false;
            this.idnumberTextBox.Location = new System.Drawing.Point(190, 106);
            this.idnumberTextBox.Name = "idnumberTextBox";
            this.idnumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.idnumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suspensionBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(190, 132);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // belayCheckBox
            // 
            this.belayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.suspensionBindingSource, "Belay", true));
            this.belayCheckBox.Enabled = false;
            this.belayCheckBox.Location = new System.Drawing.Point(190, 158);
            this.belayCheckBox.Name = "belayCheckBox";
            this.belayCheckBox.Size = new System.Drawing.Size(104, 24);
            this.belayCheckBox.TabIndex = 6;
            this.belayCheckBox.UseVisualStyleBackColor = true;
            // 
            // leadCheckBox
            // 
            this.leadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.suspensionBindingSource, "lead", true));
            this.leadCheckBox.Enabled = false;
            this.leadCheckBox.Location = new System.Drawing.Point(190, 188);
            this.leadCheckBox.Name = "leadCheckBox";
            this.leadCheckBox.Size = new System.Drawing.Size(104, 24);
            this.leadCheckBox.TabIndex = 8;
            this.leadCheckBox.UseVisualStyleBackColor = true;
            // 
            // suspensionCheckBox
            // 
            this.suspensionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.suspensionBindingSource, "Suspension", true));
            this.suspensionCheckBox.Enabled = false;
            this.suspensionCheckBox.Location = new System.Drawing.Point(190, 218);
            this.suspensionCheckBox.Name = "suspensionCheckBox";
            this.suspensionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.suspensionCheckBox.TabIndex = 10;
            this.suspensionCheckBox.UseVisualStyleBackColor = true;
            // 
            // Grant
            // 
            this.Grant.Location = new System.Drawing.Point(122, 290);
            this.Grant.Name = "Grant";
            this.Grant.Size = new System.Drawing.Size(75, 23);
            this.Grant.TabIndex = 11;
            this.Grant.Text = "Grant";
            this.Grant.UseVisualStyleBackColor = true;
            this.Grant.Click += new System.EventHandler(this.Grant_Click);
            // 
            // Deny
            // 
            this.Deny.Location = new System.Drawing.Point(219, 290);
            this.Deny.Name = "Deny";
            this.Deny.Size = new System.Drawing.Size(75, 23);
            this.Deny.TabIndex = 12;
            this.Deny.Text = "Deny";
            this.Deny.UseVisualStyleBackColor = true;
            this.Deny.Click += new System.EventHandler(this.Deny_Click);
            // 
            // SuspensionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 441);
            this.Controls.Add(this.Deny);
            this.Controls.Add(this.Grant);
            this.Controls.Add(idnumberLabel);
            this.Controls.Add(this.idnumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(belayLabel);
            this.Controls.Add(this.belayCheckBox);
            this.Controls.Add(leadLabel);
            this.Controls.Add(this.leadCheckBox);
            this.Controls.Add(suspensionLabel);
            this.Controls.Add(this.suspensionCheckBox);
            this.Controls.Add(this.suspensionBindingNavigator);
            this.Name = "SuspensionAdmin";
            this.Text = "SuspensionAdmin";
            this.Load += new System.EventHandler(this.SuspensionAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suspensionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suspensionBindingNavigator)).EndInit();
            this.suspensionBindingNavigator.ResumeLayout(false);
            this.suspensionBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private suspensionsDataSet suspensionsDataSet;
        private System.Windows.Forms.BindingSource suspensionBindingSource;
        private suspensionsDataSetTableAdapters.suspensionTableAdapter suspensionTableAdapter;
        private suspensionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suspensionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.TextBox idnumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox belayCheckBox;
        private System.Windows.Forms.CheckBox leadCheckBox;
        private System.Windows.Forms.CheckBox suspensionCheckBox;
        private System.Windows.Forms.Button Grant;
        private System.Windows.Forms.Button Deny;
    }
}