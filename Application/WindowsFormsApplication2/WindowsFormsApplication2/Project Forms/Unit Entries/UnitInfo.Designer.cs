namespace WindowsFormsApplication2
{
    partial class UnitInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitInfo));
            this.lblDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbAtk = new System.Windows.Forms.GroupBox();
            this.lblAtkMod = new System.Windows.Forms.Label();
            this.lblAtkType = new System.Windows.Forms.Label();
            this.lblAtkDamage = new System.Windows.Forms.Label();
            this.lstAtk = new System.Windows.Forms.ListBox();
            this.gbSp = new System.Windows.Forms.GroupBox();
            this.lblSpSlot = new System.Windows.Forms.Label();
            this.rtbSpDesc = new System.Windows.Forms.RichTextBox();
            this.lblSpDesc = new System.Windows.Forms.Label();
            this.lblSpType = new System.Windows.Forms.Label();
            this.lblSpDamage = new System.Windows.Forms.Label();
            this.lstSp = new System.Windows.Forms.ListBox();
            this.gbAttr = new System.Windows.Forms.GroupBox();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.gbDesc = new System.Windows.Forms.GroupBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.gbAtk.SuspendLayout();
            this.gbSp.SuspendLayout();
            this.gbAttr.SuspendLayout();
            this.gbDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.lblDetails.Location = new System.Drawing.Point(237, 9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(158, 31);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Unit Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Attacks: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.lblName.Location = new System.Drawing.Point(15, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 21);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Unit Name: ";
            // 
            // gbAtk
            // 
            this.gbAtk.Controls.Add(this.lblAtkMod);
            this.gbAtk.Controls.Add(this.lblAtkType);
            this.gbAtk.Controls.Add(this.lblAtkDamage);
            this.gbAtk.Controls.Add(this.lstAtk);
            this.gbAtk.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.gbAtk.Location = new System.Drawing.Point(16, 170);
            this.gbAtk.Name = "gbAtk";
            this.gbAtk.Size = new System.Drawing.Size(369, 116);
            this.gbAtk.TabIndex = 68;
            this.gbAtk.TabStop = false;
            this.gbAtk.Text = "Attacks";
            // 
            // lblAtkMod
            // 
            this.lblAtkMod.AutoSize = true;
            this.lblAtkMod.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkMod.Location = new System.Drawing.Point(190, 86);
            this.lblAtkMod.Name = "lblAtkMod";
            this.lblAtkMod.Size = new System.Drawing.Size(65, 16);
            this.lblAtkMod.TabIndex = 67;
            this.lblAtkMod.Text = "Modifier: ";
            // 
            // lblAtkType
            // 
            this.lblAtkType.AutoSize = true;
            this.lblAtkType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkType.Location = new System.Drawing.Point(190, 57);
            this.lblAtkType.Name = "lblAtkType";
            this.lblAtkType.Size = new System.Drawing.Size(43, 16);
            this.lblAtkType.TabIndex = 66;
            this.lblAtkType.Text = "Type: ";
            // 
            // lblAtkDamage
            // 
            this.lblAtkDamage.AutoSize = true;
            this.lblAtkDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblAtkDamage.Location = new System.Drawing.Point(190, 30);
            this.lblAtkDamage.Name = "lblAtkDamage";
            this.lblAtkDamage.Size = new System.Drawing.Size(64, 16);
            this.lblAtkDamage.TabIndex = 65;
            this.lblAtkDamage.Text = "Damage: ";
            // 
            // lstAtk
            // 
            this.lstAtk.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lstAtk.FormattingEnabled = true;
            this.lstAtk.ItemHeight = 17;
            this.lstAtk.Location = new System.Drawing.Point(8, 30);
            this.lstAtk.Name = "lstAtk";
            this.lstAtk.ScrollAlwaysVisible = true;
            this.lstAtk.Size = new System.Drawing.Size(176, 72);
            this.lstAtk.TabIndex = 64;
            this.lstAtk.SelectedIndexChanged += new System.EventHandler(this.lstAtk_SelectedIndexChanged);
            // 
            // gbSp
            // 
            this.gbSp.Controls.Add(this.lblSpSlot);
            this.gbSp.Controls.Add(this.rtbSpDesc);
            this.gbSp.Controls.Add(this.lblSpDesc);
            this.gbSp.Controls.Add(this.lblSpType);
            this.gbSp.Controls.Add(this.lblSpDamage);
            this.gbSp.Controls.Add(this.lstSp);
            this.gbSp.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.gbSp.Location = new System.Drawing.Point(19, 307);
            this.gbSp.Name = "gbSp";
            this.gbSp.Size = new System.Drawing.Size(613, 153);
            this.gbSp.TabIndex = 69;
            this.gbSp.TabStop = false;
            this.gbSp.Text = "Spells";
            // 
            // lblSpSlot
            // 
            this.lblSpSlot.AutoSize = true;
            this.lblSpSlot.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpSlot.Location = new System.Drawing.Point(192, 120);
            this.lblSpSlot.Name = "lblSpSlot";
            this.lblSpSlot.Size = new System.Drawing.Size(33, 16);
            this.lblSpSlot.TabIndex = 71;
            this.lblSpSlot.Text = "Slot:";
            // 
            // rtbSpDesc
            // 
            this.rtbSpDesc.Enabled = false;
            this.rtbSpDesc.Location = new System.Drawing.Point(340, 49);
            this.rtbSpDesc.Name = "rtbSpDesc";
            this.rtbSpDesc.Size = new System.Drawing.Size(267, 87);
            this.rtbSpDesc.TabIndex = 70;
            this.rtbSpDesc.Text = "";
            // 
            // lblSpDesc
            // 
            this.lblSpDesc.AutoSize = true;
            this.lblSpDesc.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpDesc.Location = new System.Drawing.Point(347, 30);
            this.lblSpDesc.Name = "lblSpDesc";
            this.lblSpDesc.Size = new System.Drawing.Size(81, 16);
            this.lblSpDesc.TabIndex = 67;
            this.lblSpDesc.Text = "Description: ";
            // 
            // lblSpType
            // 
            this.lblSpType.AutoSize = true;
            this.lblSpType.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpType.Location = new System.Drawing.Point(192, 73);
            this.lblSpType.Name = "lblSpType";
            this.lblSpType.Size = new System.Drawing.Size(43, 16);
            this.lblSpType.TabIndex = 66;
            this.lblSpType.Text = "Type: ";
            // 
            // lblSpDamage
            // 
            this.lblSpDamage.AutoSize = true;
            this.lblSpDamage.Font = new System.Drawing.Font("Gadugi", 9.25F);
            this.lblSpDamage.Location = new System.Drawing.Point(190, 30);
            this.lblSpDamage.Name = "lblSpDamage";
            this.lblSpDamage.Size = new System.Drawing.Size(64, 16);
            this.lblSpDamage.TabIndex = 65;
            this.lblSpDamage.Text = "Damage: ";
            // 
            // lstSp
            // 
            this.lstSp.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lstSp.FormattingEnabled = true;
            this.lstSp.ItemHeight = 17;
            this.lstSp.Location = new System.Drawing.Point(8, 30);
            this.lstSp.Name = "lstSp";
            this.lstSp.ScrollAlwaysVisible = true;
            this.lstSp.Size = new System.Drawing.Size(176, 106);
            this.lstSp.TabIndex = 64;
            this.lstSp.SelectedIndexChanged += new System.EventHandler(this.lstSp_SelectedIndexChanged);
            // 
            // gbAttr
            // 
            this.gbAttr.Controls.Add(this.lblCha);
            this.gbAttr.Controls.Add(this.lblInt);
            this.gbAttr.Controls.Add(this.lblWis);
            this.gbAttr.Controls.Add(this.lblCon);
            this.gbAttr.Controls.Add(this.lblDex);
            this.gbAttr.Controls.Add(this.lblStr);
            this.gbAttr.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.gbAttr.Location = new System.Drawing.Point(13, 76);
            this.gbAttr.Name = "gbAttr";
            this.gbAttr.Size = new System.Drawing.Size(372, 88);
            this.gbAttr.TabIndex = 70;
            this.gbAttr.TabStop = false;
            this.gbAttr.Text = "Attributes";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblCha.Location = new System.Drawing.Point(133, 61);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(72, 17);
            this.lblCha.TabIndex = 67;
            this.lblCha.Text = "Charisma: ";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblInt.Location = new System.Drawing.Point(6, 60);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(84, 17);
            this.lblInt.TabIndex = 66;
            this.lblInt.Text = "Intelligence: ";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblWis.Location = new System.Drawing.Point(263, 62);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(65, 17);
            this.lblWis.TabIndex = 65;
            this.lblWis.Text = "Wisdom: ";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblCon.Location = new System.Drawing.Point(251, 27);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(91, 17);
            this.lblCon.TabIndex = 64;
            this.lblCon.Text = "Constitution: ";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblDex.Location = new System.Drawing.Point(133, 26);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(70, 17);
            this.lblDex.TabIndex = 63;
            this.lblDex.Text = "Dexterity: ";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblStr.Location = new System.Drawing.Point(11, 27);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(68, 17);
            this.lblStr.TabIndex = 62;
            this.lblStr.Text = "Strength: ";
            // 
            // gbDesc
            // 
            this.gbDesc.Controls.Add(this.rtbDesc);
            this.gbDesc.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.gbDesc.Location = new System.Drawing.Point(392, 46);
            this.gbDesc.Name = "gbDesc";
            this.gbDesc.Size = new System.Drawing.Size(240, 240);
            this.gbDesc.TabIndex = 71;
            this.gbDesc.TabStop = false;
            this.gbDesc.Text = "Description/Further Details";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Enabled = false;
            this.rtbDesc.Location = new System.Drawing.Point(6, 30);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(228, 204);
            this.rtbDesc.TabIndex = 67;
            this.rtbDesc.Text = "";
            // 
            // UnitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 474);
            this.Controls.Add(this.gbDesc);
            this.Controls.Add(this.gbAttr);
            this.Controls.Add(this.gbSp);
            this.Controls.Add(this.gbAtk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitInfo";
            this.Text = "UnitInfo";
            this.Load += new System.EventHandler(this.UnitInfo_Load);
            this.gbAtk.ResumeLayout(false);
            this.gbAtk.PerformLayout();
            this.gbSp.ResumeLayout(false);
            this.gbSp.PerformLayout();
            this.gbAttr.ResumeLayout(false);
            this.gbAttr.PerformLayout();
            this.gbDesc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbAtk;
        private System.Windows.Forms.Label lblAtkType;
        private System.Windows.Forms.Label lblAtkDamage;
        private System.Windows.Forms.ListBox lstAtk;
        private System.Windows.Forms.GroupBox gbSp;
        private System.Windows.Forms.RichTextBox rtbSpDesc;
        private System.Windows.Forms.Label lblSpDesc;
        private System.Windows.Forms.Label lblSpType;
        private System.Windows.Forms.Label lblSpDamage;
        private System.Windows.Forms.ListBox lstSp;
        private System.Windows.Forms.GroupBox gbAttr;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.GroupBox gbDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblAtkMod;
        private System.Windows.Forms.Label lblSpSlot;
    }
}