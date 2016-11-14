namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoadEncounter = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEncounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiImportUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstDivider1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tstDivider2 = new System.Windows.Forms.ToolStripTextBox();
            this.rollDiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMainContainer = new System.Windows.Forms.SplitContainer();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbTargSelector = new System.Windows.Forms.ComboBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.gbSpells = new System.Windows.Forms.GroupBox();
            this.rtbSpDescription = new System.Windows.Forms.RichTextBox();
            this.lblSpDamage = new System.Windows.Forms.Label();
            this.cbSpSelector = new System.Windows.Forms.ComboBox();
            this.gbAttacks = new System.Windows.Forms.GroupBox();
            this.lblAtkDamage = new System.Windows.Forms.Label();
            this.cbAtkSelector = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCurUnitInfo = new System.Windows.Forms.Button();
            this.btnTakeTurn = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.scTurnsPlayers = new System.Windows.Forms.SplitContainer();
            this.btnEditInit = new System.Windows.Forms.Button();
            this.lblTurnOrder = new System.Windows.Forms.Label();
            this.lstTurnOrder = new System.Windows.Forms.ListBox();
            this.tcUnitTabs = new System.Windows.Forms.TabControl();
            this.tpEnemies = new System.Windows.Forms.TabPage();
            this.btnEditHealthEn = new System.Windows.Forms.Button();
            this.btnEnemyInfo = new System.Windows.Forms.Button();
            this.lstEnemies = new System.Windows.Forms.ListBox();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.tpPlayers = new System.Windows.Forms.TabPage();
            this.btnEditHealthPl = new System.Windows.Forms.Button();
            this.btnPlayerInfo = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).BeginInit();
            this.scMainContainer.Panel1.SuspendLayout();
            this.scMainContainer.Panel2.SuspendLayout();
            this.scMainContainer.SuspendLayout();
            this.gbSpells.SuspendLayout();
            this.gbAttacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTurnsPlayers)).BeginInit();
            this.scTurnsPlayers.Panel1.SuspendLayout();
            this.scTurnsPlayers.Panel2.SuspendLayout();
            this.scTurnsPlayers.SuspendLayout();
            this.tcUnitTabs.SuspendLayout();
            this.tpEnemies.SuspendLayout();
            this.tpPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.btnLogOut.Location = new System.Drawing.Point(608, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tstDivider1,
            this.tsmOptions,
            this.tstDivider2,
            this.rollDiceToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(683, 27);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.BackColor = System.Drawing.SystemColors.Control;
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNewUnit,
            this.tsiLoadEncounter,
            this.saveEncounterToolStripMenuItem,
            this.tsiImportUnit,
            this.exitToolStripMenuItem1});
            this.tsmFile.Font = new System.Drawing.Font("Gadugi", 9F);
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(38, 23);
            this.tsmFile.Text = "File";
            // 
            // tsiNewUnit
            // 
            this.tsiNewUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemyToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.tsiNewUnit.Name = "tsiNewUnit";
            this.tsiNewUnit.Size = new System.Drawing.Size(159, 22);
            this.tsiNewUnit.Text = "New Unit";
            // 
            // enemyToolStripMenuItem
            // 
            this.enemyToolStripMenuItem.Name = "enemyToolStripMenuItem";
            this.enemyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enemyToolStripMenuItem.Text = "Enemy";
            this.enemyToolStripMenuItem.Click += new System.EventHandler(this.enemyToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // tsiLoadEncounter
            // 
            this.tsiLoadEncounter.Name = "tsiLoadEncounter";
            this.tsiLoadEncounter.Size = new System.Drawing.Size(159, 22);
            this.tsiLoadEncounter.Text = "Load Encounter";
            this.tsiLoadEncounter.Click += new System.EventHandler(this.tsiLoadEncounter_Click);
            // 
            // saveEncounterToolStripMenuItem
            // 
            this.saveEncounterToolStripMenuItem.Name = "saveEncounterToolStripMenuItem";
            this.saveEncounterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveEncounterToolStripMenuItem.Text = "Save Encounter";
            this.saveEncounterToolStripMenuItem.Click += new System.EventHandler(this.saveEncounterToolStripMenuItem_Click);
            // 
            // tsiImportUnit
            // 
            this.tsiImportUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemyToolStripMenuItem1,
            this.playerToolStripMenuItem1});
            this.tsiImportUnit.Name = "tsiImportUnit";
            this.tsiImportUnit.Size = new System.Drawing.Size(159, 22);
            this.tsiImportUnit.Text = "Import Unit";
            this.tsiImportUnit.Click += new System.EventHandler(this.tsiImportUnit_Click);
            // 
            // enemyToolStripMenuItem1
            // 
            this.enemyToolStripMenuItem1.Name = "enemyToolStripMenuItem1";
            this.enemyToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.enemyToolStripMenuItem1.Text = "Enemy";
            this.enemyToolStripMenuItem1.Click += new System.EventHandler(this.enemyToolStripMenuItem1_Click);
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.playerToolStripMenuItem1.Text = "Player";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.playerToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // tstDivider1
            // 
            this.tstDivider1.BackColor = System.Drawing.SystemColors.Control;
            this.tstDivider1.Name = "tstDivider1";
            this.tstDivider1.Size = new System.Drawing.Size(10, 23);
            this.tstDivider1.Text = "|";
            // 
            // tsmOptions
            // 
            this.tsmOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tsmOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiPreferences});
            this.tsmOptions.Font = new System.Drawing.Font("Gadugi", 9F);
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Size = new System.Drawing.Size(62, 23);
            this.tsmOptions.Text = "Options";
            // 
            // tsiPreferences
            // 
            this.tsiPreferences.Name = "tsiPreferences";
            this.tsiPreferences.Size = new System.Drawing.Size(137, 22);
            this.tsiPreferences.Text = "Preferences";
            this.tsiPreferences.Click += new System.EventHandler(this.tsiPreferences_Click);
            // 
            // tstDivider2
            // 
            this.tstDivider2.BackColor = System.Drawing.SystemColors.Control;
            this.tstDivider2.Name = "tstDivider2";
            this.tstDivider2.Size = new System.Drawing.Size(10, 23);
            this.tstDivider2.Text = "|";
            // 
            // rollDiceToolStripMenuItem
            // 
            this.rollDiceToolStripMenuItem.Name = "rollDiceToolStripMenuItem";
            this.rollDiceToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.rollDiceToolStripMenuItem.Text = "Roll Dice";
            this.rollDiceToolStripMenuItem.Click += new System.EventHandler(this.rollDiceToolStripMenuItem_Click);
            // 
            // scMainContainer
            // 
            this.scMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainContainer.IsSplitterFixed = true;
            this.scMainContainer.Location = new System.Drawing.Point(0, 27);
            this.scMainContainer.Name = "scMainContainer";
            // 
            // scMainContainer.Panel1
            // 
            this.scMainContainer.Panel1.AutoScroll = true;
            this.scMainContainer.Panel1.AutoScrollMinSize = new System.Drawing.Size(135, 0);
            this.scMainContainer.Panel1.Controls.Add(this.cbUnit);
            this.scMainContainer.Panel1.Controls.Add(this.cbTargSelector);
            this.scMainContainer.Panel1.Controls.Add(this.lblTarget);
            this.scMainContainer.Panel1.Controls.Add(this.gbSpells);
            this.scMainContainer.Panel1.Controls.Add(this.gbAttacks);
            this.scMainContainer.Panel1.Controls.Add(this.btnClear);
            this.scMainContainer.Panel1.Controls.Add(this.btnCurUnitInfo);
            this.scMainContainer.Panel1.Controls.Add(this.btnTakeTurn);
            this.scMainContainer.Panel1.Controls.Add(this.lblUnit);
            this.scMainContainer.Panel1.Controls.Add(this.lblCurrentTurn);
            this.scMainContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.scMainContainer_Panel1_Paint);
            this.scMainContainer.Panel1MinSize = 135;
            // 
            // scMainContainer.Panel2
            // 
            this.scMainContainer.Panel2.Controls.Add(this.scTurnsPlayers);
            this.scMainContainer.Panel2MinSize = 135;
            this.scMainContainer.Size = new System.Drawing.Size(683, 454);
            this.scMainContainer.SplitterDistance = 320;
            this.scMainContainer.TabIndex = 5;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(90, 42);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(214, 21);
            this.cbUnit.TabIndex = 24;
            this.ttInfo.SetToolTip(this.cbUnit, "The unit that is currently taking their turn.");
            // 
            // cbTargSelector
            // 
            this.cbTargSelector.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.cbTargSelector.FormattingEnabled = true;
            this.cbTargSelector.Items.AddRange(new object[] {
            "(None)"});
            this.cbTargSelector.Location = new System.Drawing.Point(86, 303);
            this.cbTargSelector.Name = "cbTargSelector";
            this.cbTargSelector.Size = new System.Drawing.Size(218, 22);
            this.cbTargSelector.TabIndex = 17;
            this.ttInfo.SetToolTip(this.cbTargSelector, "Target of attack or spell. Must be chosen if an attack/spell is being used");
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblTarget.Location = new System.Drawing.Point(11, 302);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(82, 25);
            this.lblTarget.TabIndex = 23;
            this.lblTarget.Text = "Target: ";
            // 
            // gbSpells
            // 
            this.gbSpells.Controls.Add(this.rtbSpDescription);
            this.gbSpells.Controls.Add(this.lblSpDamage);
            this.gbSpells.Controls.Add(this.cbSpSelector);
            this.gbSpells.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbSpells.Location = new System.Drawing.Point(12, 168);
            this.gbSpells.Name = "gbSpells";
            this.gbSpells.Size = new System.Drawing.Size(292, 123);
            this.gbSpells.TabIndex = 22;
            this.gbSpells.TabStop = false;
            this.gbSpells.Text = "Spells";
            // 
            // rtbSpDescription
            // 
            this.rtbSpDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSpDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSpDescription.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.rtbSpDescription.Location = new System.Drawing.Point(16, 68);
            this.rtbSpDescription.Name = "rtbSpDescription";
            this.rtbSpDescription.Size = new System.Drawing.Size(250, 49);
            this.rtbSpDescription.TabIndex = 19;
            this.rtbSpDescription.Text = "Description:";
            // 
            // lblSpDamage
            // 
            this.lblSpDamage.AutoSize = true;
            this.lblSpDamage.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblSpDamage.Location = new System.Drawing.Point(13, 44);
            this.lblSpDamage.Name = "lblSpDamage";
            this.lblSpDamage.Size = new System.Drawing.Size(62, 17);
            this.lblSpDamage.TabIndex = 18;
            this.lblSpDamage.Text = "Damage:";
            // 
            // cbSpSelector
            // 
            this.cbSpSelector.FormattingEnabled = true;
            this.cbSpSelector.Items.AddRange(new object[] {
            "(None)"});
            this.cbSpSelector.Location = new System.Drawing.Point(16, 20);
            this.cbSpSelector.Name = "cbSpSelector";
            this.cbSpSelector.Size = new System.Drawing.Size(250, 22);
            this.cbSpSelector.TabIndex = 0;
            this.ttInfo.SetToolTip(this.cbSpSelector, "Attack to use. If they are not using a spell, selecte (None).");
            this.cbSpSelector.SelectedIndexChanged += new System.EventHandler(this.cbSpSelector_SelectedIndexChanged);
            // 
            // gbAttacks
            // 
            this.gbAttacks.Controls.Add(this.lblAtkDamage);
            this.gbAttacks.Controls.Add(this.cbAtkSelector);
            this.gbAttacks.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbAttacks.Location = new System.Drawing.Point(12, 80);
            this.gbAttacks.Name = "gbAttacks";
            this.gbAttacks.Size = new System.Drawing.Size(292, 82);
            this.gbAttacks.TabIndex = 21;
            this.gbAttacks.TabStop = false;
            this.gbAttacks.Text = "Attacks";
            // 
            // lblAtkDamage
            // 
            this.lblAtkDamage.AutoSize = true;
            this.lblAtkDamage.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblAtkDamage.Location = new System.Drawing.Point(15, 47);
            this.lblAtkDamage.Name = "lblAtkDamage";
            this.lblAtkDamage.Size = new System.Drawing.Size(62, 17);
            this.lblAtkDamage.TabIndex = 17;
            this.lblAtkDamage.Text = "Damage:";
            // 
            // cbAtkSelector
            // 
            this.cbAtkSelector.FormattingEnabled = true;
            this.cbAtkSelector.Items.AddRange(new object[] {
            "(None)"});
            this.cbAtkSelector.Location = new System.Drawing.Point(16, 19);
            this.cbAtkSelector.Name = "cbAtkSelector";
            this.cbAtkSelector.Size = new System.Drawing.Size(250, 22);
            this.cbAtkSelector.TabIndex = 1;
            this.ttInfo.SetToolTip(this.cbAtkSelector, "Attack to use. If they are not attacking, selecte (None).");
            this.cbAtkSelector.SelectedIndexChanged += new System.EventHandler(this.cbAtkSelector_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.btnClear.Location = new System.Drawing.Point(176, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 43);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCurUnitInfo
            // 
            this.btnCurUnitInfo.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.btnCurUnitInfo.Location = new System.Drawing.Point(16, 334);
            this.btnCurUnitInfo.Name = "btnCurUnitInfo";
            this.btnCurUnitInfo.Size = new System.Drawing.Size(154, 43);
            this.btnCurUnitInfo.TabIndex = 19;
            this.btnCurUnitInfo.Text = "View Full Unit Info";
            this.btnCurUnitInfo.UseVisualStyleBackColor = true;
            this.btnCurUnitInfo.Click += new System.EventHandler(this.btnCurUnitInfo_Click);
            // 
            // btnTakeTurn
            // 
            this.btnTakeTurn.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.btnTakeTurn.Location = new System.Drawing.Point(12, 382);
            this.btnTakeTurn.Name = "btnTakeTurn";
            this.btnTakeTurn.Size = new System.Drawing.Size(292, 59);
            this.btnTakeTurn.TabIndex = 18;
            this.btnTakeTurn.Text = "Start Encounter";
            this.btnTakeTurn.UseVisualStyleBackColor = true;
            this.btnTakeTurn.Click += new System.EventHandler(this.btnTakeTurn_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblUnit.Location = new System.Drawing.Point(23, 40);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(61, 25);
            this.lblUnit.TabIndex = 17;
            this.lblUnit.Text = "Unit: ";
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.lblCurrentTurn.Location = new System.Drawing.Point(69, 5);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(168, 31);
            this.lblCurrentTurn.TabIndex = 17;
            this.lblCurrentTurn.Text = "Current Turn:";
            // 
            // scTurnsPlayers
            // 
            this.scTurnsPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scTurnsPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTurnsPlayers.IsSplitterFixed = true;
            this.scTurnsPlayers.Location = new System.Drawing.Point(0, 0);
            this.scTurnsPlayers.Name = "scTurnsPlayers";
            this.scTurnsPlayers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scTurnsPlayers.Panel1
            // 
            this.scTurnsPlayers.Panel1.Controls.Add(this.btnEditInit);
            this.scTurnsPlayers.Panel1.Controls.Add(this.lblTurnOrder);
            this.scTurnsPlayers.Panel1.Controls.Add(this.lstTurnOrder);
            // 
            // scTurnsPlayers.Panel2
            // 
            this.scTurnsPlayers.Panel2.Controls.Add(this.tcUnitTabs);
            this.scTurnsPlayers.Size = new System.Drawing.Size(359, 454);
            this.scTurnsPlayers.SplitterDistance = 201;
            this.scTurnsPlayers.TabIndex = 13;
            // 
            // btnEditInit
            // 
            this.btnEditInit.Location = new System.Drawing.Point(12, 161);
            this.btnEditInit.Name = "btnEditInit";
            this.btnEditInit.Size = new System.Drawing.Size(334, 35);
            this.btnEditInit.TabIndex = 14;
            this.btnEditInit.Text = "Edit Initiative";
            this.btnEditInit.UseVisualStyleBackColor = true;
            this.btnEditInit.Click += new System.EventHandler(this.btnEditInit_Click_1);
            // 
            // lblTurnOrder
            // 
            this.lblTurnOrder.AutoSize = true;
            this.lblTurnOrder.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblTurnOrder.Location = new System.Drawing.Point(121, 5);
            this.lblTurnOrder.Name = "lblTurnOrder";
            this.lblTurnOrder.Size = new System.Drawing.Size(118, 25);
            this.lblTurnOrder.TabIndex = 13;
            this.lblTurnOrder.Text = "Turn Order:";
            // 
            // lstTurnOrder
            // 
            this.lstTurnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstTurnOrder.FormattingEnabled = true;
            this.lstTurnOrder.Location = new System.Drawing.Point(12, 34);
            this.lstTurnOrder.Name = "lstTurnOrder";
            this.lstTurnOrder.ScrollAlwaysVisible = true;
            this.lstTurnOrder.Size = new System.Drawing.Size(334, 121);
            this.lstTurnOrder.TabIndex = 12;
            // 
            // tcUnitTabs
            // 
            this.tcUnitTabs.Controls.Add(this.tpEnemies);
            this.tcUnitTabs.Controls.Add(this.tpPlayers);
            this.tcUnitTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUnitTabs.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.tcUnitTabs.Location = new System.Drawing.Point(0, 0);
            this.tcUnitTabs.Name = "tcUnitTabs";
            this.tcUnitTabs.SelectedIndex = 0;
            this.tcUnitTabs.Size = new System.Drawing.Size(357, 247);
            this.tcUnitTabs.TabIndex = 2;
            // 
            // tpEnemies
            // 
            this.tpEnemies.Controls.Add(this.btnEditHealthEn);
            this.tpEnemies.Controls.Add(this.btnEnemyInfo);
            this.tpEnemies.Controls.Add(this.lstEnemies);
            this.tpEnemies.Controls.Add(this.lblEnemies);
            this.tpEnemies.Location = new System.Drawing.Point(4, 23);
            this.tpEnemies.Name = "tpEnemies";
            this.tpEnemies.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnemies.Size = new System.Drawing.Size(349, 220);
            this.tpEnemies.TabIndex = 0;
            this.tpEnemies.Text = "Enemies";
            this.tpEnemies.UseVisualStyleBackColor = true;
            // 
            // btnEditHealthEn
            // 
            this.btnEditHealthEn.Location = new System.Drawing.Point(8, 141);
            this.btnEditHealthEn.Name = "btnEditHealthEn";
            this.btnEditHealthEn.Size = new System.Drawing.Size(334, 33);
            this.btnEditHealthEn.TabIndex = 16;
            this.btnEditHealthEn.Text = "Edit Health";
            this.btnEditHealthEn.UseVisualStyleBackColor = true;
            this.btnEditHealthEn.Click += new System.EventHandler(this.btnEditHealthEn_Click_1);
            // 
            // btnEnemyInfo
            // 
            this.btnEnemyInfo.Location = new System.Drawing.Point(8, 177);
            this.btnEnemyInfo.Name = "btnEnemyInfo";
            this.btnEnemyInfo.Size = new System.Drawing.Size(334, 34);
            this.btnEnemyInfo.TabIndex = 15;
            this.btnEnemyInfo.Text = "Open Unit Info";
            this.btnEnemyInfo.UseVisualStyleBackColor = true;
            // 
            // lstEnemies
            // 
            this.lstEnemies.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstEnemies.FormattingEnabled = true;
            this.lstEnemies.ItemHeight = 14;
            this.lstEnemies.Location = new System.Drawing.Point(8, 34);
            this.lstEnemies.Name = "lstEnemies";
            this.lstEnemies.ScrollAlwaysVisible = true;
            this.lstEnemies.Size = new System.Drawing.Size(334, 102);
            this.lstEnemies.Sorted = true;
            this.lstEnemies.TabIndex = 14;
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblEnemies.Location = new System.Drawing.Point(86, 5);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(169, 25);
            this.lblEnemies.TabIndex = 14;
            this.lblEnemies.Text = "Current Enemies:";
            // 
            // tpPlayers
            // 
            this.tpPlayers.Controls.Add(this.btnEditHealthPl);
            this.tpPlayers.Controls.Add(this.btnPlayerInfo);
            this.tpPlayers.Controls.Add(this.lstPlayers);
            this.tpPlayers.Controls.Add(this.lblPlayers);
            this.tpPlayers.Location = new System.Drawing.Point(4, 23);
            this.tpPlayers.Name = "tpPlayers";
            this.tpPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayers.Size = new System.Drawing.Size(349, 220);
            this.tpPlayers.TabIndex = 1;
            this.tpPlayers.Text = "Players";
            this.tpPlayers.UseVisualStyleBackColor = true;
            // 
            // btnEditHealthPl
            // 
            this.btnEditHealthPl.Location = new System.Drawing.Point(8, 141);
            this.btnEditHealthPl.Name = "btnEditHealthPl";
            this.btnEditHealthPl.Size = new System.Drawing.Size(334, 33);
            this.btnEditHealthPl.TabIndex = 18;
            this.btnEditHealthPl.Text = "Edit Health";
            this.btnEditHealthPl.UseVisualStyleBackColor = true;
            // 
            // btnPlayerInfo
            // 
            this.btnPlayerInfo.Location = new System.Drawing.Point(8, 177);
            this.btnPlayerInfo.Name = "btnPlayerInfo";
            this.btnPlayerInfo.Size = new System.Drawing.Size(334, 34);
            this.btnPlayerInfo.TabIndex = 17;
            this.btnPlayerInfo.Text = "Open Unit Info";
            this.btnPlayerInfo.UseVisualStyleBackColor = true;
            // 
            // lstPlayers
            // 
            this.lstPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 14;
            this.lstPlayers.Location = new System.Drawing.Point(8, 33);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.ScrollAlwaysVisible = true;
            this.lstPlayers.Size = new System.Drawing.Size(334, 102);
            this.lstPlayers.Sorted = true;
            this.lstPlayers.TabIndex = 15;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblPlayers.Location = new System.Drawing.Point(101, 5);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(157, 25);
            this.lblPlayers.TabIndex = 16;
            this.lblPlayers.Text = "Current Players:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 481);
            this.ControlBox = false;
            this.Controls.Add(this.scMainContainer);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.msMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(699, 519);
            this.MinimumSize = new System.Drawing.Size(699, 519);
            this.Name = "MainForm";
            this.Text = "DnD Encounter Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.scMainContainer.Panel1.ResumeLayout(false);
            this.scMainContainer.Panel1.PerformLayout();
            this.scMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).EndInit();
            this.scMainContainer.ResumeLayout(false);
            this.gbSpells.ResumeLayout(false);
            this.gbSpells.PerformLayout();
            this.gbAttacks.ResumeLayout(false);
            this.gbAttacks.PerformLayout();
            this.scTurnsPlayers.Panel1.ResumeLayout(false);
            this.scTurnsPlayers.Panel1.PerformLayout();
            this.scTurnsPlayers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTurnsPlayers)).EndInit();
            this.scTurnsPlayers.ResumeLayout(false);
            this.tcUnitTabs.ResumeLayout(false);
            this.tpEnemies.ResumeLayout(false);
            this.tpEnemies.PerformLayout();
            this.tpPlayers.ResumeLayout(false);
            this.tpPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsiNewUnit;
        private System.Windows.Forms.ToolStripMenuItem enemyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiLoadEncounter;
        private System.Windows.Forms.ToolStripMenuItem tsiImportUnit;
        private System.Windows.Forms.ToolStripTextBox tstDivider1;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.ToolStripMenuItem tsiPreferences;
        private System.Windows.Forms.ToolStripTextBox tstDivider2;
        private System.Windows.Forms.SplitContainer scMainContainer;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnCurUnitInfo;
        private System.Windows.Forms.Button btnTakeTurn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbSpells;
        private System.Windows.Forms.Label lblSpDamage;
        private System.Windows.Forms.ComboBox cbSpSelector;
        private System.Windows.Forms.GroupBox gbAttacks;
        private System.Windows.Forms.Label lblAtkDamage;
        private System.Windows.Forms.ComboBox cbAtkSelector;
        private System.Windows.Forms.ComboBox cbTargSelector;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.RichTextBox rtbSpDescription;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ToolStripMenuItem saveEncounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer scTurnsPlayers;
        private System.Windows.Forms.Button btnEditInit;
        private System.Windows.Forms.Label lblTurnOrder;
        private System.Windows.Forms.ListBox lstTurnOrder;
        private System.Windows.Forms.TabControl tcUnitTabs;
        private System.Windows.Forms.TabPage tpEnemies;
        private System.Windows.Forms.Button btnEditHealthEn;
        private System.Windows.Forms.Button btnEnemyInfo;
        private System.Windows.Forms.ListBox lstEnemies;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.TabPage tpPlayers;
        private System.Windows.Forms.Button btnEditHealthPl;
        private System.Windows.Forms.Button btnPlayerInfo;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.ToolStripMenuItem rollDiceToolStripMenuItem;
    }
}