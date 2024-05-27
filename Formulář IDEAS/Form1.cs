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

namespace Formulář_IDEAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void IDkey_TextChanged(object sender, EventArgs e)
        {
            if(IDkey.Text != "")
            {
                int counter = 0;
                bool firstLine;
                string line;
                try
                {   
                    StreamReader employeeList = new StreamReader("test.txt", Encoding.Default);
                    //firstLine = true;
                    while (!employeeList.EndOfStream)
                    {
                        line = employeeList.ReadLine();
                        if (line.Contains(IDkey.Text))
                        {
                            
                            string[] array = line.Split(';');
                            txtFullName.Text = array[2];
                            txtFullName.Enabled = true;
                            counter++;
                            textBox4.Text = counter.ToString();
                        }
                        else
                        {
                            firstLine = false;
                        }
                    }
                    employeeList.Close();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
