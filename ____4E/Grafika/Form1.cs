using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Font drawFont = new Font("Arial", 16);
            int maxX = ClientSize.Width - 1;
            int maxY = ClientSize.Height - 1;
            int stredX = maxX / 2;
            int stredY = maxY / 2;

            Graphics plt = e.Graphics;
            plt.DrawLine(Pens.Coral, 100, 100, 200, 200);

            plt.DrawEllipse(Pens.DarkKhaki, 100, 150, 50, 40);
            plt.FillEllipse(Brushes.HotPink, 100, 150, 50, 40);
            plt.DrawRectangle(Pens.Thistle, 300, 300, 60, 50);
            plt.FillRectangle(Brushes.Cornsilk, 300, 300, 60, 50);
            plt.DrawString("BUY PONKE", drawFont,Brushes.Pink, 500, 100,StringFormat.GenericDefault);
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define polygon.
            Point point1 = new Point(150, 50);
            Point point2 = new Point(200, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 120);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

            // Draw polygon to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints);

            for(int i = 0; i<500; i += 10)
            {
                plt.DrawLine(Pens.Black, stredX, stredY, 100, 100 + i);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
