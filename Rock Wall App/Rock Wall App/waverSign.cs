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
    public partial class waverSign : Form
    {
        public waverSign()
        {
            InitializeComponent();
        }
        Boolean IsCapturing = false;
        private Point startPoint;
        private Point endPoint;
        Pen pen = new Pen(Color.Black);
        Glyph glyph = null;
        Signature signature = new Signature();
        String fileName = @"signature.xml";

        private void waverSign_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patronsDataSet.Patrons' table. You can move, or remove it, as needed.
            this.patronsTableAdapter.Fill(this.patronsDataSet.Patrons);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCapturing)
            {
                if (startPoint.IsEmpty && endPoint.IsEmpty)
                {
                    endPoint = e.Location;
                }
                else
                {
                    startPoint = endPoint;
                    endPoint = e.Location;
                    Line line = new Line(startPoint, endPoint);
                    glyph.Lines.Add(line);
                    DrawLine(line);
                }

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsCapturing = false;
            signature.Glyphs.Add(glyph);
            startPoint = new Point();
            endPoint = new Point();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsCapturing = true;
            glyph = new Glyph();
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
            using (Graphics graphic = this.panel1.CreateGraphics())
            {
                SolidBrush solidBrush = new SolidBrush(Color.LightBlue);
                graphic.FillRectangle(solidBrush, 0, 0, panel1.Width, panel1.Height);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearSignaturePanel();
        }
    }
}