using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Project_Forms
{
    public partial class RollDice : Form
    {
        public RollDice()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random Random = new Random();

            //Read dice roll settings
            int noRolls = Convert.ToInt32(nudDiceRollAmount.Value);
            int diceType = Convert.ToInt32(cbDiceSelector.SelectedItem);

            //Clear dice rolls listbox
            lstDiceRolls.Items.Clear();

            //Generate random numbers for specified number of times, and write to listbox
            for (int i = 1; i <= noRolls; i++)
            {
                int newNo = Random.Next(diceType) + 1;
                lstDiceRolls.Items.Add(newNo);
            }
        }
    }
}
