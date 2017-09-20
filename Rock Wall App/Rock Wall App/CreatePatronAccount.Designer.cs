namespace Rock_Wall_App
{
    partial class CreatePatronAccount
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label belay_cert_Label;
            System.Windows.Forms.Label lead_cert_Label;
            System.Windows.Forms.Label suspensionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePatronAccount));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.patronsDataSet = new Rock_Wall_App.PatronsDataSet();
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsTableAdapter = new Rock_Wall_App.PatronsDataSetTableAdapters.PatronsTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.PatronsDataSetTableAdapters.TableAdapterManager();
            this.patronsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patronsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.belay_cert_CheckBox = new System.Windows.Forms.CheckBox();
            this.lead_cert_CheckBox = new System.Windows.Forms.CheckBox();
            this.suspensionCheckBox = new System.Windows.Forms.CheckBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            idLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            belay_cert_Label = new System.Windows.Forms.Label();
            lead_cert_Label = new System.Windows.Forms.Label();
            suspensionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).BeginInit();
            this.patronsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(52, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 19;
            idLabel.Text = "Id:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(52, 67);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 21;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(52, 93);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 23;
            last_NameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(52, 119);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 25;
            genderLabel.Text = "Gender:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(52, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // belay_cert_Label
            // 
            belay_cert_Label.AutoSize = true;
            belay_cert_Label.Location = new System.Drawing.Point(52, 173);
            belay_cert_Label.Name = "belay_cert_Label";
            belay_cert_Label.Size = new System.Drawing.Size(60, 13);
            belay_cert_Label.TabIndex = 29;
            belay_cert_Label.Text = "Belay cert :";
            // 
            // lead_cert_Label
            // 
            lead_cert_Label.AutoSize = true;
            lead_cert_Label.Location = new System.Drawing.Point(52, 203);
            lead_cert_Label.Name = "lead_cert_Label";
            lead_cert_Label.Size = new System.Drawing.Size(54, 13);
            lead_cert_Label.TabIndex = 31;
            lead_cert_Label.Text = "lead cert :";
            // 
            // suspensionLabel
            // 
            suspensionLabel.AutoSize = true;
            suspensionLabel.Location = new System.Drawing.Point(52, 233);
            suspensionLabel.Name = "suspensionLabel";
            suspensionLabel.Size = new System.Drawing.Size(65, 13);
            suspensionLabel.TabIndex = 33;
            suspensionLabel.Text = "Suspension:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "create account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Waver Sign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // patronsDataSet
            // 
            this.patronsDataSet.DataSetName = "PatronsDataSet";
            this.patronsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronsBindingSource
            // 
            this.patronsBindingSource.DataMember = "Patrons";
            this.patronsBindingSource.DataSource = this.patronsDataSet;
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
            // patronsBindingNavigator
            // 
            this.patronsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patronsBindingNavigator.BindingSource = this.patronsBindingSource;
            this.patronsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patronsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patronsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patronsBindingNavigatorSaveItem});
            this.patronsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patronsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patronsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patronsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patronsBindingNavigator.Name = "patronsBindingNavigator";
            this.patronsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patronsBindingNavigator.Size = new System.Drawing.Size(1232, 25);
            this.patronsBindingNavigator.TabIndex = 19;
            this.patronsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patronsBindingNavigatorSaveItem
            // 
            this.patronsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patronsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patronsBindingNavigatorSaveItem.Image")));
            this.patronsBindingNavigatorSaveItem.Name = "patronsBindingNavigatorSaveItem";
            this.patronsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patronsBindingNavigatorSaveItem.Text = "Save Data";
            this.patronsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patronsBindingNavigatorSaveItem_Click_2);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(123, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(123, 64);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 22;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(123, 90);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 24;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(123, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 28;
            // 
            // belay_cert_CheckBox
            // 
            this.belay_cert_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patronsBindingSource, "Belay cert_", true));
            this.belay_cert_CheckBox.Location = new System.Drawing.Point(123, 168);
            this.belay_cert_CheckBox.Name = "belay_cert_CheckBox";
            this.belay_cert_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.belay_cert_CheckBox.TabIndex = 30;
            this.belay_cert_CheckBox.UseVisualStyleBackColor = true;
            // 
            // lead_cert_CheckBox
            // 
            this.lead_cert_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patronsBindingSource, "lead cert_", true));
            this.lead_cert_CheckBox.Location = new System.Drawing.Point(123, 198);
            this.lead_cert_CheckBox.Name = "lead_cert_CheckBox";
            this.lead_cert_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.lead_cert_CheckBox.TabIndex = 32;
            this.lead_cert_CheckBox.UseVisualStyleBackColor = true;
            // 
            // suspensionCheckBox
            // 
            this.suspensionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patronsBindingSource, "Suspension", true));
            this.suspensionCheckBox.Location = new System.Drawing.Point(123, 228);
            this.suspensionCheckBox.Name = "suspensionCheckBox";
            this.suspensionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.suspensionCheckBox.TabIndex = 34;
            this.suspensionCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(123, 116);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(23, 20);
            this.genderTextBox.TabIndex = 26;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(335, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(869, 450);
            this.webBrowser1.TabIndex = 35;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\Student\\Desktop\\Rock Wall App updated\\example waver.pdf", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.patronsBindingSource, "Signature", true));
            this.panel1.Location = new System.Drawing.Point(490, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 104);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CreatePatronAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(belay_cert_Label);
            this.Controls.Add(this.belay_cert_CheckBox);
            this.Controls.Add(lead_cert_Label);
            this.Controls.Add(this.lead_cert_CheckBox);
            this.Controls.Add(suspensionLabel);
            this.Controls.Add(this.suspensionCheckBox);
            this.Controls.Add(this.patronsBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CreatePatronAccount";
            this.Text = "CreatePatronAccount";
            this.Load += new System.EventHandler(this.CreatePatronAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).EndInit();
            this.patronsBindingNavigator.ResumeLayout(false);
            this.patronsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PatronsDataSet patronsDataSet;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private PatronsDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private PatronsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patronsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patronsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox belay_cert_CheckBox;
        private System.Windows.Forms.CheckBox lead_cert_CheckBox;
        private System.Windows.Forms.CheckBox suspensionCheckBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
    }
}