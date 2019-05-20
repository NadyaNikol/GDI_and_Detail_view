using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // способы получения доступа к обьекту класса Graphics
        public Form1()
        {
            InitializeComponent();

            //Paint += Form1_Paint;
        }

        // 1-ый способ получения контекста устройства
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 30, FontStyle.Bold | FontStyle.Italic);

            graphics.DrawString("Привет, привет", font, Brushes.Green, 10, 10);

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Font font = new Font("Arial", 30, FontStyle.Bold | FontStyle.Italic);

            //

            // 2-ой способ получения контекста используя переопределения метода OnPaint(e)
            //Graphics graphics = e.Graphics;

            Graphics graphics = CreateGraphics();
            graphics.DrawString("Привет, привет", font, Brushes.Green, 10, 10);

        }

    }
}
