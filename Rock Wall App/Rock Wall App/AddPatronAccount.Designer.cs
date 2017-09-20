namespace Rock_Wall_App
{
    partial class AddPatronAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatronAccount));
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsDataSet = new Rock_Wall_App.PatronsDataSet();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.patronsTableAdapter = new Rock_Wall_App.PatronsDataSetTableAdapters.PatronsTableAdapter();
            this.tableAdapterManager = new Rock_Wall_App.PatronsDataSetTableAdapters.TableAdapterManager();
            this.patronsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patronsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            idLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).BeginInit();
            this.patronsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(80, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 20;
            idLabel.Text = "Id:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(80, 152);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 22;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(80, 178);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 24;
            last_NameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(80, 204);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 26;
            genderLabel.Text = "Gender:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(80, 230);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 28;
            emailLabel.Text = "Email:";
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
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(318, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(758, 592);
            this.webBrowser1.TabIndex = 17;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\Ben\\Desktop\\Rock Wall App\\example waver.pdf", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.patronsBindingSource, "Signature", true));
            this.panel1.Location = new System.Drawing.Point(345, 648);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 112);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(939, 648);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Undo";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(939, 692);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
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
            // patronsBindingSource1
            // 
            this.patronsBindingSource1.DataMember = "Patrons";
            this.patronsBindingSource1.DataSource = this.patronsDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(151, 123);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 21;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(151, 149);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 23;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(151, 175);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 25;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(151, 201);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(37, 20);
            this.genderTextBox.TabIndex = 27;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patronsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(151, 227);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 29;
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
            // patronsBindingNavigator
            // 
            this.patronsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patronsBindingNavigator.BindingSource = this.patronsBindingSource;
            this.patronsBindingNavigator.CountItem = null;
            this.patronsBindingNavigator.DeleteItem = null;
            this.patronsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem});
            this.patronsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patronsBindingNavigator.MoveFirstItem = null;
            this.patronsBindingNavigator.MoveLastItem = null;
            this.patronsBindingNavigator.MoveNextItem = null;
            this.patronsBindingNavigator.MovePreviousItem = null;
            this.patronsBindingNavigator.Name = "patronsBindingNavigator";
            this.patronsBindingNavigator.PositionItem = null;
            this.patronsBindingNavigator.Size = new System.Drawing.Size(1130, 25);
            this.patronsBindingNavigator.TabIndex = 0;
            this.patronsBindingNavigator.Text = "bindingNavigator1";
            // 
            // AddPatronAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1147, 733);
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
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.patronsBindingNavigator);
            this.Name = "AddPatronAccount";
            this.Text = "AddPatronAccount";
            this.Load += new System.EventHandler(this.AddPatronAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingNavigator)).EndInit();
            this.patronsBindingNavigator.ResumeLayout(false);
            this.patronsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PatronsDataSet patronsDataSet;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private PatronsDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
        private PatronsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.BindingSource patronsBindingSource1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingNavigator patronsBindingNavigator;
    }
}