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
using WindowsFormsApplication2.Forms;

namespace WindowsFormsApplication2.Classes
{
    public partial class LoadFile : Form
    {
        string[] Files = Directory.GetFiles(Globals.CustomFilePath, "*.txt");

        public LoadFile()
        {
            InitializeComponent();
        }

        private void LoadFile_Load(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            for (int i = 0; i <= Files.Length - 1; i++)
            {
                //Find the location of the final slash in the filepath
                int marker = Files[i].LastIndexOf('\\');
                //Just enter the name into the listbox, taking out the first section up to the final slash, and 
                //removing '.txt' from the end
                lstFileList.Items.Add(Files[i].Substring(marker + 1,Files[i].Length - (marker + 1) - 4));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //If they have chosen a list box item:
            if (lstFileList.SelectedIndex >= 0)
            {
                //Output filepath
                Globals.CustomFilePath = Files[lstFileList.SelectedIndex];
                this.Close();
            }
            else
            {
                //Otherwise output error
                MessageBox.Show("Please choose a file from the list before submitting");
            }
        }
    }
}
