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

namespace DirectoryTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            List<string> seznam = new List<string>();
            seznam.Add("urur");
            seznam.Add("ponke");
            seznam.Add("brett");
            seznam.Add("KrasbergIssue");
            Directory.SetCurrentDirectory("C:\\");     // skibidi C:\\ pro nalezení kořenu skibida
            txtDirectory.Text = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(@"C:\myDir");         //nebo alternativa   @"C:\
            Directory.SetCurrentDirectory(@"C:\myDir");
            foreach (string item in seznam)
            {
                Directory.CreateDirectory(item);
            }*/
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                lstSubfolder.Items.Clear();
                lstSubfolderInside.Items.Clear();
                if (flgFolder.ShowDialog() == DialogResult.OK)
                {
                    Directory.SetCurrentDirectory(flgFolder.SelectedPath);
                    txtDirectory.Text = Directory.GetCurrentDirectory();
                    foreach (string item in Directory.GetFileSystemEntries(flgFolder.SelectedPath, "*", SearchOption.TopDirectoryOnly))
                    {
                        string folderName = "\\" + Path.GetFileName(item);
                        lstSubfolder.Items.Add(folderName);
                    }
                }
                else
                {
                    txtDirectory.Text = "Cesta nevybrána";
                    lstSubfolder.Items.Clear();
                    lstSubfolderInside.Items.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lstSubfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubfolder.SelectedItem != null)
            {
                // Získání vybrané složky
                string selectedFolder = Path.Combine(flgFolder.SelectedPath, lstSubfolder.SelectedItem.ToString().Substring(1)); // Odstranění úvodního "\"

                // Vymazání a načtení obsahu vybrané složky
                lstSubfolderInside.Items.Clear();
                if (Directory.Exists(selectedFolder))
                {
                    foreach (string item in Directory.GetFileSystemEntries(selectedFolder))
                    {
                        string itemName = Path.GetFileName(item);
                        lstSubfolderInside.Items.Add(itemName);
                    }
                }
            }
        }
    }
}
