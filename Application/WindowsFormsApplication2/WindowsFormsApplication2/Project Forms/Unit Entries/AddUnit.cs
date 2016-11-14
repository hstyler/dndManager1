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
    public partial class AddUnit : Form
    {
        //Arrays for storing attacks/spells
        string[,] unitAttacks = new string[10, 5];
        string[,] unitSpells = new string[10, 6];

        //Number of attacks/spells loaded
        int atkIndex = 0;
        int spIndex = 0;

        public AddUnit()
        {
            InitializeComponent();
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
            //Change title depending on whether the user has chosen to create a new player/enemy
            if (Globals.newEnemy == true)
            {
                //Set title to Create New Enemy
                lblCreateNew.Text = "Create New Enemy";
            }
            else
            {
                //Set title to create new player
                lblCreateNew.Text = "Create New Player";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Read in unit name, and all of their stats
            string newUnitName = txtName.Text;
            string[] stats = new string[9];

            //Read in all stats and round up any decimal values that may have been entered
            stats[0] = Convert.ToString(Math.Round(nudStr.Value, 0 , MidpointRounding.AwayFromZero));
            stats[1] = Convert.ToString(Math.Round(nudDex.Value, 0 , MidpointRounding.AwayFromZero));
            stats[2] = Convert.ToString(Math.Round(nudCon.Value, 0 , MidpointRounding.AwayFromZero));
            stats[3] = Convert.ToString(Math.Round(nudInt.Value, 0 , MidpointRounding.AwayFromZero));
            stats[4] = Convert.ToString(Math.Round(nudCha.Value, 0 , MidpointRounding.AwayFromZero));
            stats[5] = Convert.ToString(Math.Round(nudWis.Value, 0 , MidpointRounding.AwayFromZero));
            stats[6] = Convert.ToString(Math.Round(nudHealth.Value, 0 , MidpointRounding.AwayFromZero));
            stats[7] = Convert.ToString(Math.Round(nudLevel.Value, 0, MidpointRounding.AwayFromZero));
            stats[8] = Convert.ToString(Math.Round(nudAC.Value, 0, MidpointRounding.AwayFromZero));

            //Read in description of unit
            string newUnitDesc = rtbUnitDesc.Text;

            //If any vital details - name, attacks/spells, or health are missing, tell them to enter
            //these values
            if (txtName.Text == "" || (lstAtk.Items.Count == 0 && lstSp.Items.Count == 0))
            {
                MessageBox.Show("Necessary details missing - ensure a name has been entered, they have at least  one attack or spell, and that their health is greater than zero");      
            }
            else
            {
                //Read in number of attacks and spells
                int[] arrayLengths = { atkIndex, spIndex };
                //Determine filepath of new unit file
                string filePath = Application.StartupPath + "\\Users\\" + Globals.currentUser;
                //Run save unit routine
                FileRW.SaveUnit(filePath, unitSpells, unitAttacks, newUnitName, stats, newUnitDesc, arrayLengths);
                //Close form
                this.Close();
            }
        }

        private void btnAtkAdd_Click(object sender, EventArgs e)
        {
            //If they have less than ten attacks entered:
            if (lstAtk.Items.Count < 10)
            {
                //Read in all fields
                string newAttackName = txtAtkName.Text;
                string newAttackDmg = Math.Round(nudAtkDamage.Value, 0, MidpointRounding.AwayFromZero) + "d" + cbAtkDamage.SelectedItem.ToString();
                string newAttackType = cbAtkType.SelectedItem.ToString();

                //If any were empty, tell them to fill them, and stop
                if (newAttackType == "" || newAttackName == "" || newAttackDmg == "")
                {
                    MessageBox.Show("Please fill in all fields to create a new attack");
                }
                else
                {
                    //Otherwise write to list box, and array
                    lstAtk.Items.Add(newAttackName + ": " + newAttackDmg + ", " + newAttackType);

                    //Read attack name
                    unitAttacks[atkIndex, 0] = newAttackName;
                    //Read in damage value from spinner
                    unitAttacks[atkIndex, 1] = Convert.ToString(Math.Round(nudAtkDamage.Value, 0, MidpointRounding.AwayFromZero));
                    //Read chosen dice type
                    unitAttacks[atkIndex, 2] = cbAtkDamage.SelectedItem.ToString();
                    //Read attack type, and modifier
                    unitAttacks[atkIndex, 3] = newAttackType;
                    unitAttacks[atkIndex, 4] = cbAtkMod.SelectedItem.ToString();
                    atkIndex++;
                }
                ClearAttackEntry();
            }
            else
            {
                //If more than 10 attacks, inform them that they have reached the maximum
                MessageBox.Show("Max number of attacks reached, please remove an attack to add a new one.");
            }
        }

        private void btnRemoveAtk_Click(object sender, EventArgs e)
        {
            if (lstAtk.Items.Count > 0)
            {
                //Update attack array, and remove item from the list box.
                UpdateAtkArray(lstAtk.SelectedIndex);
                lstAtk.Items.Remove(lstAtk.SelectedItem);
            }
        }

        private void btnSpAdd_Click(object sender, EventArgs e)
        {
            //If they have less than twenty spells entered
            if (lstSp.Items.Count < 20)
            {
                //Read in all data from textboxes
                string newSpName = txtSpName.Text;
                //Read spell damage and type from spinner & combobox
                string newSpDmg = Math.Round(nudSpDamage.Value, 0, MidpointRounding.AwayFromZero) + "d" + cbSpDamage.SelectedItem.ToString();
                string newSpType = cbSpType.SelectedItem.ToString();
                //Read spell slot from spinner, and description from textbox.
                string newSpSlot = Convert.ToString(nudSpSlot.Value);
                string newSpDesc = rtbSpDesc.Text;

                //If any key data is missing, inform the user that it needs to be added
                if (newSpName == "" ||  newSpDmg == "" || newSpSlot == "" || newSpType == "")
                {
                    MessageBox.Show("Please fill in all fields to create a new attack");
                }
                else
                {
                    //Write new spell to list box
                    lstSp.Items.Add(newSpSlot + "- " + newSpName + ": " + newSpDmg + ", " + newSpType);
                    //Add all spell details to the spell array for that unit
                    unitSpells[spIndex, 0] = newSpName;
                    //Write damage from spinner
                    unitSpells[spIndex, 1] = Convert.ToString(Math.Round(nudSpDamage.Value, 0 , MidpointRounding.AwayFromZero));
                    //Write chosen dice type
                    unitSpells[spIndex, 2] = cbSpDamage.SelectedItem.ToString();
                    //Write spell type, slot and description from variables
                    unitSpells[spIndex, 3] = newSpType;
                    unitSpells[spIndex, 4] = newSpSlot;
                    unitSpells[spIndex, 5] = newSpDesc;
                    spIndex++;
                }
                ClearSpellEntry();
            }
            else
            {
                //If they have more than 20 spells, inform them that the limit has been reached
                MessageBox.Show("Max number of spells reached, please remove an attack to add a new one.");
            }
        }

        private void UpdateSpArray(int removedVal)
        {
            //Decrement the amount of spells
            spIndex--;
            string[,] temp = new string[10, 6];
            int count = 0;

            //Go through array, reading in all values into a temporary array, apart from the value that has been
            //removed from the list.
            int i = 0;

            do
            {
                //If the current item is not the item to be removed
                if (!(count == removedVal))
                {
                    //Add this spell's details to the temporary array
                    temp[count, 0] = unitSpells[count, 0];
                    temp[count, 1] = unitSpells[count, 1];
                    temp[count, 2] = unitSpells[count, 2];
                    temp[count, 3] = unitSpells[count, 3];
                    temp[count, 4] = unitSpells[count, 4];
                    temp[count, 5] = unitSpells[count, 5];
                    count++;
                }
                i++;
                //Until all spells have been checked
            } while (unitSpells[i, 0] != null);

            //Set the spells array to the temporary array, which now only contains the spells that are not
            //removed
            unitSpells = temp;
        }

        private void UpdateAtkArray(int removedVal)
        {
            //Decrement the amount of attacks
            atkIndex--;
            string[,] temp = new string[10, 5];
            int count = 0;

            //Go through array, reading in all values into a temporary array, apart from the value that has been
            //removed from the list.
            int i = 0;
            do
            {
                //If the current item is not the item to be removed
                if (!(count == removedVal))
                {
                    //Add this attack's details to the temporary array
                    temp[count, 0] = unitAttacks[count, 0];
                    temp[count, 1] = unitAttacks[count, 1];
                    temp[count, 2] = unitAttacks[count, 2];
                    temp[count, 3] = unitAttacks[count, 3];
                    temp[count, 4] = unitAttacks[count, 4];
                    count++;
                }
                i++;
                //Until all attacks have been checked
            } while (unitAttacks[i, 0] != null);

            //Set the attacks array to the temporary array, which now only contains the attacks that are not
            //removed
            unitAttacks = temp;
        }

        private void btnRemoveSp_Click(object sender, EventArgs e)
        {
            if (lstSp.Items.Count > 0)
            {
                //Update the spells array, and remove spell from list box.
                UpdateSpArray(lstSp.SelectedIndex);
                lstSp.Items.Remove(lstSp.SelectedItem);
            }
        }

        private void ClearAttackEntry()
        {
            //Clear all attack entry objects
            txtAtkName.Clear();
            nudAtkDamage.Value = 1;
            cbAtkType.SelectedIndex = 0;
            cbAtkDamage.SelectedIndex = 0;
            cbAtkMod.SelectedIndex = 0;
        }

        private void ClearSpellEntry()
        {
            //Clear all spell entry objects
            txtSpName.Clear();
            nudSpDamage.Value = 0;
            cbSpDamage.SelectedIndex = 0;
            rtbSpDesc.Clear();
            nudSpSlot.Value = 0;
            cbSpType.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all objects on form
            ClearAttackEntry();
            ClearSpellEntry();
            nudCha.Value = 1;
            nudStr.Value = 1;
            nudDex.Value = 1;
            nudWis.Value = 1;
            nudCon.Value = 1;
            nudInt.Value = 1;
            nudHealth.Value = 1;
            nudLevel.Value = 1;
            txtName.Clear();
            rtbUnitDesc.Clear();
        }

    }
}
