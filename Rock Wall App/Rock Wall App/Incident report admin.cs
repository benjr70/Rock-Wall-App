using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Wall_App
{
    public partial class Incident_report_admin : Form
    {
        public Incident_report_admin()
        {
            InitializeComponent();
        }

        private void incidentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportsDataSet);

        }

        private void Incident_report_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.Incident' table. You can move, or remove it, as needed.
            this.incidentTableAdapter.Fill(this.reportsDataSet.Incident);

        }
    }
}
