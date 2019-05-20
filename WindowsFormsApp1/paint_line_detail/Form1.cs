using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_line_detail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // сглаживание
           graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Pen BluePen = new Pen(Color.Blue, 20);
            // начало отрезка
            BluePen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            // конец отрезка
            BluePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            BluePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(BluePen, 20, 100, 270, 100);
            BluePen?.Dispose();
            graphics?.Dispose();

        }
    }
}
