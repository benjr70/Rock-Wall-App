using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Wall_App
{
    public partial class AddPatronAccount : Form
    {
      
        public AddPatronAccount()
        {
            InitializeComponent();
           
        }

        private void patronsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);

        }

        private void AddPatronAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
           // this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);

        }
        Boolean IsCapturing = false;
        private Point startPoint;
        private Point endPoint;
        Pen pen = new Pen(Color.Black);
        Glyph glyph = null;
        Signature signature = new Signature();
        String fileName = @"signature.xml";

        List<Point> curPoints = new List<Point>();
        List<List<Point>> allPoints = new List<List<Point>>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // here you can use DrawLines or DrawCurve
            // current line
            if (curPoints.Count > 1) e.Graphics.DrawCurve(Pens.Black, curPoints.ToArray());
            // other lines or curves
            foreach (List<Point> points in allPoints)
                if (points.Count > 1) e.Graphics.DrawCurve(Pens.Black, points.ToArray());
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            // here we should check if the distance is more than a minimum!
            curPoints.Add(e.Location);
            // let it show
            panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (curPoints.Count > 1)
            {
                // ToList creates a copy
                allPoints.Add(curPoints.ToList());
                curPoints.Clear();
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (curPoints.Count > 1)
            {
                // begin fresh line or curve
                curPoints.Clear();
                // startpoint
                curPoints.Add(e.Location);
            }
        }
        private void DrawLine(Line line)
        {
            using (Graphics graphic = this.panel1.CreateGraphics())
            {
                graphic.DrawLine(pen, line.StartPoint, line.EndPoint);
            }
        }

        private void DrawSignature()
        {
            foreach (Glyph glyph in signature.Glyphs)
            {
                foreach (Line line in glyph.Lines)
                {
                    DrawLine(line);
                }
            }

        }

        private void ClearSignaturePanel()
        {
            if (allPoints.Count > 0)
            {
                allPoints.RemoveAt(allPoints.Count - 1);
                panel1.Invalidate();
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearSignaturePanel();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var name = this.first_NameTextBox.Text;
            name += this.last_NameTextBox.Text;
            name += this.idTextBox.Text;
            string fileName = @"C:\Users\Ben\Desktop\Rock Wall App\Signatures\" + name + ".bmp" ;
            Bitmap bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Width);
            panel1.DrawToBitmap(bmp, panel1.ClientRectangle);
            bmp.Save(fileName, ImageFormat.Bmp);
            this.Validate();
            this.patronsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patronsDataSet);
            string message = "Patron account was Successfully Created";
            string caption = "Creation Successful";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    [Serializable]
    public class Line
    {
        public Line()
        {

        }

        public Line(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
    }

    public class Glyph
    {
        public Glyph()
        {
            this.Lines = new List<Line>();
        }
        public List<Line> Lines { get; set; }
    }
 
    public class Signature
    {
        public Signature()
        {
            this.Glyphs = new List<Glyph>();
        }

        public List<Glyph> Glyphs { get; set; }
    }

}
