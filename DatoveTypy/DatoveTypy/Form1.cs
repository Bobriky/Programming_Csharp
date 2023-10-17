using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Datové typy
   - Základní datové typy                                                                    
        Celočíselné datové typy     int   long  short  byte  uint  ulong  ushort ubyte 
        Reálné číselné typy         float   double  long double decimal 
        Logický datový typ          bool    true false 
        Znak                        char       
        Textový řetězec - sekvence (pole) znaků     string 
    - Strukturované uživatelské typy      pole    enum    struct      class 
    - Ordinální datové typy         přesně definovaný předchůdce i následovník 
    - Přetypování dat               (datovyTyp) proměnná 
 */
/* Operátory
    Aritmetické operátory 
    =   +   -   *   /	%   ++x     --x     x++     x--

    Relační operátory a operátory typu
    == 	!=   <  >   <=  >=  

    Logické operátory
    !   &&  || 
*/

namespace DatoveTypy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            akce();
        }

        private void akce()
        {
            float prom1 = 12;
            float prom2 = 5;
            float vysledek = 0;

            char znam = '*';
            switch (znam)
            {
                case '+' : 
                    vysledek = prom1 + prom2;
                    break;
                case '-' :
                    vysledek = prom1 - prom2;
                    break;
                case '/' :
                    vysledek = prom1 / prom2;
                    break;
                case '*' :
                    vysledek = prom1 * prom2;
                    break;
            }


            /*
               string ret1 = "konec";
               string ret2 = " hodiny";
               string ret3 = ret1 + ret2;
           */

            // následující příkazy neměnit!!!
            lblProm1.Text = prom1.ToString();
            lblProm2.Text = prom2.ToString();
            lblVysl.Text = vysledek.ToString();
        }

        private void lblVysl_Click(object sender, EventArgs e)
        {

        }
    }
}
