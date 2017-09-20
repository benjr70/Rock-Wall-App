using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace Rock_Wall_App
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void reportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportsDataSet);

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.reportsDataSet.reports);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DateTime localdate = DateTime.Now;
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Report";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls| Excel Files(2007)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 20;

                ExcelApp.Cells[1, 1] = "ID number";
                ExcelApp.Cells[1, 2] = " arrival time";
                ExcelApp.Cells[1, 3] = "Gender";
                
                for (int i = 0; i < dataGridViewTextBoxColumn1.DataGridView.Rows.Count; i++)
                {
                    ExcelApp.Cells[i + 2, 1] = dataGridViewTextBoxColumn1.DataGridView.Rows[i].Cells[0].Value.ToString();
                    ExcelApp.Cells[i + 2, 2] = dataGridViewTextBoxColumn1.DataGridView.Rows[i].Cells[1].Value.ToString();
                    ExcelApp.Cells[i + 2, 3] = dataGridViewTextBoxColumn1.DataGridView.Rows[i].Cells[2].Value.ToString();
                }
                                
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
    }
}
