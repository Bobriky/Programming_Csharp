using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XX_Christmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                for(int i = 1; i < 47; i++)
                {
                    cmbBox.Items.Add(@"Vanoce\Vanoce" + i.ToString() + ".jpg");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            cmbBox.SelectedIndex = 0;
            pctBox.Image = Image.FromFile(cmbBox.SelectedItem.ToString());

            pctBox.SizeMode = PictureBoxSizeMode.CenterImage;
            /*
            pctBox.Image = Image.FromFile(@"Vanoce\Vanoce1.jpg");       //@  -  Speciální znak pro odstranění speciálních symbolů
                                                                        //      Normálně se ale píše \\ mezi cestami, nebo sus pro Linux /
                                                                        //      ale nějak to funguje.
            */
            
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox.Items.Count > 0)
            {
                pctBox.Image = Image.FromFile(cmbBox.SelectedItem.ToString());
            }
        }
        Random rnd = new Random();

        private void pctBox_Click(object sender, EventArgs e)
        {
            int randomNumber = rnd.Next(0, cmbBox.Items.Count);
            pctBox.Image = Image.FromFile("Vanoce\\Vanoce" + randomNumber.ToString() + ".jpg");
        }
    }
}
