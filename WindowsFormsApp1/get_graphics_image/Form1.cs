using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_graphics_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            try
            {
                Graphics graphics = e.Graphics;
                graphics.DrawImage(Image.FromFile("newimage.jpg"), 0, 0, 300, 200);
                graphics.Dispose();
            }
            catch { }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = Image.FromFile("1.jpg");
                Graphics graphich = Graphics.FromImage(image);
                Font font = new Font("Verdana", 30, FontStyle.Bold);
                string helloString = "Ну бывает";

                // меряем размер текста с учетом шрифта и т.д (строка, шрифт)
                SizeF sizeF = graphich.MeasureString(helloString, font);
                graphich.DrawString(helloString, font, Brushes.White, 10, 10);
                graphich.DrawRectangle(new Pen(Color.Red, 6), 10, 10, sizeF.Width, sizeF.Height);

                //сохраняем изображение
                image.Save("newimage.jpg");
                Rectangle clientRectangle = new Rectangle(new Point(0, 0), image.Size);
                //image.Dispose();

                // или
                //if (image !=null)
                //{
                //    image.Dispose();
                //}

                // или
                image?.Dispose();
                graphich?.Dispose();


                // переписовка
                Invalidate(clientRectangle);

            }
            catch { }
        }
    }
}
