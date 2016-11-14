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
    public partial class UnitInfo : Form
    {
        bool player;
        int currentIndex;

        public UnitInfo()
        {
            InitializeComponent();
        }

        private void UnitInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            player = Globals.PlayerInfo;
            currentIndex = Convert.ToInt32(Globals.CustomVal);

            if (player)
            {
                lblName.Text = "Name: " + EncounterData.PlayerList[currentIndex, 0];
                rtbDesc.Text = EncounterData.PlayerList[currentIndex, 1];
                lblStr.Text = "Strength: " + EncounterData.PlayerList[currentIndex, 2];
                lblDex.Text = "Dexterity: " + EncounterData.PlayerList[currentIndex, 3];
                lblCon.Text = "Constitution: " + EncounterData.PlayerList[currentIndex, 4];
                lblInt.Text = "Intelligence: " + EncounterData.PlayerList[currentIndex, 5];
                lblCha.Text = "Charisma: " + EncounterData.PlayerList[currentIndex, 6];
                lblWis.Text = "Wisdom: " + EncounterData.PlayerList[currentIndex, 7];

                int i = 0;

                while (EncounterData.PlayerAttacks[currentIndex, i, 0] != null)
                {
                    lstAtk.Items.Add(EncounterData.PlayerAttacks[currentIndex, i, 0]);
                    i++;
                }

                i = 0;

                while (EncounterData.PlayerSpells[currentIndex, i, 0] != null)
                {
                    lstSp.Items.Add(EncounterData.PlayerSpells[currentIndex, i, 0]);
                    i++;
                }
            }
            else
            {
                lblName.Text = "Name: " + EncounterData.EnemyList[currentIndex, 0];
                rtbDesc.Text = EncounterData.EnemyList[currentIndex, 1];
                lblStr.Text = "Strength: " + EncounterData.EnemyList[currentIndex, 2];
                lblDex.Text = "Dexterity: " + EncounterData.EnemyList[currentIndex, 3];
                lblCon.Text = "Constitution: " + EncounterData.EnemyList[currentIndex, 4];
                lblInt.Text = "Intelligence: " + EncounterData.EnemyList[currentIndex, 5];
                lblCha.Text = "Charisma: " + EncounterData.EnemyList[currentIndex, 6];
                lblWis.Text = "Wisdom: " + EncounterData.EnemyList[currentIndex, 7];

                int i = 0;

                while (EncounterData.EnemyAttacks[currentIndex, i, 0] != null)
                {
                    lstAtk.Items.Add(EncounterData.EnemyAttacks[currentIndex, i, 0]);
                    i++;
                }

                i = 0;

                while (EncounterData.EnemySpells[currentIndex, i, 0] != null)
                {
                    lstSp .Items.Add(EncounterData.EnemySpells[currentIndex, i, 0]);
                    i++;
                }
            }
        }

        private void lstAtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAtk.SelectedIndex > -1)
            {
                if (player)
                {
                    string damage = EncounterData.PlayerAttacks[currentIndex, lstAtk.SelectedIndex, 1] + "d" + EncounterData.PlayerAttacks[currentIndex, lstAtk.SelectedIndex, 2];
                    lblAtkDamage.Text = "Damage: " + damage;
                    lblAtkType.Text = "Type: " + EncounterData.PlayerAttacks[currentIndex, lstAtk.SelectedIndex, 3];
                    lblAtkMod.Text = "Mod: " + EncounterData.PlayerAttacks[currentIndex, lstAtk.SelectedIndex, 4];
                }
                else
                {
                    string damage = EncounterData.EnemyAttacks[currentIndex, lstAtk.SelectedIndex, 1] + "d" + EncounterData.EnemyAttacks[currentIndex, lstAtk.SelectedIndex, 2];
                    lblAtkDamage.Text = "Damage: " + damage;
                    lblAtkType.Text = "Type: " + EncounterData.EnemyAttacks[currentIndex, lstAtk.SelectedIndex, 3];
                    lblAtkMod.Text = "Mod: " + EncounterData.EnemyAttacks[currentIndex, lstAtk.SelectedIndex, 4];
                }
            }
        }

        private void lstSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSp.SelectedIndex > -1)
            {
                if (player)
                {
                    string damage = EncounterData.PlayerSpells[currentIndex, lstSp.SelectedIndex, 1] + "d" + EncounterData.PlayerSpells[currentIndex, lstSp.SelectedIndex, 2];
                    lblSpDamage.Text = "Damage: " + damage;
                    lblSpType.Text = "Type: " + EncounterData.PlayerSpells[currentIndex, lstAtk.SelectedIndex, 3];
                    lblSpSlot.Text = "Slot: " + EncounterData.PlayerSpells[currentIndex, lstAtk.SelectedIndex, 4];
                    rtbSpDesc.Text = EncounterData.PlayerSpells[currentIndex, lstAtk.SelectedIndex, 5];
                }
                else
                {
                    string damage = EncounterData.EnemyAttacks[currentIndex, lstSp.SelectedIndex, 1] + "d" + EncounterData.EnemyAttacks[currentIndex, lstSp.SelectedIndex, 2];
                    lblSpDamage.Text = "Damage: " + damage;
                    lblSpType.Text = "Type: " + EncounterData.EnemySpells[currentIndex, lstSp.SelectedIndex, 3];
                    lblSpSlot.Text = "Slot: " + EncounterData.EnemySpells[currentIndex, lstSp.SelectedIndex, 4];
                    rtbSpDesc.Text = EncounterData.EnemySpells[currentIndex, lstSp.SelectedIndex, 5];

                }
            }
        }
    }
}
