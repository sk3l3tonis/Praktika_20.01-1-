using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphIntersection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);

            float xMin = -10;
            float xMax = 10;
            float yMin = -10;
            float yMax = 10;

            float width = pictureBox.Width;
            float height = pictureBox.Height;

            float xScale = width / (xMax - xMin);
            float yScale = height / (yMax - yMin);

            g.TranslateTransform(width / 2, height / 2);

            g.DrawLine(Pens.Black, -width / 2, 0, width / 2, 0);
            g.DrawLine(Pens.Black, 0, -height / 2, 0, height / 2);

            Pen sinPen = new Pen(Color.Red, 1f);
            for (float x = xMin; x <= xMax; x += 0.1f)
            {
                float y = (float)Math.Sin(x);
                g.DrawEllipse(sinPen, x * xScale, -y * yScale, 1f, 1f);
            }

            Pen squarePen = new Pen(Color.Blue, 1f);
            for (float x = xMin; x <= xMax; x += 0.1f)
            {
                float y = x * x;
                g.DrawEllipse(squarePen, x * xScale, -y * yScale, 1f, 1f);
            }

            double epsilon = 0.01;
            double intersectionX = xMin;
            double intersectionY = 0;
            for (double x = xMin; x <= xMax; x += epsilon)
            {
                double y1 = Math.Sin(x);
                double y2 = x * x;
                if (Math.Abs(y1 - y2) < epsilon)
                {
                    intersectionX = x;
                    intersectionY = y1;
                    break;
                }
            }

            int intersectionRadius = 3;
            float intersectionPosX = (float)(intersectionX * xScale) - intersectionRadius / 2;
            float intersectionPosY = (float)(-intersectionY * yScale) - intersectionRadius / 2;
            g.FillEllipse(Brushes.Green, intersectionPosX, intersectionPosY, intersectionRadius, intersectionRadius);

            pictureBox.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);

            float xMin = -10;
            float xMax = 10;
            float yMin = -10;
            float yMax = 10;

            float width = pictureBox.Width;
            float height = pictureBox.Height;

            float xScale = width / (xMax - xMin);
            float yScale = height / (yMax - yMin);

            g.TranslateTransform(width / 2, height / 2);

            g.DrawLine(Pens.Black, -width / 2, 0, width / 2, 0);
            g.DrawLine(Pens.Black, 0, -height / 2, 0, height / 2);

            Pen sinPen = new Pen(Color.Red, 1f);
            for (float x = xMin; x <= xMax; x += 0.1f)
            {
                float y = (float)Math.Sin(x);
                g.DrawEllipse(sinPen, x * xScale, -y * yScale, 1f, 1f);

                pictureBox.Image = bmp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);

            float xMin = -10;
            float xMax = 10;
            float yMin = -10;
            float yMax = 10;

            float width = pictureBox.Width;
            float height = pictureBox.Height;

            float xScale = width / (xMax - xMin);
            float yScale = height / (yMax - yMin);

            g.TranslateTransform(width / 2, height / 2);

            g.DrawLine(Pens.Black, -width / 2, 0, width / 2, 0);
            g.DrawLine(Pens.Black, 0, -height / 2, 0, height / 2);

            Pen squarePen = new Pen(Color.Blue, 1f);
            for (float x = xMin; x <= xMax; x += 0.1f)
            {
                float y = x * x;
                g.DrawEllipse(squarePen, x * xScale, -y * yScale, 1f, 1f);

                pictureBox.Image = bmp;
            }
        }
    }
}
