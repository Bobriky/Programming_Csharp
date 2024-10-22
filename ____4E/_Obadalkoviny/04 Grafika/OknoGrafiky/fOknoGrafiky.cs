using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OknoGrafiky
{
    public partial class fOknoGrafiky : Form
    {
        public fOknoGrafiky()
        {
            InitializeComponent();
        }


        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void radBtnOrazec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point[] ururPole = new Point[20];               // Pole
            List<Point> lstBody = new List<Point>();        // List
            for(int i = 0; i < 20; i++)
            {
                //ururPole[i] = new Point(i, i + 2);
                lstBody.Add(new Point(i, (int)Math.Pow(i, 2)));
            }
            Graphics skibid = e.Graphics;
            skibid.DrawCurve(Pens.SaddleBrown, lstBody.ToArray());
        }

        private void numXY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numWH_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
