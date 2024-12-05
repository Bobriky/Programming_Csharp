using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectorySkibid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> seznam = new List<string>();
            seznam.Add("urur");
            seznam.Add("ponke");
            seznam.Add("brett");
            seznam.Add("KrasbergIssue");
            Directory.SetCurrentDirectory("C:\\");     // skibidi C:\\ pro nalezení kořenu skibida
            lblDirectory.Text = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(@"C:\myDir");         //nebo alternativa   @"C:\
            foreach(string item in seznam)
            {
                Directory.CreateDirectory("C:\\myDir"+ item);
            }
        }
    }
}
