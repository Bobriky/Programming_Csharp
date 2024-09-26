using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tridaZaci
{
    public partial class fmModel : Form
    {
        public fmModel()
        {
            InitializeComponent();
            try
            {
                pctBox.Image = Image.FromFile("Model.JPG");
            }
            catch 
            {

            }
        }
    }
}
