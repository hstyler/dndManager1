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

namespace WindowsFormsApplication2
{
    public partial class Modifiers : Form
    {
        public Modifiers()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Double atkMod = 1;

            //If it is a critical, double damage
            if (cbCrit.Checked == true)
            {
                atkMod = 2;
            }

            Double targMod = 1;

            //If the target is immune, nullify damage
            if (rbImmune.Checked == true)
            {
                targMod = 0;
            }

            //If the target is resistant, halve damage
            if (rbResist.Checked == true)
            {
                targMod = 0.5;
            }

            //If the target is vulnerable, double damage
            if (rbVuln.Checked == true)
            {
                targMod = 2;
            }

            //Find the total modifier
            double totalMod = targMod * atkMod;

            //Pass this out of the form
            Globals.CustomVal = Convert.ToString(totalMod);

            this.Close();
        }

        private void Modifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
