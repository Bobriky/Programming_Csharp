using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstBox
{
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            try
            {
                string[] pole = (data.Split(' '));
                nmUpDownID.Value = Convert.ToInt16(pole[0]);
                txtJmeno.Text = pole[1];
                txtPrijmeni.Text = pole[2];

                
                cOsoba osoba1 = new cOsoba();
                cOsoba osoba2 = new cOsoba();
                cOsoba osoba3 = new cOsoba();

                osoba1.setID(80);
                nmUpDownID.Value = osoba1.getID();

                /*
                osoba1.idOsoba = "00";
                osoba2.nameOsoba = "Moje máma!";
                osoba3.surnameOsoba = "LUkyho tatko ururuwu";
                txtPrijmeni.Text = osoba1.hardHittingUrurLine;
                */

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
    }
}
