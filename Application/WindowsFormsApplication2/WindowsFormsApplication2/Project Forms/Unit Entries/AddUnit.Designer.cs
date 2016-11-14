namespace WindowsFormsApplication2
{
    partial class AddUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUnit));
            this.lblCreateNew = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            this.lstAtk = new System.Windows.Forms.ListBox();
            this.lstSp = new System.Windows.Forms.ListBox();
            this.lblSp = new System.Windows.Forms.Label();
            this.gbAtk = new System.Windows.Forms.GroupBox();
            this.cbAtkMod = new System.Windows.Forms.ComboBox();
            this.btnAtkAdd = new System.Windows.Forms.Button();
            this.lblAtkMod = new System.Windows.Forms.Label();
            this.cbAtkType = new System.Windows.Forms.ComboBox();
            this.cbAtkDamage = new System.Windows.Forms.ComboBox();
            this.nudAtkDamage = new System.Windows.Forms.NumericUpDown();
            this.lblAtkD = new System.Windows.Forms.Label();
            this.txtAtkName = new System.Windows.Forms.TextBox();
            this.lblAtkType = new System.Windows.Forms.Label();
            this.lblAtkName = new System.Windows.Forms.Label();
            this.lblAtkDamage = new System.Windows.Forms.Label();
            this.gbSp = new System.Windows.Forms.GroupBox();
            this.rtbSpDesc = new System.Windows.Forms.RichTextBox();
            this.lblSpDesc = new System.Windows.Forms.Label();
            this.btnSpAdd = new System.Windows.Forms.Button();
            this.nudSpSlot = new System.Windows.Forms.NumericUpDown();
            this.lblSpSlot = new System.Windows.Forms.Label();
            this.cbSpType = new System.Windows.Forms.ComboBox();
            this.cbSpDamage = new System.Windows.Forms.ComboBox();
            this.nudSpDamage = new System.Windows.Forms.NumericUpDown();
            this.lblSpD = new System.Windows.Forms.Label();
            this.txtSpName = new System.Windows.Forms.TextBox();
            this.lblSpType = new System.Windows.Forms.Label();
            this.lblSpName = new System.Windows.Forms.Label();
            this.lblSpDamage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAttr = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.nudStr = new System.Windows.Forms.NumericUpDown();
            this.nudDex = new System.Windows.Forms.NumericUpDown();
            this.lblDex = new System.Windows.Forms.Label();
            this.nudCon = new System.Windows.Forms.NumericUpDown();
            this.lblCon = new System.Windows.Forms.Label();
            this.nudWis = new System.Windows.Forms.NumericUpDown();
            this.lblWis = new System.Windows.Forms.Label();
            this.nudInt = new System.Windows.Forms.NumericUpDown();
            this.lblInt = new System.Windows.Forms.Label();
            this.nudCha = new System.Windows.Forms.NumericUpDown();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblUnitDesc = new System.Windows.Forms.Label();
            this.rtbUnitDesc = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveAtk = new System.Windows.Forms.Button();
            this.btnRemoveSp = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.nudHealth = new System.Windows.Forms.NumericUpDown();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblAC = new System.Windows.Forms.Label();
            this.nudAC = new System.Windows.Forms.NumericUpDown();
            this.gbAtk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtkDamage)).BeginInit();
            this.gbSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateNew
            // 
            this.lblCreateNew.AutoSize = true;
            this.lblCreateNew.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.lblCreateNew.Location = new System.Drawing.Point(263, 6);
            this.lblCreateNew.Name = "lblCreateNew";
            this.lblCreateNew.Size = new System.Drawing.Size(243, 31);
            this.lblCreateNew.TabIndex = 18;
            this.lblCreateNew.Text = "Create a New Unit: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 21);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Unit Name: ";
            // 
            // lblAtk
            // 
            this.lblAtk.AutoSize = true;
            this.lblAtk.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblAtk.Location = new System.Drawing.Point(12, 146);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(77, 21);
            this.lblAtk.TabIndex = 20;
            this.lblAtk.Text = "Attacks: ";
            // 
            // lstAtk
            // 
            this.lstAtk.FormattingEnabled = true;
            this.lstAtk.Location = new System.Drawing.Point(82, 149);
            this.lstAtk.Name = "lstAtk";
            this.lstAtk.ScrollAlwaysVisible = true;
            this.lstAtk.Size = new System.Drawing.Size(222, 69);
            this.lstAtk.TabIndex = 21;
            // 
            // lstSp
            // 
            this.lstSp.FormattingEnabled = true;
            this.lstSp.Location = new System.Drawing.Point(82, 271);
            this.lstSp.Name = "lstSp";
            this.lstSp.ScrollAlwaysVisible = true;
            this.lstSp.Size = new System.Drawing.Size(222, 147);
            this.lstSp.TabIndex = 23;
            // 
            // lblSp
            // 
            this.lblSp.AutoSize = true;
            this.lblSp.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblSp.Location = new System.Drawing.Point(12, 268);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(65, 21);
            this.lblSp.TabIndex = 22;
            this.lblSp.Text = "Spells: ";
            // 
            // gbAtk
            // 
            this.gbAtk.Controls.Add(this.cbAtkMod);
            this.gbAtk.Controls.Add(this.btnAtkAdd);
            this.gbAtk.Controls.Add(this.lblAtkMod);
            this.gbAtk.Controls.Add(this.cbAtkType);
            this.gbAtk.Controls.Add(this.cbAtkDamage);
            this.gbAtk.Controls.Add(this.nudAtkDamage);
            this.gbAtk.Controls.Add(this.lblAtkD);
            this.gbAtk.Controls.Add(this.txtAtkName);
            this.gbAtk.Controls.Add(this.lblAtkType);
            this.gbAtk.Controls.Add(this.lblAtkName);
            this.gbAtk.Controls.Add(this.lblAtkDamage);
            this.gbAtk.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.gbAtk.Location = new System.Drawing.Point(310, 144);
            this.gbAtk.Name = "gbAtk";
            this.gbAtk.Size = new System.Drawing.Size(451, 113);
            this.gbAtk.TabIndex = 24;
            this.gbAtk.TabStop = false;
            this.gbAtk.Text = "Add New Attack";
            // 
            // cbAtkMod
            // 
            this.cbAtkMod.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.cbAtkMod.FormattingEnabled = true;
            this.cbAtkMod.Items.AddRange(new object[] {
            "Strength",
            "Dexterity"});
            this.cbAtkMod.Location = new System.Drawing.Point(364, 47);
            this.cbAtkMod.Name = "cbAtkMod";
            this.cbAtkMod.Size = new System.Drawing.Size(67, 24);
            this.cbAtkMod.TabIndex = 49;
            this.cbAtkMod.Text = "Strength";
            // 
            // btnAtkAdd
            // 
            this.btnAtkAdd.Location = new System.Drawing.Point(7, 75);
            this.btnAtkAdd.Name = "btnAtkAdd";
            this.btnAtkAdd.Size = new System.Drawing.Size(438, 27);
            this.btnAtkAdd.TabIndex = 34;
            this.btnAtkAdd.Text = "Add";
            this.btnAtkAdd.UseVisualStyleBackColor = true;
            this.btnAtkAdd.Click += new System.EventHandler(this.btnAtkAdd_Click);
            // 
            // lblAtkMod
            // 
            this.lblAtkMod.AutoSize = true;
            this.lblAtkMod.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkMod.Location = new System.Drawing.Point(323, 50);
            this.lblAtkMod.Name = "lblAtkMod";
            this.lblAtkMod.Size = new System.Drawing.Size(43, 16);
            this.lblAtkMod.TabIndex = 48;
            this.lblAtkMod.Text = "Mod: ";
            // 
            // cbAtkType
            // 
            this.cbAtkType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.cbAtkType.FormattingEnabled = true;
            this.cbAtkType.Items.AddRange(new object[] {
            "Slashing",
            "Piercing",
            "Bludgeoning"});
            this.cbAtkType.Location = new System.Drawing.Point(221, 47);
            this.cbAtkType.Name = "cbAtkType";
            this.cbAtkType.Size = new System.Drawing.Size(94, 24);
            this.cbAtkType.TabIndex = 33;
            this.cbAtkType.Text = "Slashing";
            // 
            // cbAtkDamage
            // 
            this.cbAtkDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.cbAtkDamage.FormattingEnabled = true;
            this.cbAtkDamage.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "20",
            "100"});
            this.cbAtkDamage.Location = new System.Drawing.Point(125, 47);
            this.cbAtkDamage.Name = "cbAtkDamage";
            this.cbAtkDamage.Size = new System.Drawing.Size(52, 24);
            this.cbAtkDamage.TabIndex = 32;
            this.cbAtkDamage.Text = "4";
            // 
            // nudAtkDamage
            // 
            this.nudAtkDamage.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudAtkDamage.Location = new System.Drawing.Point(65, 49);
            this.nudAtkDamage.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudAtkDamage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAtkDamage.Name = "nudAtkDamage";
            this.nudAtkDamage.Size = new System.Drawing.Size(34, 20);
            this.nudAtkDamage.TabIndex = 31;
            this.nudAtkDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAtkD
            // 
            this.lblAtkD.AutoSize = true;
            this.lblAtkD.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkD.Location = new System.Drawing.Point(104, 50);
            this.lblAtkD.Name = "lblAtkD";
            this.lblAtkD.Size = new System.Drawing.Size(16, 16);
            this.lblAtkD.TabIndex = 30;
            this.lblAtkD.Text = "d";
            // 
            // txtAtkName
            // 
            this.txtAtkName.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.txtAtkName.Location = new System.Drawing.Point(53, 20);
            this.txtAtkName.MaxLength = 50;
            this.txtAtkName.Name = "txtAtkName";
            this.txtAtkName.Size = new System.Drawing.Size(392, 24);
            this.txtAtkName.TabIndex = 29;
            // 
            // lblAtkType
            // 
            this.lblAtkType.AutoSize = true;
            this.lblAtkType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkType.Location = new System.Drawing.Point(179, 50);
            this.lblAtkType.Name = "lblAtkType";
            this.lblAtkType.Size = new System.Drawing.Size(43, 16);
            this.lblAtkType.TabIndex = 28;
            this.lblAtkType.Text = "Type: ";
            // 
            // lblAtkName
            // 
            this.lblAtkName.AutoSize = true;
            this.lblAtkName.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkName.Location = new System.Drawing.Point(6, 23);
            this.lblAtkName.Name = "lblAtkName";
            this.lblAtkName.Size = new System.Drawing.Size(50, 16);
            this.lblAtkName.TabIndex = 27;
            this.lblAtkName.Text = "Name: ";
            // 
            // lblAtkDamage
            // 
            this.lblAtkDamage.AutoSize = true;
            this.lblAtkDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkDamage.Location = new System.Drawing.Point(6, 49);
            this.lblAtkDamage.Name = "lblAtkDamage";
            this.lblAtkDamage.Size = new System.Drawing.Size(64, 16);
            this.lblAtkDamage.TabIndex = 26;
            this.lblAtkDamage.Text = "Damage: ";
            // 
            // gbSp
            // 
            this.gbSp.Controls.Add(this.rtbSpDesc);
            this.gbSp.Controls.Add(this.lblSpDesc);
            this.gbSp.Controls.Add(this.btnSpAdd);
            this.gbSp.Controls.Add(this.nudSpSlot);
            this.gbSp.Controls.Add(this.lblSpSlot);
            this.gbSp.Controls.Add(this.cbSpType);
            this.gbSp.Controls.Add(this.cbSpDamage);
            this.gbSp.Controls.Add(this.nudSpDamage);
            this.gbSp.Controls.Add(this.lblSpD);
            this.gbSp.Controls.Add(this.txtSpName);
            this.gbSp.Controls.Add(this.lblSpType);
            this.gbSp.Controls.Add(this.lblSpName);
            this.gbSp.Controls.Add(this.lblSpDamage);
            this.gbSp.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.gbSp.Location = new System.Drawing.Point(310, 268);
            this.gbSp.Name = "gbSp";
            this.gbSp.Size = new System.Drawing.Size(451, 192);
            this.gbSp.TabIndex = 25;
            this.gbSp.TabStop = false;
            this.gbSp.Text = "Add New Spell";
            // 
            // rtbSpDesc
            // 
            this.rtbSpDesc.Location = new System.Drawing.Point(9, 101);
            this.rtbSpDesc.MaxLength = 5000;
            this.rtbSpDesc.Name = "rtbSpDesc";
            this.rtbSpDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSpDesc.Size = new System.Drawing.Size(436, 52);
            this.rtbSpDesc.TabIndex = 45;
            this.rtbSpDesc.Text = "";
            // 
            // lblSpDesc
            // 
            this.lblSpDesc.AutoSize = true;
            this.lblSpDesc.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpDesc.Location = new System.Drawing.Point(196, 82);
            this.lblSpDesc.Name = "lblSpDesc";
            this.lblSpDesc.Size = new System.Drawing.Size(77, 16);
            this.lblSpDesc.TabIndex = 44;
            this.lblSpDesc.Text = "Description:";
            // 
            // btnSpAdd
            // 
            this.btnSpAdd.Location = new System.Drawing.Point(7, 159);
            this.btnSpAdd.Name = "btnSpAdd";
            this.btnSpAdd.Size = new System.Drawing.Size(438, 27);
            this.btnSpAdd.TabIndex = 35;
            this.btnSpAdd.Text = "Add";
            this.btnSpAdd.UseVisualStyleBackColor = true;
            this.btnSpAdd.Click += new System.EventHandler(this.btnSpAdd_Click);
            // 
            // nudSpSlot
            // 
            this.nudSpSlot.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudSpSlot.Location = new System.Drawing.Point(78, 75);
            this.nudSpSlot.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSpSlot.Name = "nudSpSlot";
            this.nudSpSlot.Size = new System.Drawing.Size(34, 20);
            this.nudSpSlot.TabIndex = 43;
            // 
            // lblSpSlot
            // 
            this.lblSpSlot.AutoSize = true;
            this.lblSpSlot.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpSlot.Location = new System.Drawing.Point(6, 76);
            this.lblSpSlot.Name = "lblSpSlot";
            this.lblSpSlot.Size = new System.Drawing.Size(66, 16);
            this.lblSpSlot.TabIndex = 42;
            this.lblSpSlot.Text = "Slot Level:";
            // 
            // cbSpType
            // 
            this.cbSpType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.cbSpType.FormattingEnabled = true;
            this.cbSpType.Items.AddRange(new object[] {
            "(None)",
            "Acid",
            "Cold",
            "Fire",
            "Lightning",
            "Necrotic",
            "Poison",
            "Psychic",
            "Radiant"});
            this.cbSpType.Location = new System.Drawing.Point(272, 47);
            this.cbSpType.Name = "cbSpType";
            this.cbSpType.Size = new System.Drawing.Size(94, 24);
            this.cbSpType.TabIndex = 41;
            this.cbSpType.Text = "(None)";
            // 
            // cbSpDamage
            // 
            this.cbSpDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.cbSpDamage.FormattingEnabled = true;
            this.cbSpDamage.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "20",
            "100"});
            this.cbSpDamage.Location = new System.Drawing.Point(125, 48);
            this.cbSpDamage.Name = "cbSpDamage";
            this.cbSpDamage.Size = new System.Drawing.Size(52, 24);
            this.cbSpDamage.TabIndex = 40;
            this.cbSpDamage.Text = "4";
            // 
            // nudSpDamage
            // 
            this.nudSpDamage.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudSpDamage.Location = new System.Drawing.Point(65, 50);
            this.nudSpDamage.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSpDamage.Name = "nudSpDamage";
            this.nudSpDamage.Size = new System.Drawing.Size(34, 20);
            this.nudSpDamage.TabIndex = 39;
            // 
            // lblSpD
            // 
            this.lblSpD.AutoSize = true;
            this.lblSpD.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpD.Location = new System.Drawing.Point(104, 51);
            this.lblSpD.Name = "lblSpD";
            this.lblSpD.Size = new System.Drawing.Size(16, 16);
            this.lblSpD.TabIndex = 38;
            this.lblSpD.Text = "d";
            // 
            // txtSpName
            // 
            this.txtSpName.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.txtSpName.Location = new System.Drawing.Point(53, 21);
            this.txtSpName.MaxLength = 50;
            this.txtSpName.Name = "txtSpName";
            this.txtSpName.Size = new System.Drawing.Size(392, 24);
            this.txtSpName.TabIndex = 37;
            // 
            // lblSpType
            // 
            this.lblSpType.AutoSize = true;
            this.lblSpType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpType.Location = new System.Drawing.Point(229, 50);
            this.lblSpType.Name = "lblSpType";
            this.lblSpType.Size = new System.Drawing.Size(43, 16);
            this.lblSpType.TabIndex = 36;
            this.lblSpType.Text = "Type: ";
            // 
            // lblSpName
            // 
            this.lblSpName.AutoSize = true;
            this.lblSpName.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpName.Location = new System.Drawing.Point(6, 24);
            this.lblSpName.Name = "lblSpName";
            this.lblSpName.Size = new System.Drawing.Size(50, 16);
            this.lblSpName.TabIndex = 35;
            this.lblSpName.Text = "Name: ";
            // 
            // lblSpDamage
            // 
            this.lblSpDamage.AutoSize = true;
            this.lblSpDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpDamage.Location = new System.Drawing.Point(6, 50);
            this.lblSpDamage.Name = "lblSpDamage";
            this.lblSpDamage.Size = new System.Drawing.Size(64, 16);
            this.lblSpDamage.TabIndex = 34;
            this.lblSpDamage.Text = "Damage: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.txtName.Location = new System.Drawing.Point(121, 40);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 24);
            this.txtName.TabIndex = 35;
            // 
            // lblAttr
            // 
            this.lblAttr.AutoSize = true;
            this.lblAttr.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblAttr.Location = new System.Drawing.Point(12, 76);
            this.lblAttr.Name = "lblAttr";
            this.lblAttr.Size = new System.Drawing.Size(97, 21);
            this.lblAttr.TabIndex = 36;
            this.lblAttr.Text = "Attributes: ";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblStr.Location = new System.Drawing.Point(266, 80);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(68, 17);
            this.lblStr.TabIndex = 37;
            this.lblStr.Text = "Strength: ";
            // 
            // nudStr
            // 
            this.nudStr.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudStr.Location = new System.Drawing.Point(342, 80);
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(34, 20);
            this.nudStr.TabIndex = 35;
            // 
            // nudDex
            // 
            this.nudDex.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudDex.Location = new System.Drawing.Point(462, 80);
            this.nudDex.Name = "nudDex";
            this.nudDex.Size = new System.Drawing.Size(34, 20);
            this.nudDex.TabIndex = 38;
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblDex.Location = new System.Drawing.Point(388, 79);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(70, 17);
            this.lblDex.TabIndex = 39;
            this.lblDex.Text = "Dexterity: ";
            // 
            // nudCon
            // 
            this.nudCon.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudCon.Location = new System.Drawing.Point(599, 80);
            this.nudCon.Name = "nudCon";
            this.nudCon.Size = new System.Drawing.Size(34, 20);
            this.nudCon.TabIndex = 40;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblCon.Location = new System.Drawing.Point(506, 80);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(91, 17);
            this.lblCon.TabIndex = 41;
            this.lblCon.Text = "Constitution: ";
            // 
            // nudWis
            // 
            this.nudWis.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudWis.Location = new System.Drawing.Point(599, 115);
            this.nudWis.Name = "nudWis";
            this.nudWis.Size = new System.Drawing.Size(34, 20);
            this.nudWis.TabIndex = 42;
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblWis.Location = new System.Drawing.Point(518, 115);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(65, 17);
            this.lblWis.TabIndex = 43;
            this.lblWis.Text = "Wisdom: ";
            // 
            // nudInt
            // 
            this.nudInt.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudInt.Location = new System.Drawing.Point(342, 113);
            this.nudInt.Name = "nudInt";
            this.nudInt.Size = new System.Drawing.Size(34, 20);
            this.nudInt.TabIndex = 44;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblInt.Location = new System.Drawing.Point(261, 113);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(84, 17);
            this.lblInt.TabIndex = 45;
            this.lblInt.Text = "Intelligence: ";
            // 
            // nudCha
            // 
            this.nudCha.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudCha.Location = new System.Drawing.Point(462, 113);
            this.nudCha.Name = "nudCha";
            this.nudCha.Size = new System.Drawing.Size(34, 20);
            this.nudCha.TabIndex = 46;
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblCha.Location = new System.Drawing.Point(388, 114);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(72, 17);
            this.lblCha.TabIndex = 47;
            this.lblCha.Text = "Charisma: ";
            // 
            // lblUnitDesc
            // 
            this.lblUnitDesc.AutoSize = true;
            this.lblUnitDesc.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblUnitDesc.Location = new System.Drawing.Point(12, 473);
            this.lblUnitDesc.Name = "lblUnitDesc";
            this.lblUnitDesc.Size = new System.Drawing.Size(230, 21);
            this.lblUnitDesc.TabIndex = 48;
            this.lblUnitDesc.Text = "Description/Further Details: ";
            // 
            // rtbUnitDesc
            // 
            this.rtbUnitDesc.Location = new System.Drawing.Point(18, 497);
            this.rtbUnitDesc.MaxLength = 5000;
            this.rtbUnitDesc.Name = "rtbUnitDesc";
            this.rtbUnitDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbUnitDesc.Size = new System.Drawing.Size(743, 105);
            this.rtbUnitDesc.TabIndex = 46;
            this.rtbUnitDesc.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(210, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(551, 27);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 12.25F);
            this.btnClear.Location = new System.Drawing.Point(16, 608);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 27);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveAtk
            // 
            this.btnRemoveAtk.Location = new System.Drawing.Point(82, 225);
            this.btnRemoveAtk.Name = "btnRemoveAtk";
            this.btnRemoveAtk.Size = new System.Drawing.Size(222, 23);
            this.btnRemoveAtk.TabIndex = 50;
            this.btnRemoveAtk.Text = "Remove Selected";
            this.btnRemoveAtk.UseVisualStyleBackColor = true;
            this.btnRemoveAtk.Click += new System.EventHandler(this.btnRemoveAtk_Click);
            // 
            // btnRemoveSp
            // 
            this.btnRemoveSp.Location = new System.Drawing.Point(82, 431);
            this.btnRemoveSp.Name = "btnRemoveSp";
            this.btnRemoveSp.Size = new System.Drawing.Size(222, 23);
            this.btnRemoveSp.TabIndex = 51;
            this.btnRemoveSp.Text = "Remove Selected";
            this.btnRemoveSp.UseVisualStyleBackColor = true;
            this.btnRemoveSp.Click += new System.EventHandler(this.btnRemoveSp_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblHealth.Location = new System.Drawing.Point(108, 79);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(70, 21);
            this.lblHealth.TabIndex = 52;
            this.lblHealth.Text = "Health: ";
            // 
            // nudHealth
            // 
            this.nudHealth.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudHealth.Location = new System.Drawing.Point(183, 79);
            this.nudHealth.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHealth.Name = "nudHealth";
            this.nudHealth.Size = new System.Drawing.Size(66, 20);
            this.nudHealth.TabIndex = 53;
            this.nudHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudLevel.Location = new System.Drawing.Point(183, 114);
            this.nudLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(66, 20);
            this.nudLevel.TabIndex = 55;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblLevel.Location = new System.Drawing.Point(109, 113);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(53, 21);
            this.lblLevel.TabIndex = 54;
            this.lblLevel.Text = "Level:";
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblAC.Location = new System.Drawing.Point(664, 79);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(97, 17);
            this.lblAC.TabIndex = 56;
            this.lblAC.Text = "Armour Class: ";
            // 
            // nudAC
            // 
            this.nudAC.Font = new System.Drawing.Font("Gadugi", 7.25F);
            this.nudAC.Location = new System.Drawing.Point(667, 99);
            this.nudAC.Name = "nudAC";
            this.nudAC.Size = new System.Drawing.Size(88, 20);
            this.nudAC.TabIndex = 57;
            // 
            // AddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 640);
            this.ControlBox = false;
            this.Controls.Add(this.nudAC);
            this.Controls.Add(this.lblAC);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.nudHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnRemoveSp);
            this.Controls.Add(this.btnRemoveAtk);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbUnitDesc);
            this.Controls.Add(this.lblUnitDesc);
            this.Controls.Add(this.nudCha);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.nudInt);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.nudWis);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.nudCon);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.nudDex);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.nudStr);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblAttr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbSp);
            this.Controls.Add(this.gbAtk);
            this.Controls.Add(this.lstSp);
            this.Controls.Add(this.lblSp);
            this.Controls.Add(this.lstAtk);
            this.Controls.Add(this.lblAtk);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreateNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUnit";
            this.ShowIcon = false;
            this.Text = "Create New Unit";
            this.Load += new System.EventHandler(this.AddUnit_Load);
            this.gbAtk.ResumeLayout(false);
            this.gbAtk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtkDamage)).EndInit();
            this.gbSp.ResumeLayout(false);
            this.gbSp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateNew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAtk;
        private System.Windows.Forms.ListBox lstAtk;
        private System.Windows.Forms.ListBox lstSp;
        private System.Windows.Forms.Label lblSp;
        private System.Windows.Forms.GroupBox gbAtk;
        private System.Windows.Forms.Button btnAtkAdd;
        private System.Windows.Forms.ComboBox cbAtkType;
        private System.Windows.Forms.ComboBox cbAtkDamage;
        private System.Windows.Forms.NumericUpDown nudAtkDamage;
        private System.Windows.Forms.Label lblAtkD;
        private System.Windows.Forms.TextBox txtAtkName;
        private System.Windows.Forms.Label lblAtkType;
        private System.Windows.Forms.Label lblAtkName;
        private System.Windows.Forms.Label lblAtkDamage;
        private System.Windows.Forms.GroupBox gbSp;
        private System.Windows.Forms.ComboBox cbSpType;
        private System.Windows.Forms.ComboBox cbSpDamage;
        private System.Windows.Forms.NumericUpDown nudSpDamage;
        private System.Windows.Forms.Label lblSpD;
        private System.Windows.Forms.TextBox txtSpName;
        private System.Windows.Forms.Label lblSpType;
        private System.Windows.Forms.Label lblSpName;
        private System.Windows.Forms.Label lblSpDamage;
        private System.Windows.Forms.NumericUpDown nudSpSlot;
        private System.Windows.Forms.Label lblSpSlot;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtbSpDesc;
        private System.Windows.Forms.Label lblSpDesc;
        private System.Windows.Forms.Button btnSpAdd;
        private System.Windows.Forms.Label lblAttr;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.NumericUpDown nudStr;
        private System.Windows.Forms.NumericUpDown nudDex;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.NumericUpDown nudCon;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.NumericUpDown nudWis;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.NumericUpDown nudInt;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.NumericUpDown nudCha;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblUnitDesc;
        private System.Windows.Forms.RichTextBox rtbUnitDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveAtk;
        private System.Windows.Forms.Button btnRemoveSp;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.NumericUpDown nudHealth;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cbAtkMod;
        private System.Windows.Forms.Label lblAtkMod;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.NumericUpDown nudAC;
    }
}