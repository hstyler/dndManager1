using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Forms;
using WindowsFormsApplication2.Project_Forms.Unit_Entries;
using System.IO;
using WindowsFormsApplication2.Project_Forms;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        int turnIndex = 0;
        bool encounterStarted = false;
        bool currentPlayer = false;
        int currentIndex = -1;
        bool allDefeated = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Display welcome message
            this.Text = "DnD Encounter Manager, Logged in as: " + Globals.currentUser;
            string filePath = Application.StartupPath + "\\Users\\" + Globals.currentUser;
            FileRW.ReadPrefs(filePath, Globals.currentUser);
        }

        private void btnTakeTurn_Click(object sender, EventArgs e)
        {
            //If there are no enemies, or no players, output an error
            if (lstEnemies.Items.Count == 0 || lstPlayers.Items.Count == 0)
            {
                MessageBox.Show("No units and/or enemies - make sure units have been added correctly");
            }
            else
            {
                //If all enemies have been defeated
                if (!allDefeated)
                {
                    //If the encounter has started already, go on to processing turns
                    if (encounterStarted == true)
                    {
                        //If an attack or spell has been chosen, but no target, output an error, and don't take any action
                        if (!((cbAtkSelector.SelectedIndex > 0 || cbSpSelector.SelectedIndex > 0) && cbTargSelector.SelectedIndex == 0))
                        {
                            /////THIS UNIT'S TURN/////

                            if (lstTurnOrder.Items[turnIndex].ToString().Contains("(e)"))
                            {
                                //Get their index in the enemy attacks/spells array
                                int enemyIndex = findIndex(lstTurnOrder.Items[turnIndex].ToString(), false, turnIndex);

                                //If an attack has been selected
                                if (cbAtkSelector.SelectedIndex > 0)
                                {
                                    //If the damage is above zero,
                                    if (Convert.ToInt32(EncounterData.EnemyAttacks[enemyIndex, cbAtkSelector.SelectedIndex - 1, 1]) > 0)
                                    {
                                        //Roll for damage:

                                        //Read in no of dice, and dice type
                                        int diceCount = Convert.ToInt32(EncounterData.EnemyAttacks[enemyIndex, cbAtkSelector.SelectedIndex - 1, 1]);
                                        int diceType = Convert.ToInt32(EncounterData.EnemyAttacks[enemyIndex, cbAtkSelector.SelectedIndex - 1, 2]);

                                        //Roll for damage using these two values
                                        int damage = CalculateDamage(diceCount, diceType);

                                        //Output attack message
                                        MessageBox.Show("Using " + EncounterData.EnemyAttacks[enemyIndex, cbAtkSelector.SelectedIndex - 1, 0] + " for " + damage + " damage");

                                        //If autoroll is on
                                        if (Globals.Prefs[1] == true)
                                        {
                                            //Generate random number from 1-20
                                            Random Random = new Random();
                                            int baseRoll = Random.Next(20) + 1;

                                            int baseMod = 0;

                                            //If the modifier for this attack is strength:
                                            if(EncounterData.EnemyAttacks[enemyIndex, cbAtkSelector.SelectedIndex - 1, 4] == "Strength")
                                            {
                                                //Read their strength
                                                baseMod = Convert.ToInt32(EncounterData.EnemyList[enemyIndex, 2]);
                                            }
                                            else
                                            {
                                                //Else read dexterity
                                                baseMod = Convert.ToInt32(EncounterData.EnemyList[enemyIndex, 3]);
                                            }

                                            //Calculate their attack bonus: strength or dexterity - 10 /2
                                            int finalMod = (baseMod - 10) / 2;

                                            //Add these two values to generate a final attack roll
                                            int finalRoll = baseRoll + finalMod;

                                            //If they have chosen another unit as a target, deal the calculated damage to them
                                            if (!(cbTargSelector.SelectedIndex == 0))
                                            {
                                                DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                            }
                                        }
                                        else
                                        {
                                            //Read in a custom attack roll value from the user
                                            int finalRoll = 0;
                                            Form customVal = new EnterValue();
                                            //Display form asking for attack roll value
                                            Globals.CustomVal = "Enter attack roll value:";
                                            customVal.ShowDialog();
                                            finalRoll = Convert.ToInt32(Globals.CustomVal);


                                            //If they have chosen another unit as a target, deal the calculated damage to them
                                            if (!(cbTargSelector.SelectedIndex == 0))
                                            {
                                                DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                            }
                                        }
                                    }
                                }

                                //If a spell has been selected
                                if (cbSpSelector.SelectedIndex > 0)
                                {
                                    if (Convert.ToInt32(EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 1]) > 0)
                                    {
                                        int finalRoll;

                                        //If autoroll has been turned on
                                        if (Globals.Prefs[1] == true)
                                        {
                                            //Generate a random number from 1-20
                                            Random Random = new Random();
                                            int baseRoll = Random.Next(20) + 1;

                                            //Work out their spell attack bonus (intelligence stat - 10 /2)
                                            int baseMod = Convert.ToInt32(EncounterData.EnemyList[enemyIndex, 5]);
                                            int finalMod = (baseMod - 10) / 2;

                                            //Add these two values to generate a final attack roll
                                            finalRoll = baseRoll + finalMod;
                                        }
                                        else
                                        {
                                            //Get a custom attack roll value from the user
                                            Form customVal = new EnterValue();
                                            Globals.CustomVal = "Enter attack roll value:";
                                            customVal.ShowDialog();
                                            finalRoll = Convert.ToInt32(Globals.CustomVal);
                                        }

                                        //Roll for damage

                                        //Read in no of dice, and dice type
                                        int diceCount = Convert.ToInt32(EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 1]);
                                        int diceType = Convert.ToInt32(EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 2]);
                                        //Roll for damage using these two values
                                        int damage = CalculateDamage(diceCount, diceType);

                                        //Output attack message
                                        MessageBox.Show("Using " + EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 0] + " for " + damage + " damage");

                                        //If they have chosen another unit as a target, deal the calculated damage to them
                                        if (!(cbTargSelector.SelectedIndex == 0))
                                        {
                                            DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                        }
                                    }
                                    else
                                    {
                                        //Just output message - no damage
                                        MessageBox.Show("Using " + EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 0]);
                                    }

                                    //Output effect of the spell for GM use.
                                    MessageBox.Show("Spell Effect: " + EncounterData.EnemySpells[enemyIndex, cbSpSelector.SelectedIndex - 1, 5]);
                                }

                            }
                            else
                            {
                                int playerIndex = findIndex(lstTurnOrder.Items[turnIndex].ToString(), true, turnIndex);

                                //If an attack has been selected
                                if (cbAtkSelector.SelectedIndex > 0)
                                {
                                    //If the damage is above zero,
                                    if (Convert.ToInt32(EncounterData.PlayerAttacks[playerIndex, cbAtkSelector.SelectedIndex - 1, 1]) > 0)
                                    {
                                        //Roll for damage:

                                        //Read in no of dice, and dice type
                                        int diceCount = Convert.ToInt32(EncounterData.PlayerAttacks[playerIndex, cbAtkSelector.SelectedIndex - 1, 1]);
                                        int diceType = Convert.ToInt32(EncounterData.PlayerAttacks[playerIndex, cbAtkSelector.SelectedIndex - 1, 2]);

                                        //Roll for damage using these two values
                                        int damage = CalculateDamage(diceCount, diceType);

                                        //Output attack message
                                        MessageBox.Show("Using " + EncounterData.PlayerAttacks[playerIndex, cbAtkSelector.SelectedIndex - 1, 0] + " for " + damage + " damage");

                                        //If autoroll is on
                                        if (Globals.Prefs[1] == true)
                                        {
                                            //Generate random number from 1-20
                                            Random Random = new Random();
                                            int baseRoll = Random.Next(20) + 1;

                                            int baseMod = 0;

                                            //If the modifier for this attack is strength:
                                            if (EncounterData.PlayerAttacks[playerIndex, cbAtkSelector.SelectedIndex - 1, 4] == "Strength")
                                            {
                                                //Read their strength
                                                baseMod = Convert.ToInt32(EncounterData.PlayerList[playerIndex, 2]);
                                            }
                                            else
                                            {
                                                //Else read dexterity
                                                baseMod = Convert.ToInt32(EncounterData.PlayerList[playerIndex, 3]);
                                            }

                                            //Calculate their attack bonus: strength or dexterity - 10 /2
                                            int finalMod = (baseMod - 10) / 2;

                                            //Add these two values to generate a final attack roll
                                            int finalRoll = baseRoll + finalMod;

                                            //If they have chosen another unit as a target, deal the calculated damage to them
                                            if (!(cbTargSelector.SelectedIndex == 0))
                                            {
                                                DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                            }
                                        }
                                        else
                                        {
                                            //Read in a custom attack roll value from the user
                                            int finalRoll = 0;
                                            Form customVal = new EnterValue();
                                            //Display form asking for attack roll value
                                            Globals.CustomVal = "Enter attack roll value:";
                                            customVal.ShowDialog();
                                            finalRoll = Convert.ToInt32(Globals.CustomVal);

                                            //If they have chosen another unit as a target, deal the calculated damage to them
                                            if (!(cbTargSelector.SelectedIndex == 0))
                                            {
                                                DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                            }
                                        }

                                    }
                                }

                                //If a spell has been selected
                                if (cbSpSelector.SelectedIndex > 0)
                                {
                                    //If the damage is above zero,
                                    if (Convert.ToInt32(EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 1]) > 0)
                                    {
                                        //Roll for damage:

                                        //Read in no of dice, and dice type
                                        int diceCount = Convert.ToInt32(EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 1]);
                                        int diceType = Convert.ToInt32(EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 2]);
                                        
                                        //Roll for damage using these two values
                                        int damage = CalculateDamage(diceCount, diceType);

                                        //Output attack message
                                        MessageBox.Show("Using " + EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 0] + " for " + damage + " damage");

                                        int finalRoll;

                                        //If autoroll is on
                                        if (Globals.Prefs[1] == true)
                                        {
                                            //Generate random number from 1-20
                                            Random Random = new Random();
                                            int baseRoll = Random.Next(20) + 1;

                                            //Read in their intelligence, and calculate modifier: int - 10/2
                                            int baseMod = Convert.ToInt32(EncounterData.PlayerList[playerIndex, 5]);
                                            int finalMod = (baseMod - 10) / 2;

                                            //Add the two values to generate a final attack roll
                                            finalRoll = baseRoll + finalMod;
                                        }
                                        else
                                        {
                                            //Read in a custom attack roll value from the user
                                            Form customVal = new EnterValue();
                                            //Display form asking for attack roll value
                                            Globals.CustomVal = "Enter attack roll value:";
                                            customVal.ShowDialog();
                                            finalRoll = Convert.ToInt32(Globals.CustomVal);
                                        }

                                        //If they have chosen another unit as a target, deal the calculated damage to them
                                        if (!(cbTargSelector.SelectedIndex == 0))
                                        {
                                            DealDamage(cbTargSelector.SelectedItem.ToString(), damage, finalRoll);
                                        }
                                    }
                                    else
                                    {
                                        //Output spell message
                                        MessageBox.Show("Using " + EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 0]);
                                    }
                                    //Output spell effect
                                    MessageBox.Show("Spell Effect: " + EncounterData.PlayerSpells[playerIndex, cbSpSelector.SelectedIndex - 1, 5]);
                                }

                            }

                            /////CURRENT UNIT TURN OVER//////
                            cbAtkSelector.SelectedIndex = 0;
                            cbSpSelector.SelectedIndex = 0;

                            turnIndex++;


                            //If the end of the turn cycle has been reached - i.e. the final unit has taken their turn,
                            //reset the turn index
                            if (turnIndex > EncounterData.PlayerIndex + EncounterData.EnemyIndex + 1)
                            {
                                turnIndex = 0;
                            }

                            bool Defeated = false;
                            //Read in the next unit to take a turn
                            string input = lstTurnOrder.Items[turnIndex].ToString();

                            if (input.Contains("(e)"))
                            {
                                //Read their health
                                int startPos = input.IndexOf('-', 2) + 2;
                                int length = input.IndexOf("(e)") - 1 - startPos;

                                //Read their name
                                string name = input.Substring(startPos, length);
                                allDefeated = true;

                                //Searching through all items in enemies list box
                                for (int i = 0; i < lstEnemies.Items.Count; i++)
                                {
                                    string currentString = lstEnemies.Items[i].ToString();

                                    //If current unit found
                                    if (currentString.Contains(name))
                                    {
                                        //And they are marked as defeated, set defeated = true
                                        if (currentString.Contains("Defeated"))
                                        {
                                            Defeated = true;
                                        }
                                    }

                                    //If a unit is not defeated, mark the enemies as not all defeated
                                    if (!currentString.Contains("Defeated"))
                                    {
                                        allDefeated = false;
                                    }
                                }
                            }
                            else
                            {
                                //Read their name
                                int startPos = input.IndexOf('-') + 2;
                                int length = input.IndexOf('(') - 1 - startPos;

                                string name = input.Substring(startPos, length);

                                //Searching through player list items
                                for (int i = 0; i < lstPlayers.Items.Count; i++)
                                {
                                    string currentString = lstPlayers.Items[i].ToString();

                                    //If the current item contains "Defeated", they have been defeated.
                                    if (currentString.Contains(name) && currentString.Contains("Defeated"))
                                    {
                                        Defeated = true;
                                    }
                                }
                            }

                            //If the current unit has been defeated, skip their turn
                            if (Defeated)
                            {
                                turnIndex++;
                                Defeated = false;
                            }

                            //If the end of the turn cycle has been reached - i.e. the final unit has taken their turn,
                            //reset the turn index
                            if (turnIndex > EncounterData.PlayerIndex + EncounterData.EnemyIndex + 1)
                            {
                                turnIndex = 0;
                            }

                            //Find the index of the next unit to take their turn in the combobox, and select
                            //this item, so it is clear to the user who is taking their turn
                            int newUnitIndex = 0;

                            //Search through each combobox item
                            for (int i = 0; i <= cbUnit.Items.Count - 1; i++)
                            {
                                //If the current item is the correct unit,
                                if (cbUnit.Items[i].ToString() == lstTurnOrder.Items[turnIndex].ToString())
                                {
                                    //Record the index in the combobox
                                    newUnitIndex = i;
                                }
                            }

                            //Select this item
                            cbUnit.SelectedIndex = newUnitIndex;

                            //Initialise the turn
                            initialiseTurn(turnIndex);
                        }
                        else
                        {
                            MessageBox.Show("An attack/spell has been selected, so a target must be chosen");
                        }
                    }
                    else
                    {
                        //If the encounter has not yet started:

                        //Load in the first unit in the list
                        initialiseTurn(0);
                        encounterStarted = true;

                        if (Globals.Prefs[2])
                        {
                            MessageBox.Show("The encounter has now begun. The unit to take a turn is found in the drop-down list labelled 'Unit'\n Choose the attack for them to use, and/or a spell, choose a target, then press 'Take Turn' to carry out the turn.\n The program will then move onto the next unit.");
                        }

                        bool player;

                        //Determine whether this unit is a play or enemy
                        if (lstTurnOrder.Items[0].ToString().Contains("(e)"))
                        {
                            player = false;
                        }
                        else
                        {
                            player = true;
                        }

                        //Find their index, and choose the correct option in the drop-down list
                        cbUnit.SelectedIndex = findIndex(lstTurnOrder.Items[0].ToString(), player, 0);
                        cbAtkSelector.SelectedIndex = 0;
                        cbSpSelector.SelectedIndex = 0;
                        cbTargSelector.SelectedIndex = 0;
                        //Change the button to signify the progression to the next turn,
                        //rather than starting the encounter
                        btnTakeTurn.Text = "Take Turn";
                    }
                }
                else
                {
                    MessageBox.Show("All enemies have been defeated!");
                }
            }

        }

        private void DealDamage(string target, int damage, int attackRoll)
        {
            bool player = true;
            int index = 0;

            if (target.Contains("(e)"))
            {
                for (int i = 0; i < lstEnemies.Items.Count; i++)
                {
                    int startPos = target.IndexOf('-', 1) + 2;
                    int endPos = target.IndexOf("(e)") - 1;
                    int length = endPos - startPos;
                    string currentString = target.Substring(startPos, length);

                    string searchString = lstEnemies.Items[i].ToString();
                    startPos = 0;
                    endPos = searchString.IndexOf('-') - 1;
                    length = endPos;
                    searchString = searchString.Substring(startPos, length);

                    if (currentString == searchString)
                    {
                        index = i;
                    }
                }

                player = false;
            }
            else
            {
                for (int i = 0; i < lstPlayers.Items.Count; i++)
                {
                    int startPos = target.IndexOf('-', 1) + 2;
                    int endPos = target.IndexOf("(p)") - 1;
                    int length = endPos - startPos;
                    string currentString = target.Substring(startPos, length);

                    string searchString = lstPlayers.Items[i].ToString();
                    startPos = 0;
                    endPos = searchString.IndexOf('-') - 2;
                    length = endPos;
                    searchString = searchString.Substring(startPos, length);

                    if (currentString == searchString)
                    {
                        index = i;
                    }
                }     
            }

            if (player)
            {
                if (Convert.ToInt32(EncounterData.PlayerList[index, 10]) < attackRoll)
                {
                    //Read the current data item, and replace the health in a new string
                    string currentItem = lstPlayers.Items[index].ToString();

                    if (!currentItem.Contains("Defeated"))
                    {
                        int endLocation = currentItem.IndexOf('-');
                        string newItem = currentItem.Substring(0, endLocation - 1);
                        int prevHealth = Convert.ToInt32(currentItem.Substring(endLocation + 2, currentItem.Length - endLocation - 9));

                        //Remove the old item, add the new amended item
                        lstPlayers.Items.Remove(lstPlayers.Items[currentIndex]);

                        if (prevHealth - damage > 0)
                        {
                            lstPlayers.Items.Add(newItem + " - " + (prevHealth - damage) + " health");
                        }
                        else
                        {
                            MessageBox.Show(currentItem + " was defeated!");
                            lstPlayers.Items.Add(newItem + " - Defeated!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Target already defeated!");
                    }
                }
                else
                {
                    MessageBox.Show("Attack/Spell missed!");
                }
            }
            else
            {
                //Read the current data item, and replace the health in a new string
                string currentItem = lstEnemies.Items[index].ToString();

                if (Convert.ToInt32(EncounterData.EnemyList[index, 10]) < attackRoll)
                {
                    if (!currentItem.Contains("Defeated"))
                    {
                        int endLocation = currentItem.IndexOf('-');
                        string newItem = currentItem.Substring(0, endLocation - 1);
                        int prevHealth = Convert.ToInt32(currentItem.Substring(endLocation + 2, currentItem.Length - endLocation - 9));

                        //Remove the old item, add the new amended item
                        lstEnemies.Items.Remove(lstEnemies.Items[currentIndex]);

                        if (prevHealth - damage > 0)
                        {
                            lstEnemies.Items.Add(newItem + " - " + (prevHealth - damage) + " health");
                        }
                        else
                        {
                            MessageBox.Show(currentItem + " was defeated!");
                            lstEnemies.Items.Add(newItem + " - Defeated!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Target already defeated!");
                    }
                }
                else
                {
                    MessageBox.Show("Attack/Spell missed!");
                }
            }
        }

        private int CalculateDamage(int diceCount, int diceType)
        {
            int damage = 0;
            int baseDamage = 0;

            //If they have autoroll turned on:
            if (Globals.Prefs[1] == true)
            {
                Random random = new Random();
                //For the number of times specified, roll a die of the chosen
                //number of sides, and add this to a total of damage
                for (int i = 1; i <= diceCount; i++)
                {
                    baseDamage += random.Next(diceType);
                }

            }
            else
                //If they have autoroll turned off:
            {
                //Open enter value form, asking for a custom value of damage
                Globals.CustomVal = "Enter a value for damage";
                Form newVal = new EnterValue();
                newVal.ShowDialog();

                //Read in the value they have entered
                baseDamage = Convert.ToInt32(Globals.CustomVal);
            }

            //Show the modifiers form
            Form Mod = new Modifiers();
            Mod.ShowDialog();

            //Multiply the base damage from rolls by the modifier that has been chosen.
            damage = Convert.ToInt32(baseDamage * Convert.ToDouble(Globals.CustomVal));

            //Output damage from the attack/spell
            return damage;
        }

        private int findIndex(string inputString, bool player, int index)
        {
            //If they are an enemy
            if (!player)
            {
                int enemyIndex = 0;
                int i = 0;

                //Reading through each item of the drop-down list until the current unit is found:
                while (i <= cbUnit.Items.Count - 1 && cbUnit.Items[i].ToString() != inputString)
                {
                    //If the current item is marked with an (e), so is an enemy, increment the index
                    if (cbUnit.Items[i].ToString().Substring(cbUnit.Items[i].ToString().Length - 4, 4).Contains("(e)"))
                    {
                        enemyIndex++;
                    }

                    i++;
                }

                //At this point, all enemies before the current unit in the list have been counted in the index,
                //so the end result is the enemy index of that unit.

                return enemyIndex;
            }
            else
            {
                //See routine above ^
                int playerIndex = 0;
                int i = 0;

                while (i <= cbUnit.Items.Count - 1 && cbUnit.Items[i].ToString() != inputString)
                {
                    if (cbUnit.Items[i].ToString().Substring(cbUnit.Items[i].ToString().Length - 4, 4).Contains("(p)"))
                    {
                        playerIndex++;
                    }

                    i++;
                }

                return playerIndex;
            }
        }

        private void initialiseTurn(int unitIndex)
        {
            string inputString = lstTurnOrder.Items[unitIndex].ToString();
            int marker = inputString.IndexOf('-');
            string unitName = inputString.Substring(marker + 2, inputString.Length - marker - 6);
            string unitType = inputString.Substring(inputString.Length - 4, 4);

            lstTurnOrder.SelectedIndex = unitIndex;

            //If their unit type is player
            if (unitType.Contains("(p)"))
            {
                int PlayerIndex = findIndex(inputString, true, unitIndex);

                int j = 0;


                currentIndex = PlayerIndex;
                currentPlayer = true;

                //Clear all items in attack box
                cbAtkSelector.Items.Clear();
                cbAtkSelector.Items.Add("(None)");

                //Add in their attacks
                while (EncounterData.PlayerAttacks[PlayerIndex, j, 0] != null)
                {
                    cbAtkSelector.Items.Add(EncounterData.PlayerAttacks[PlayerIndex, j, 0]);
                    j++;
                }

                //Clear all items in spell box
                cbSpSelector.Items.Clear();
                cbSpSelector.Items.Add("(None)");

                j = 0;

                //Add in their spells
                while (EncounterData.PlayerSpells[PlayerIndex, j, 0] != null)
                {
                    cbSpSelector.Items.Add(EncounterData.PlayerSpells[PlayerIndex, j, 0]);
                    j++;
                }
            }
            else
            {
                //See routine above ^
                int EnemyIndex = findIndex(inputString, false, unitIndex);

                int j = 0;

                currentIndex = EnemyIndex;
                currentPlayer = false;

                cbAtkSelector.Items.Clear();
                cbAtkSelector.Items.Add("(None)");

                while (EncounterData.EnemyAttacks[EnemyIndex, j, 0] != null)
                {
                    cbAtkSelector.Items.Add(EncounterData.EnemyAttacks[EnemyIndex, j, 0]);
                    j++;
                }

                cbSpSelector.Items.Clear();
                cbSpSelector.Items.Add("(None)");

                j = 0;

                while (EncounterData.EnemySpells[EnemyIndex, j, 0] != null)
                {
                    cbSpSelector.Items.Add(EncounterData.EnemySpells[EnemyIndex, j, 0]);
                    j++;
                }
            }
        }

        private void enemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When they choose to create a new enemy, open the create new unit form
            //and set the newEnemy setting to true, so that the form can identify that an enemy
            //is being created instead of a player
            Form newEnemy = new AddUnit();
            Globals.newEnemy = true;
            newEnemy.Show();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When they choose to create a new player, open the create new unit form
            //and set the newPlayer setting to true, so that the form can identify that a player
            //is being created instead of an enemy
            Form newPlayer = new AddUnit();
            Globals.newEnemy = false;
            newPlayer.Show();
        }

        private void saveEncounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (encounterStarted == true)
            {
                //When they choose to save an encounter, open a save file dialog set to their 
                //encounters folder, and run the save encounter procedure
                string baseDirectory = Application.StartupPath + "\\Users\\" + Globals.currentUser + "\\Encounters\\";
                Globals.CustomVal = "Enter a name:";
                Form SaveEnc = new EnterValue();
                SaveEnc.ShowDialog();
                string finalPath = baseDirectory + Globals.CustomVal + ".txt";

                StreamWriter WriteEncounter = new StreamWriter(finalPath);

                //Write all items of turn order listbox
                for (int i = 0; i < lstTurnOrder.Items.Count; i++)
                {
                    WriteEncounter.WriteLine(lstTurnOrder.Items[i]);
                }

                WriteEncounter.WriteLine("");

                //Write all enemies list box items
                for (int i = 0; i < lstEnemies.Items.Count; i++)
                {
                    WriteEncounter.WriteLine(lstEnemies.Items[i]);
                }

                WriteEncounter.WriteLine("");

                //Write all players list box items
                for (int i = 0; i < lstPlayers.Items.Count; i++)
                {
                    WriteEncounter.WriteLine(lstPlayers.Items[i]);
                }

                WriteEncounter.WriteLine("");

                //Write all items from unit combobox
                for (int i = 0; i < cbUnit.Items.Count; i++)
                {
                    WriteEncounter.WriteLine(cbUnit.Items[i]);
                }

                WriteEncounter.WriteLine("");

                //Write the selected unit in the combobox
                WriteEncounter.WriteLine(cbUnit.SelectedIndex);

                WriteEncounter.WriteLine("");

                //Write all items from target combobox
                for (int i = 0; i < cbTargSelector.Items.Count; i++)
                {
                    WriteEncounter.WriteLine(cbTargSelector.Items[i]);
                }

                WriteEncounter.WriteLine("");

                //Write the currently selected target
                WriteEncounter.WriteLine(cbTargSelector.SelectedIndex.ToString());

                WriteEncounter.WriteLine("");

                int j = 0;

                //Until the last player has been written:
                while (EncounterData.PlayerList[j, 0] != null)
                {
                    //Write attributes
                    for (int i = 0; i <= 10; i++)
                    {
                        WriteEncounter.WriteLine(EncounterData.PlayerList[j, i]);
                    }

                    int k = 0;

                    //Write all attack values
                    while (EncounterData.PlayerAttacks[j, k, 0] != null)
                    {
                        for (int i = 0; i <= 4; i++)
                        {
                            WriteEncounter.WriteLine(EncounterData.PlayerAttacks[j, k, i]);
                        }

                        k++;
                    }

                    WriteEncounter.WriteLine("SPSTART");
                    k = 0;

                    //Write all spell values
                    while (EncounterData.PlayerSpells[j, k, 0] != null)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            WriteEncounter.WriteLine(EncounterData.PlayerSpells[j, k, i]);
                        }

                        k++;
                    }

                    j++;

                    WriteEncounter.WriteLine("-");
                }

                WriteEncounter.WriteLine("ESTART");

                j = 0;

                //See player write routine above ^^^
                while (EncounterData.EnemyList[j, 0] != null)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        WriteEncounter.WriteLine(EncounterData.EnemyList[j, i]);
                    }

                    int k = 0;

                    while (EncounterData.EnemyAttacks[j, k, 0] != null)
                    {
                        for (int i = 0; i <= 4; i++)
                        {
                            WriteEncounter.WriteLine(EncounterData.EnemyAttacks[j, k, i]);
                        }

                        k++;
                    }

                    WriteEncounter.WriteLine("SPSTART");
                    k = 0;

                    while (EncounterData.EnemySpells[j, k, 0] != null)
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            WriteEncounter.WriteLine(EncounterData.EnemySpells[j, k, i]);
                        }

                        k++;
                    }

                    j++;
                    WriteEncounter.WriteLine("-");
                }

                //Write all globals variables to the file
                WriteEncounter.WriteLine("");
                WriteEncounter.WriteLine(turnIndex);
                WriteEncounter.WriteLine(currentIndex);
                WriteEncounter.WriteLine(currentPlayer);
                WriteEncounter.WriteLine(encounterStarted);
                WriteEncounter.WriteLine(allDefeated);
                WriteEncounter.WriteLine(EncounterData.PlayerIndex);
                WriteEncounter.WriteLine(EncounterData.EnemyIndex);
                WriteEncounter.Close();
            }
            else
            {
                MessageBox.Show("Ensure an encounter has been started before saving.");
            }
        }

        private void tsiLoadEncounter_Click(object sender, EventArgs e)
        {
            encounterStarted = false;

            //When they choose to load an encounter, open load file dialog
            //set to their encounters folder
            Globals.CustomFilePath = Application.StartupPath + "\\Users\\" + Globals.currentUser + "\\Encounters";
            Form LoadEncounter = new LoadFile();
            LoadEncounter.ShowDialog();

            StreamReader ReadEncounter = new StreamReader(Globals.CustomFilePath);

            string currentLine = "";


            currentLine = ReadEncounter.ReadLine();

            lstTurnOrder.Items.Clear();

            //Read each item in this block into the turn order listbox
            while (currentLine != "")
            {
                lstTurnOrder.Items.Add(currentLine);
                currentLine = ReadEncounter.ReadLine();
            }

            currentLine = ReadEncounter.ReadLine();

            lstEnemies.Items.Clear();

            //Read items into the enemies list box
            while (currentLine != "")
            {
                lstEnemies.Items.Add(currentLine);
                currentLine = ReadEncounter.ReadLine();
            }

            currentLine = ReadEncounter.ReadLine();

            //Read items into the players list box
            while (currentLine != "")
            {
                lstPlayers.Items.Add(currentLine);
                currentLine = ReadEncounter.ReadLine();
            }


            currentLine = ReadEncounter.ReadLine();

            cbUnit.Items.Clear();

            //Read items into the unit selector combobox
            while (currentLine != "")
            {
                cbUnit.Items.Add(currentLine);
                currentLine = ReadEncounter.ReadLine();
            }

            //Select the current unit
            cbUnit.SelectedIndex = Convert.ToInt32(ReadEncounter.ReadLine());

            ReadEncounter.ReadLine();

            currentLine = ReadEncounter.ReadLine();

            cbTargSelector.Items.Clear();

            //Read items into the target selector combobox
            while (currentLine != "")
            {
                cbTargSelector.Items.Add(currentLine);
                currentLine = ReadEncounter.ReadLine();
            }

            //Select the previously chosen item
            cbTargSelector.SelectedIndex = Convert.ToInt32(ReadEncounter.ReadLine());

            ReadEncounter.ReadLine();

            int j = 0;

            currentLine = ReadEncounter.ReadLine();

            //Until the end of the player block is found:
            while (!(currentLine == "ESTART"))
            {
                //Read in all of the unit's stats
                EncounterData.PlayerList[j, 0] = currentLine;

                for (int i = 1; i <= 10; i++)
                {
                    EncounterData.PlayerList[j, i] = ReadEncounter.ReadLine();
                }

                int k = 0;

                currentLine = ReadEncounter.ReadLine();

                //Until the end of the attack block is found:
                while (!(currentLine == "SPSTART"))
                {
                    //Read each line into attacks array
                    EncounterData.PlayerAttacks[j, k, 0] = currentLine;

                    for (int i = 1; i <= 4; i++)
                    {
                        EncounterData.PlayerAttacks[j, k, i] = ReadEncounter.ReadLine();
                    }

                    k++;

                    currentLine = ReadEncounter.ReadLine();
                }

                k = 0;

                currentLine = ReadEncounter.ReadLine();

                //Until the end of the spells block is found:
                while (!(currentLine == "-"))
                {
                    //Read each item into the spells array
                    EncounterData.PlayerSpells[j, k, 0] = currentLine;

                    for (int i = 1; i <= 5; i++)
                    {
                        EncounterData.PlayerSpells[j, k, i] = ReadEncounter.ReadLine();
                    }

                    k++;
                    currentLine = ReadEncounter.ReadLine();
                }

                currentLine = ReadEncounter.ReadLine();
            }

            currentLine = ReadEncounter.ReadLine();

            //Unitl the end of the file is found:

            //See player read routine above ^^^
            while (!(currentLine == "-"))
            {
                EncounterData.EnemyList[j, 0] = currentLine;

                for (int i = 1; i <= 10; i++)
                {
                    EncounterData.EnemyList[j, i] = ReadEncounter.ReadLine();
                }

                int k = 0;

                currentLine = ReadEncounter.ReadLine();

                while (!(currentLine == "SPSTART"))
                {
                    EncounterData.EnemyAttacks[j, k, 0] = currentLine;

                    for (int i = 1; i <= 4; i++)
                    {
                        EncounterData.EnemyAttacks[j, k, i] = ReadEncounter.ReadLine();
                    }

                    k++;
                    currentLine = ReadEncounter.ReadLine();
                }

                k = 0;

                currentLine = ReadEncounter.ReadLine();

                while (!(currentLine == "-"))
                {
                    EncounterData.EnemySpells[j, k, 0] = currentLine;

                    for (int i = 1; i <= 5; i++)
                    {
                        EncounterData.EnemySpells[j, k, i] = ReadEncounter.ReadLine();
                    }

                    k++;
                    currentLine = ReadEncounter.ReadLine();
                }
            }

            ReadEncounter.ReadLine();

            //Read global variables from file
            turnIndex = Convert.ToInt32(ReadEncounter.ReadLine());
            currentIndex = Convert.ToInt32(ReadEncounter.ReadLine());
            initialiseTurn(currentIndex);
            currentPlayer = Convert.ToBoolean(ReadEncounter.ReadLine());
            encounterStarted = Convert.ToBoolean(ReadEncounter.ReadLine());
            allDefeated = Convert.ToBoolean(ReadEncounter.ReadLine());
            initialiseTurn(currentIndex);
            EncounterData.PlayerIndex = Convert.ToInt32(ReadEncounter.ReadLine());
            EncounterData.EnemyIndex = Convert.ToInt32(ReadEncounter.ReadLine());

            cbAtkSelector.SelectedIndex = 0;
            cbSpSelector.SelectedIndex = 0;
            cbTargSelector.SelectedIndex = 0;

            //Change the text of start encounter button to 'Take Turn'
            if (encounterStarted == true)
            {
                btnTakeTurn.Text = "Take Turn";
            }

            ReadEncounter.Close();
        }

        private void tsiImportUnit_Click(object sender, EventArgs e)
        {

        }

        private void tsiPreferences_Click(object sender, EventArgs e)
        {
            //Show the preferences form, hide main form
            Form Prefs = new Preferences();
            Prefs.Show();
        }

        private void importUnit(bool player)
        {
            //When they choose to import a unit, open a open file dialog set to their 
            //players/enemies folder, and run the load unit procedure
            
            string baseDirectory = "";
            bool existingFiles = true;

            //If they have chosen to load a player, set the start directory to that of the players folder
            if (player)
            {
                baseDirectory = Application.StartupPath + "\\Users\\" + Globals.currentUser + "\\Units\\Players";
            }
            //If they have chosen to load an enemy, set the start directory to that of the enemies folder
            else
            {
                baseDirectory = Application.StartupPath + "\\Users\\" + Globals.currentUser + "\\Units\\Enemies";       
            }
            
            //If there are some files in the players/enemies directory, allow them to choose a file to load
            if (Directory.EnumerateFileSystemEntries(baseDirectory).Any())
            {
                Globals.CustomFilePath = baseDirectory;
                //Open file selection form
                Form newUnit = new LoadFile();
                newUnit.ShowDialog();
            }
            else
            {
                //Output error saying that there are no files that can be loaded
                existingFiles = false;
                MessageBox.Show("No files found, please create a unit of this type to load one");
            }

            //If there are files in the relevant folder:
            if (existingFiles)
            {
                FileRW.LoadUnit(Globals.CustomFilePath, player);

                //If they have auto-roll turned on:
                if (Globals.Prefs[1] == true)
                {
                    if (player)
                    {
                        //Read in their dexterity
                        int dex = Convert.ToInt32(EncounterData.PlayerList[EncounterData.PlayerIndex, 3]);
                        Random random = new Random();
                        //Subtract 10 from dex, and divide by 2 to calculate their dex modifier
                        int dexMod = (dex - 10) / 2;
                        //Add the modifier to a random roll from 1-20 to calculate their initiative
                        int initiative = random.Next(20) + dexMod;

                        addPlayer(initiative);
                    }
                    else
                    {
                        allDefeated = false;
                        //See above ^^^^
                        int dex = Convert.ToInt32(EncounterData.EnemyList[EncounterData.EnemyIndex, 3]);
                        Random random = new Random();
                        int dexMod = (dex - 10) / 2;
                        int initiative = random.Next(20) + dexMod;

                        addEnemy(initiative);
                    }
                }
                else
                {
                    //If they do not have auto-roll turned on, ask them for initiative value and add the unit
                    //to list boxes

                    bool validInit = true;

                    do
                    {
                        validInit = true;

                        Globals.CustomVal = "Enter a value for initiative";
                        Form newVal = new EnterValue();
                        newVal.ShowDialog();

                        //If it is not 2 characters or under, reject it and ask again.
                        if (Globals.CustomVal.Length >= 3)
                        {
                            MessageBox.Show("Initiative should be under 3 digits");
                        }

                        try
                        {
                            double.Parse(Globals.CustomVal);
                        }
                        catch
                        {
                            validInit = false;
                        }

                        if (!validInit)
                        {
                            MessageBox.Show("Enter a numeric initiative value");
                        }

                    } while (Globals.CustomVal.Length >= 3 || !validInit);


                    string initiative = Globals.CustomVal;

                    if (player)
                    {
                        //Add new player items to all list boxes on the form.
                        addPlayer(Convert.ToInt32(initiative));
                    }
                    else
                    {
                        allDefeated = false;
                        //Add new enemy items to all list boxes on the form.
                        addEnemy(Convert.ToInt32(initiative));
                    }
                }
            }
        }

        private void enemyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Import a non-player unit
            importUnit(false);
        }

        private void playerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Import a player unit
            importUnit(true);
        }

        private void addEnemy(int initiative)
        {
            int existingNo = 0;

            //if there is at least one enemy
            if (lstEnemies.Items.Count > 0)
            {
                //For each item in the enemies list box
                for (int i = 0; i < lstEnemies.Items.Count; i++)
                {
                    //If it already contains a unit with this name, increment the number of units
                    if (lstEnemies.Items[i].ToString().Contains(EncounterData.EnemyList[EncounterData.EnemyIndex, 0]))
                    {
                        existingNo++;
                    }
                }
            }

            //If there is only one unit with that name:
            if (existingNo == 0)
            {
                //Add them to the list boxes:

                //Add to enemies list with health listed
                lstEnemies.Items.Add(EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 8] + " health");
                //to unit selection combo box with initiative
                cbUnit.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (e)");
                //to target selection combo box with initiative
                cbTargSelector.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (e)");
                //and to turn order list box (and sort turn order list)
                addTurnListBox(false, initiative, 0);
                sortTurnListBox();
            }
            //If there is more than one with that name
            else
            {
                //Add them to the list boxes, and for all entries, add a number on the end of their name
                //signifying that there is more than one unit called that:

                //Add to enemies list with health listed
                lstEnemies.Items.Add(EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (" + existingNo.ToString() + ") - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 8] + " health");
                //to unit selection combo box with initiative
                cbUnit.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (" + existingNo.ToString() + ") (e)");
                //to target selection combo box with initiative
                cbTargSelector.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (" + existingNo.ToString() + ") (e)");
                //and to turn order list box (and sort turn order list)
                addTurnListBox(false, initiative, existingNo);
                sortTurnListBox();
            }
        }

        private void addPlayer(int initiative)
        {
            int existingNo = 0;

            //if there is at least one player
            if (lstPlayers.Items.Count > 0)
            {
                //For each item in the players list box
                for (int i = 0; i < lstPlayers.Items.Count; i++)
                {
                    //If it already contains a unit with this name, increment the number of units
                    if (lstPlayers.Items[i].ToString().Contains(EncounterData.PlayerList[EncounterData.PlayerIndex, 0]))
                    {
                        existingNo++;
                    }
                }
            }

            //If there is only one unit with that name:
            if (existingNo == 0)
            {
                //Add them to the list boxes:

                //Add to players list with health listed
                lstPlayers.Items.Add(EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 8] + " health");
                //to unit selection combo box with initiative
                cbUnit.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (p)");
                //to target selection combo box with initiative
                cbTargSelector.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (p)");
                //and to turn order list box (and sort turn order list)
                addTurnListBox(true, initiative, 0);
                sortTurnListBox();
            }
            else
            //If there is more than one with that name
            {
                //Add them to the list boxes, and for all entries, add a number on the end of their name
                //signifying that there is more than one unit called that:

                //Add to players list with health listed
                lstPlayers.Items.Add(EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (" + existingNo.ToString() + ") - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 8] + " health");
                //to unit selection combo box with initiative
                cbUnit.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (" + existingNo.ToString() + ") (p)");
                //to target selection combo box with initiative
                cbTargSelector.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (" + existingNo.ToString() + ") (p)");
                //and to turn order list box (and sort turn order list)
                addTurnListBox(true, initiative, existingNo);
                sortTurnListBox();
            }
        }

        private void btnEditInit_Click(object sender, EventArgs e)
        {
            //Show the dialog for entering a new initiative value
            do
            {
                Globals.CustomVal = "Enter a value for initiative";
                Form newVal = new EnterValue();
                newVal.ShowDialog();

                //If it is not 2 digits or lower, reject and ask again.
                if (Globals.CustomVal.Length >= 3)
                {
                    MessageBox.Show("Initiative should be under 3 digits");
                }

            } while (Globals.CustomVal.Length >= 3);

            //Remove initiative from old string, insert the new value.
            string currentItem = lstTurnOrder.SelectedItem.ToString();
            int marker = currentItem.IndexOf('-', 1);
            string newItem = Globals.CustomVal + currentItem.Substring(marker - 1, currentItem.Length - (marker - 1));

            //Remove the old item, add the new one.
            lstTurnOrder.Items.Remove(lstTurnOrder.SelectedItem);
            lstTurnOrder.Items.Add(newItem);
            sortTurnListBox();
        }

        private void btnEditHealthEn_Click(object sender, EventArgs e)
        {
            //Show dialog for entering new health value
            bool validHealth = true;

            do
            {
                validHealth = true;

                Globals.CustomVal = "Enter a value for health";
                Form newVal = new EnterValue();
                newVal.ShowDialog();

                try
                {
                    int.Parse(Globals.CustomVal);
                }
                catch
                {
                    validHealth = false;
                }

                if (!validHealth)
                {
                    MessageBox.Show("Enter an integer health value");
                }

            } while (!validHealth);

            //Read the current data item, and replace the health in a new string
            string currentItem = lstEnemies.SelectedItem.ToString();
            int endLocation = currentItem.IndexOf('-');
            string newItem = currentItem.Substring(0, endLocation - 1);

            //Remove the old item, ready to add the new amended item
            lstEnemies.Items.Remove(lstEnemies.SelectedItem);

            //If the unit is lowered below 0 health, mark as defeated, else add new item
            if (Convert.ToInt32(Globals.CustomVal) > 0)
            {
                lstEnemies.Items.Add(newItem + " - " + Globals.CustomVal + " health");
            }
            else
            {
                lstEnemies.Items.Add(newItem + " - Defeated!");
            }
        }

        private void btnEditHealthPl_Click(object sender, EventArgs e)
        {
            if (encounterStarted)
            {
                //See edit health routine above^^^^^^^^
                bool validHealth = true;

                do
                {
                    validHealth = true;

                    Globals.CustomVal = "Enter a value for health";
                    Form newVal = new EnterValue();
                    newVal.ShowDialog();

                    try
                    {
                        int.Parse(Globals.CustomVal);
                    }
                    catch
                    {
                        validHealth = false;
                    }

                    if (!validHealth)
                    {
                        MessageBox.Show("Enter an integer health value");
                    }

                } while (!validHealth);

                string currentItem = lstPlayers.SelectedItem.ToString();
                int endLocation = currentItem.IndexOf('-');
                string newItem = currentItem.Substring(0, endLocation - 1);

                //Remove the old item, ready to add the new amended item
                lstPlayers.Items.Remove(lstPlayers.SelectedItem);

                //If the unit is lowered below 0 health, mark as defeated, else add new item
                if (Convert.ToInt32(Globals.CustomVal) > 0)
                {
                    lstPlayers.Items.Add(newItem + " - " + Globals.CustomVal + " health");
                }
                else
                {
                    lstPlayers.Items.Add(newItem + " - Defeated!");
                }
            }
        }

        private int getInitiative(string inputString)
        {
            //Find the location of the hyphen marking the split between their initiative and their name
            int marker = inputString.IndexOf('-', 1);
            //Return all characters between the start and this position in the string
            return Convert.ToInt32(inputString.Substring(0, marker - 1));
        }

        private int getHealth(string inputString)
        {
            //Find the location of the hyphen marking the split between their health and their name
            int marker = inputString.IndexOf('-');
            //Return all characters between the start and this position in the string
            return Convert.ToInt32(inputString.Substring(marker, inputString.Length - marker));
        }

        private void addTurnListBox(bool player, int initiative, int existingNo)
        {
            //For the new unit, add a new item to the end, in the same format, marking the unit as a player
            //or enemy at the end of the string
            if (player)
            {
                if (existingNo == 0)
                {
                    lstTurnOrder.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (p)");
                }
                else
                {
                    lstTurnOrder.Items.Add(initiative + " - " + EncounterData.PlayerList[EncounterData.PlayerIndex, 0] + " (" + existingNo.ToString() + ") (p)");
                }
            }
            else
            {
                if (existingNo == 0)
                {
                    lstTurnOrder.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (e)");
                }
                else
                {
                    lstTurnOrder.Items.Add(initiative + " - " + EncounterData.EnemyList[EncounterData.EnemyIndex, 0] + " (" + existingNo.ToString() + ") (e)");
                }
            }
        }

        private void sortTurnListBox()
        {
            if (lstTurnOrder.Items.Count > 1)
            {
                string[] lbItems = new string[lstTurnOrder.Items.Count];

                //Read in all values in the turn order list box
                for (int i = 0; i <= lstTurnOrder.Items.Count - 1; i++)
                {
                    lbItems[i] = (lstTurnOrder.Items[i].ToString());
                }

                //This is used to sort all of the items in the list box in descending order based on their initiative,
                //i.e. a unit with init 20 will be placed above one with 10, -1, etc.

                //Reading through all items in the array:
                for (int i = 0; i < lbItems.Length - 1; i++)
                {
                    int j = i + 1;

                    //If the value considered is still part of the array
                    while (j > 0)
                    {
                        //If the left item is less than the right:
                        if (getInitiative(lbItems[j - 1]) < getInitiative(lbItems[j]))
                        {
                            //Swap them
                            string temp = lbItems[j - 1];
                            lbItems[j - 1] = lbItems[j];
                            lbItems[j] = temp;
                        }
                        j--;
                    }
                }

                //Clear list box and populate with the new list of items.

                lstTurnOrder.Items.Clear();

                for (int i = 0; i <= lbItems.Length - 1; i++)
                {
                    lstTurnOrder.Items.Add(lbItems[i]);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Remove current user, close form, open login form
            Globals.currentUser = "";
            this.Close();
            Form logIn = new LogIn();
            logIn.Show();
        }

        private void cbSpSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If they have chosen a spell
            if (cbSpSelector.SelectedIndex > 0)
            {
                //If they are a player
                if (currentPlayer == true)
                {
                    //Read in damage, add to damage text box
                    string damage = EncounterData.PlayerSpells[currentIndex, cbSpSelector.SelectedIndex - 1, 1] + "d" + EncounterData.PlayerSpells[currentIndex, cbSpSelector.SelectedIndex - 1, 2];
                    lblSpDamage.Text = "Damage: " + damage;
                    //Read in description, add to description text box.
                    rtbSpDescription.Text = "Description: " + EncounterData.PlayerSpells[currentIndex, cbSpSelector.SelectedIndex - 1, 5];
                }
                //If they are an enemy
                else
                {
                    //Read in damage, add to damage text box
                    string damage = EncounterData.EnemySpells[currentIndex, cbSpSelector.SelectedIndex - 1, 1] + "d" + EncounterData.EnemySpells[currentIndex, cbSpSelector.SelectedIndex - 1, 2];
                    lblSpDamage.Text = "Damage: " + damage;
                    //Read in description, add to description text box.
                    rtbSpDescription.Text = "Description: " + EncounterData.EnemySpells[currentIndex, cbSpSelector.SelectedIndex - 1, 5];
                }
            }
            else
            {
                lblSpDamage.Text = "Damage: ";
                rtbSpDescription.Text = "Description: ";
            }
        }

        private void cbAtkSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If they have chosen an attack
            if (cbAtkSelector.SelectedIndex > 0)
            {
                //If they are a player
                if (currentPlayer == true)
                {
                    //Read in damage, add to damage text box
                    string damage = EncounterData.PlayerAttacks[currentIndex, cbAtkSelector.SelectedIndex - 1, 1] + "d" + EncounterData.PlayerAttacks[currentIndex, cbAtkSelector.SelectedIndex - 1, 2];
                    lblAtkDamage.Text = "Damage: " + damage;
                }
                //If they are an enemy
                else
                {
                    //Read in damage, add to damage text box
                    string damage = EncounterData.EnemyAttacks[currentIndex, cbAtkSelector.SelectedIndex - 1, 1] + "d" + EncounterData.EnemyAttacks[currentIndex, cbAtkSelector.SelectedIndex - 1, 2];
                    lblAtkDamage.Text = "Damage: " + damage;
                }
            }
            else
            {
                lblAtkDamage.Text = "Damage: ";
            }
        }

        private void btnCurUnitInfo_Click(object sender, EventArgs e)
        {
            //Determine whether the current unit is a player
            if (currentPlayer)
            {
                Globals.PlayerInfo = true;
            }
            else
            {
                Globals.PlayerInfo = false;
            }

            //Open the unit info form, passing in the current index of the unit, and whether
            //they are a player or enemy

            Globals.CustomVal = Convert.ToString(currentIndex);
            Form UnitInfo = new UnitInfo();
            UnitInfo.ShowDialog();
        }

        private void btnEnemyInfo_Click(object sender, EventArgs e)
        {
            //Find the selected unit
            Globals.CustomVal = Convert.ToString(lstEnemies.SelectedIndex);
            //Open unit info form
            Form UnitInfo = new UnitInfo();
            Globals.PlayerInfo = false;
            UnitInfo.ShowDialog();
        }

        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            //Find selected unit
            Globals.CustomVal = Convert.ToString(lstPlayers.SelectedIndex);
            //Open unit info form
            Form UnitInfo = new UnitInfo();
            Globals.PlayerInfo = true;
            UnitInfo.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all turn controls
            cbAtkSelector.SelectedIndex = 0;
            cbSpSelector.SelectedIndex = 0;
            lblAtkDamage.Text = "Damage:";
            lblSpDamage.Text = "Damage:";
            rtbSpDescription.Text = "Description:";
            cbTargSelector.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Close main form
            this.Close();
            Application.Exit();
        }

        private void scMainContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rollDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rollDice = new RollDice();
            rollDice.ShowDialog();
        }

        private void btnEditInit_Click_1(object sender, EventArgs e)
        {
            if (lstTurnOrder.Items.Count > 0)
            {
                //Show the dialog for entering a new initiative value
                do
                {
                    Globals.CustomVal = "Enter a value for initiative";
                    Form newVal = new EnterValue();
                    newVal.ShowDialog();

                    //If it is not 2 digits or lower, reject and ask again.
                    if (Globals.CustomVal.Length >= 3)
                    {
                        MessageBox.Show("Initiative should be under 3 digits");
                    }

                } while (Globals.CustomVal.Length >= 3);

                //Remove initiative from old string, insert the new value.
                string currentItem = lstTurnOrder.SelectedItem.ToString();
                int marker = currentItem.IndexOf('-', 1);
                string newItem = Globals.CustomVal + currentItem.Substring(marker - 1, currentItem.Length - (marker - 1));

                //Remove the old item, add the new one.
                lstTurnOrder.Items.Remove(lstTurnOrder.SelectedItem);
                lstTurnOrder.Items.Add(newItem);
                sortTurnListBox();
            }
        }

        private void btnEditHealthEn_Click_1(object sender, EventArgs e)
        {
            if (encounterStarted)
            {
                //Show dialog for entering new health value
                bool validHealth = true;

                do
                {
                    validHealth = true;

                    Globals.CustomVal = "Enter a value for health";
                    Form newVal = new EnterValue();
                    newVal.ShowDialog();

                    try
                    {
                        int.Parse(Globals.CustomVal);
                    }
                    catch
                    {
                        validHealth = false;
                    }

                    if (!validHealth)
                    {
                        MessageBox.Show("Enter an integer health value");
                    }

                } while (!validHealth);

                //Read the current data item, and replace the health in a new string
                string currentItem = lstEnemies.SelectedItem.ToString();
                int endLocation = currentItem.IndexOf('-');
                string newItem = currentItem.Substring(0, endLocation - 1);

                //Remove the old item, ready to add the new amended item
                lstEnemies.Items.Remove(lstEnemies.SelectedItem);

                //If the unit is lowered below 0 health, mark as defeated, else add new item
                if (Convert.ToInt32(Globals.CustomVal) > 0)
                {
                    lstEnemies.Items.Add(newItem + " - " + Globals.CustomVal + " health");
                }
                else
                {
                    lstEnemies.Items.Add(newItem + " - Defeated!");
                }
            }
        }
    }
}
