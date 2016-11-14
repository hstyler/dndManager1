using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    class FileRW
    {
        public static string currentLineData = "";

        public static void WritePrefs(string username, string filePath)
        {
            //Open their preferences file
            StreamWriter writeUserPrefs = new StreamWriter(filePath + "\\" + username + "prefs.txt");
            //Write their new options to the file
            writeUserPrefs.WriteLine("AttackNotifications = " + Globals.Prefs[0]);
            writeUserPrefs.WriteLine("AutoRoll = " + Globals.Prefs[1]);
            writeUserPrefs.WriteLine("Instructions = " + Globals.Prefs[2]);
            writeUserPrefs.Close();
        }

        public static void WriteUser(string username, string password, string filePath)
        {
            //Create a new file and write password to file
            StreamWriter writeUserDetails = new StreamWriter(filePath + "\\" + username + ".txt");
            writeUserDetails.WriteLine(password);
            writeUserDetails.Close();
        }

        public static string ReadUserPass(string username, string filePath)
        {
            //Read their password from their user file
            StreamReader readPass = new StreamReader(filePath + "\\" + username + ".txt");
            string actualPass = readPass.ReadLine();
            readPass.Close();
            return actualPass;
        }

        public static void UpdateUserPass(string username, string filePath, string newPass)
        {
            //Delete previous user file
            File.Delete(filePath + "\\" + username + ".txt");

            //Create new file and write new password to it
            StreamWriter writeUserDetails = new StreamWriter(filePath + "\\" + username + ".txt");
            writeUserDetails.WriteLine(newPass);
            writeUserDetails.Close();
        }

        public static void SaveEncounter(string fileName)
        {

        }

        public static void SaveUnit(string fileName, string[,] spells, string[,] attacks, string name, string[] attributes, string desc, int[] arrayLengths)
        {
            string type = "";

            //Determine which type of unit is being saved, to know where to save the file
            if (Globals.newEnemy == true)
            {
                type = "Enemies";
            }
            else
            {
                type = "Players";
            }

            //Determine new file name
            string newFileName = fileName + "\\Units\\" + type + "\\" + name + ".txt";

            //If a file with this name doesn't already exist
            if(!File.Exists(newFileName))
            {
                //Create it
                StreamWriter saveUnit = new StreamWriter(fileName + "\\Units\\" + type + "\\" + name + ".txt");

                //Write the unit's name
                saveUnit.WriteLine(name);

                //Write their description
                saveUnit.WriteLine("-----Description-----");
                saveUnit.WriteLine(desc);

                //Write all attributes
                saveUnit.WriteLine("-----Attributes-----");
                saveUnit.WriteLine("Strength: " + attributes[0]);
                saveUnit.WriteLine("Dexterity: " + attributes[1]);
                saveUnit.WriteLine("Constitution: " + attributes[2]);
                saveUnit.WriteLine("Intelligence: " + attributes[3]);
                saveUnit.WriteLine("Charisma: " + attributes[4]);
                saveUnit.WriteLine("Wisdom: " + attributes[5]);
                saveUnit.WriteLine("Health: " + attributes[6]);
                saveUnit.WriteLine("Level: " + attributes[7]);
                saveUnit.WriteLine("AC: " + attributes[8]);

                //Write each attack, and all details about that attack
                saveUnit.WriteLine("-----Attacks-----");
                for (int i = 0; i <= arrayLengths[0] - 1; i++)
                {
                    saveUnit.WriteLine("~" + attacks[i, 0]);
                    saveUnit.WriteLine("Damage Count: " + attacks[i, 1]);
                    saveUnit.WriteLine("Damage Die: " + attacks[i, 2]);
                    saveUnit.WriteLine("Type: " + attacks[i, 3]);
                    saveUnit.WriteLine("Modifier: " + attacks[i, 4]);
                }

                //Write each spell, and all details about that spell
                saveUnit.WriteLine("-----Spells-----");

                for (int i = 0; i <= arrayLengths[1] - 1; i++)
                {
                    saveUnit.WriteLine("~" + spells[i, 0]);
                    saveUnit.WriteLine("Damage Count: " + spells[i, 1]);
                    saveUnit.WriteLine("Damage Die: " + spells[i, 2]);
                    saveUnit.WriteLine("Type: " + spells[i, 3]);
                    saveUnit.WriteLine("Slot: " + spells[i, 4]);
                    saveUnit.WriteLine("Description: " + spells[i, 5]);
                }

                //Close the file
                saveUnit.Close();
            }
            else
            {
                //If a file already exists with that name, tell them to rename the unit.
                MessageBox.Show("A unit already exists with this name, please choose another name");
            }
        }

        public static void LoadEncounter(string fileName)
        {

        }

        public static void LoadUnit(string fileName, bool Player)
        {
            if(fileName.Contains(".txt"))
            {
                //When a unit is loaded, this code will add all of the details stored
                //in their unit files into the global arrays used to store them

                //Add one to the count of players/enemies depending on what they have chosen to load
                StreamReader loadUnit = new StreamReader(fileName);
                if (Player == true)
                {
                    EncounterData.PlayerIndex++;
                    //Read their name
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 0] = loadUnit.ReadLine();
                    loadUnit.ReadLine();
                    //Read their description
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 1] = loadUnit.ReadLine();
                    loadUnit.ReadLine();
                    //Read all attributes
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 2] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 3] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 4] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 5] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 6] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 7] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 8] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 9] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.PlayerList[EncounterData.PlayerIndex, 10] = ReadInfo(loadUnit.ReadLine());
                    loadUnit.ReadLine();

                
                    int attackIndex = -1;
                    string currentLine = loadUnit.ReadLine();

                    //While the current line is part of the Attacks section:
                    while (!(currentLine == "-----Spells-----"))
                    {
                        attackIndex++;
                        //Read in attack details
                        EncounterData.PlayerAttacks[EncounterData.PlayerIndex, attackIndex, 0] = currentLine.Substring(1, currentLine.Length - 1);
                        EncounterData.PlayerAttacks[EncounterData.PlayerIndex, attackIndex, 1] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerAttacks[EncounterData.PlayerIndex, attackIndex, 2] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerAttacks[EncounterData.PlayerIndex, attackIndex, 3] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerAttacks[EncounterData.PlayerIndex, attackIndex, 4] = ReadInfo(loadUnit.ReadLine());
                        currentLine = loadUnit.ReadLine();
                    }

                    int spellIndex = -1;

                    //While the end of the file has not been reached, so while the current line
                    //is part of the Spells section:
                    while (!(loadUnit.EndOfStream))
                    {
                        spellIndex++;
                        //Read in spell details
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 0] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 1] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 2] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 3] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 4] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.PlayerSpells[EncounterData.PlayerIndex, spellIndex, 5] = ReadInfo(loadUnit.ReadLine());
                    }
                }
                else
                {
                    EncounterData.EnemyIndex++;
                    //Read their name
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 0] = loadUnit.ReadLine();
                    loadUnit.ReadLine();
                    //Read their desc
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 1] = loadUnit.ReadLine();
                    loadUnit.ReadLine();
                    //Read attributes
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 2] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 3] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 4] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 5] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 6] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 7] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 8] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 9] = ReadInfo(loadUnit.ReadLine());
                    EncounterData.EnemyList[EncounterData.EnemyIndex, 10] = ReadInfo(loadUnit.ReadLine());
                    loadUnit.ReadLine();


                    int attackIndex = -1;
                    string currentLine = loadUnit.ReadLine();

                    //While in Attacks section:
                    while (!(currentLine == "-----Spells-----"))
                    {
                        attackIndex++;
                        //Read attack details
                        EncounterData.EnemyAttacks[EncounterData.EnemyIndex, attackIndex, 0] = currentLine.Substring(1, currentLine.Length - 1);
                        EncounterData.EnemyAttacks[EncounterData.EnemyIndex, attackIndex, 1] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemyAttacks[EncounterData.EnemyIndex, attackIndex, 2] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemyAttacks[EncounterData.EnemyIndex, attackIndex, 3] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemyAttacks[EncounterData.EnemyIndex, attackIndex, 4] = ReadInfo(loadUnit.ReadLine());
                        currentLine = loadUnit.ReadLine();
                    }

                    int spellIndex = -1;

                    //While in Spells section:
                    while (!(loadUnit.EndOfStream))
                    {
                        spellIndex++;
                        //Read spell details
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 0] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 1] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 2] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 3] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 4] = ReadInfo(loadUnit.ReadLine());
                        EncounterData.EnemySpells[EncounterData.EnemyIndex, spellIndex, 5] = ReadInfo(loadUnit.ReadLine());
                    }
                }
            }


        }

        public static void ReadPrefs(string filePath, string username)
        {
            //Open prefs file
            StreamReader readPrefs = new StreamReader(filePath + "\\" + username + "prefs.txt");

            //Read in all preference options
            for(int i = 0; i <=2; i++)
            {
                string currentPref = readPrefs.ReadLine();
                Globals.Prefs[i] = Convert.ToBoolean(currentPref.Substring(currentPref.Length - 5, 5));
            }

            readPrefs.Close();
        }

        public static string ReadInfo(string currentLine)
        {
            //Get the location of the colon in the current line
            int startPos = currentLine.IndexOf(":") + 2;
            //Take out all data to the right of this
            currentLineData = currentLine.Substring(startPos, currentLine.Length - startPos); 
            //Output it
            return currentLineData;
        }
    }
}
