using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Zadání
    1. Nastavení počtu pokusů dle volby úrovně hry a zobrazení
        Začátečník  20 pokusů       1 - 50 rozsah tipovaného čísla 
        Pokročilý   10 pokusů       1 - 100 rozsah tipovaného čísla     
        Profesionál  5 pokusů       1 - 100 rozsah tipovaného čísla

    2. Spuštění hry tlačítkem Play
        - povolení tlačítka Stop a zakázání tlačítka Play a zakázání nastavení úrovně hry 
        - vygenerování čísla pro tipování ve zvoleném rozsahu 

    3. Tipování čísla do uhodnutí nebo vyčerpání pokusů nebo ukončení tlačítkem Stop 
        - po každém tipu snížit počet pokusů
        - v lblVysledek zobrazovat nápovědu zdali tipované číslo je menší nebo větší než hádané
        - v pctVysledek zobrazovat smajlíka odpovídající úspěšného / neúspěšného pokusu (soubry ve složce Image)  
        - úspěšné uhodnutí zobrazit v lblVysledek + smajlík
        - průběžné zobrazování řady tipovaných čísel v dané hře

    4.  Statistika + ukončení a resetování
        - ve stavovém řádku zobrazovat vcelkový počet výher a proher
        - dialogové ukončení aplikace (btnKonec)
        - defaultní nastavení aplikace (btnReset)
    
    Připravené objekty:
        GroupBox grpUroven
        RadioButton radProf
        RadioButton radPokr
        RadioButton radZac        
        Label lblPokusy
        Button btnReset
        Button btnClose
        
        GroupBox grpHra
        Label lblTip
        NumericUpDown nmTipCislo
        Label lblVysledek
        PictureBox pctVysledek
        Button btnTipuj
        Button btnPlay
        Button btnStop
        ToolStripStatusLabel lblVyhry
        ToolStripStatusLabel lblProhry
        ToolStripStatusLabel lblTipy
*/

namespace HraCisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            apkDefault();
        }

        private void apkDefault()
        {
            Text = "Hra uhádni číslo";
            AcceptButton = btnPlay;
            CancelButton = btnClose;
            radZac.Checked = true;
            btnStop.Enabled = false;
            lblPokusy.Text = "20";
            lblTipy.Text = " - ";
        }
    }
}
