using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserShow
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Random rand;
        private Color currentColor;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int maxX = ClientSize.Width - 1;
            int maxY = ClientSize.Height - 1;

            Random rand = new Random();
            Graphics plt = e.Graphics;
            
            for (int gap = 0; gap <= maxX; gap += 50)
            {
                plt.DrawLine(Pens.Black, 0, 0, maxX, 0 + gap);
                //plt.FillPie(Brushes.Red, 0, 0, maxX, gap, maxY / 10, maxY / 10);
                //plt.DrawLine(Pens.Black, 0, 0, maxX - gap, maxY);
                gap += 1;
            }
            for (int gap = 0; gap <= maxX; gap += 50)
            {
                plt.DrawLine(Pens.Black, 0, maxY, maxX, 0 + gap);
                //plt.DrawLine(Pens.Black, 0, maxY, 0 + gap, 0);
                gap += 1;
            }
            for (int gap = 0; gap <= maxX; gap += 50)
            {
                Point[] trianglePoints = new Point[]
                {
                    new Point(0, 0),              // vrchol nahoře
                    new Point(maxX, y1),         // spodní pravý vrchol
                    new Point(maxX, maxY - y2)   // spodní levý vrchol
                };

                // Vyplnění trojúhelníku aktuální náhodnou barvou
                Brush brush = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                
                    plt.FillPolygon(brush, trianglePoints);


                // Vykreslení obrysu trojúhelníku s jinou barvou
                Pen pen = new Pen(Color.Black, 4);
                
                    plt.DrawPolygon(pen, trianglePoints);
                

            }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
