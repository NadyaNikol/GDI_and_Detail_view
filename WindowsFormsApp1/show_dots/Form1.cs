using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show_dots
{
    public partial class Form1 : Form
    {

        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            foreach (Point point in points)
            {
                graphics.FillEllipse(Brushes.Black, point.X, point.Y, 10, 10);
            }
        }
    }
}
