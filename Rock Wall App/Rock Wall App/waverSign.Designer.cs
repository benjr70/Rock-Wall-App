namespace Rock_Wall_App
{
    partial class waverSign
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.patronsDataSet = new Rock_Wall_App.PatronsDataSet();
            this.patronsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronsTableAdapter = new Rock_Wall_App.PatronsDataSetTableAdapters.PatronsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(52, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(869, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\Student\\Desktop\\Rock Wall App updated\\example waver.pdf", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.patronsBindingSource, "Signature", true));
            this.panel1.Location = new System.Drawing.Point(209, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 104);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // waverSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "waverSign";
            this.Text = "waverSign";
            this.Load += new System.EventHandler(this.waverSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patronsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private PatronsDataSet patronsDataSet;
        private System.Windows.Forms.BindingSource patronsBindingSource;
        private PatronsDataSetTableAdapters.PatronsTableAdapter patronsTableAdapter;
    }
}