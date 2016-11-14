using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Forms;

namespace WindowsFormsApplication2.Project_Forms.Unit_Entries
{
    public partial class EnterValue : Form
    {
        public EnterValue()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtValue.Text == ""))
            {
                Globals.CustomVal = txtValue.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a value before submitting");
            }
        }

        private void EnterValue_Load(object sender, EventArgs e)
        {
            lblEnterVal.Text = Globals.CustomVal;
        }
    }
}
