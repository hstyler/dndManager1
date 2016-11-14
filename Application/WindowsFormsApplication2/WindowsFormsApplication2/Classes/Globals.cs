using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Forms
{
    public static class Globals
    {
        public static string currentUser = "";
        public static bool newEnemy = false;
        public static bool[] Prefs = new Boolean[3];
        //0 - Attack Notifications
        //1 - AutoRoll
        //2 - Instructions
        public static string CustomVal = "";
        public static string CustomFilePath = "";
        public static bool PlayerInfo = true;
    }

    public static class EncounterData
    {
        public static string CurrentEncounter = "";

        //ENEMY ARRAYS //

        public static string[,] EnemyList = new String[50, 11];
        ////////////////////////EnemyList Array (dimension 2):
        //////////////////0 - Name, 1 - Desc, 2-8 - Attributes

        public static string[, ,] EnemyAttacks = new String[50, 10, 5];
        //////////////////////////////EnemyAttacks Array (dimension 3):
        /////////////1 - Name, 2 - Dice No., 3 - Damage Dice, 4 - Type

        public static string[, ,] EnemySpells = new String[50, 20, 6];
        ///////////////////////////////EnemySpells Array (dimension 3)
        ///1 - Name, 2 - Dice No., 3 - Damage Dice, 4 - Type, 5 - Slot

        public static int EnemyIndex = -1;


        // PLAYER ARRAYS //

        public static string[,] PlayerList = new String[50, 11];
        //////////////////////////////////////PlayerList Array:
        ///////////////////0 - Name, 1 - Desc, 2-8 - Attributes

        public static string[, ,] PlayerAttacks = new String[50, 10, 5];
        //PlayerAttacks Array (dimension 3):
        //1 - Name, 2 - Dice No., 3 - Damage Dice, 4 - Type

        public static string[, ,] PlayerSpells = new String[50, 20, 6];
        //PlayerSpells Array (dimension 3)
        //1 - Name, 2 - Dice No., 3 - Damage Dice, 4 - Type, 5 - Slot

        public static int PlayerIndex = -1;
    }
}
