namespace WindowsFormsApplication2
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPrefs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAttackAlerts = new System.Windows.Forms.GroupBox();
            this.rbNoAtkSp = new System.Windows.Forms.RadioButton();
            this.rbYesAtkSp = new System.Windows.Forms.RadioButton();
            this.gbChangePass = new System.Windows.Forms.GroupBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtPrevPass = new System.Windows.Forms.TextBox();
            this.lblNewPass2 = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblPrevPass = new System.Windows.Forms.Label();
            this.gbAutoRoll = new System.Windows.Forms.GroupBox();
            this.rbNoAuto = new System.Windows.Forms.RadioButton();
            this.rbYesAuto = new System.Windows.Forms.RadioButton();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.rbNoHelp = new System.Windows.Forms.RadioButton();
            this.rbYesHelp = new System.Windows.Forms.RadioButton();
            this.tltHelp = new System.Windows.Forms.ToolTip(this.components);
            this.gbAttackAlerts.SuspendLayout();
            this.gbChangePass.SuspendLayout();
            this.gbAutoRoll.SuspendLayout();
            this.gbHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.btnSave.Location = new System.Drawing.Point(12, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(332, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPrefs
            // 
            this.lblPrefs.AutoSize = true;
            this.lblPrefs.Font = new System.Drawing.Font("Gadugi", 20.25F);
            this.lblPrefs.Location = new System.Drawing.Point(99, 6);
            this.lblPrefs.Name = "lblPrefs";
            this.lblPrefs.Size = new System.Drawing.Size(155, 31);
            this.lblPrefs.TabIndex = 18;
            this.lblPrefs.Text = "Preferences:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // gbAttackAlerts
            // 
            this.gbAttackAlerts.Controls.Add(this.rbNoAtkSp);
            this.gbAttackAlerts.Controls.Add(this.rbYesAtkSp);
            this.gbAttackAlerts.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbAttackAlerts.Location = new System.Drawing.Point(13, 40);
            this.gbAttackAlerts.Name = "gbAttackAlerts";
            this.gbAttackAlerts.Size = new System.Drawing.Size(332, 56);
            this.gbAttackAlerts.TabIndex = 21;
            this.gbAttackAlerts.TabStop = false;
            this.gbAttackAlerts.Text = "Display Message Box on Attacks and Spells?";
            this.tltHelp.SetToolTip(this.gbAttackAlerts, "This will report whether the attack/spell hits, and the damage it does.");
            // 
            // rbNoAtkSp
            // 
            this.rbNoAtkSp.AutoSize = true;
            this.rbNoAtkSp.Location = new System.Drawing.Point(84, 24);
            this.rbNoAtkSp.Name = "rbNoAtkSp";
            this.rbNoAtkSp.Size = new System.Drawing.Size(40, 18);
            this.rbNoAtkSp.TabIndex = 1;
            this.rbNoAtkSp.TabStop = true;
            this.rbNoAtkSp.Text = "No";
            this.rbNoAtkSp.UseVisualStyleBackColor = true;
            // 
            // rbYesAtkSp
            // 
            this.rbYesAtkSp.AutoSize = true;
            this.rbYesAtkSp.Location = new System.Drawing.Point(7, 24);
            this.rbYesAtkSp.Name = "rbYesAtkSp";
            this.rbYesAtkSp.Size = new System.Drawing.Size(41, 18);
            this.rbYesAtkSp.TabIndex = 0;
            this.rbYesAtkSp.TabStop = true;
            this.rbYesAtkSp.Text = "Yes";
            this.rbYesAtkSp.UseVisualStyleBackColor = true;
            // 
            // gbChangePass
            // 
            this.gbChangePass.Controls.Add(this.txtNewPass2);
            this.gbChangePass.Controls.Add(this.txtNewPass);
            this.gbChangePass.Controls.Add(this.txtPrevPass);
            this.gbChangePass.Controls.Add(this.lblNewPass2);
            this.gbChangePass.Controls.Add(this.lblNewPass);
            this.gbChangePass.Controls.Add(this.lblPrevPass);
            this.gbChangePass.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbChangePass.Location = new System.Drawing.Point(12, 226);
            this.gbChangePass.Name = "gbChangePass";
            this.gbChangePass.Size = new System.Drawing.Size(332, 128);
            this.gbChangePass.TabIndex = 22;
            this.gbChangePass.TabStop = false;
            this.gbChangePass.Text = "Change Password";
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(158, 85);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(150, 22);
            this.txtNewPass2.TabIndex = 23;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(158, 55);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(150, 22);
            this.txtNewPass.TabIndex = 22;
            // 
            // txtPrevPass
            // 
            this.txtPrevPass.Location = new System.Drawing.Point(158, 25);
            this.txtPrevPass.Name = "txtPrevPass";
            this.txtPrevPass.PasswordChar = '*';
            this.txtPrevPass.Size = new System.Drawing.Size(150, 22);
            this.txtPrevPass.TabIndex = 21;
            // 
            // lblNewPass2
            // 
            this.lblNewPass2.AutoSize = true;
            this.lblNewPass2.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblNewPass2.Location = new System.Drawing.Point(6, 88);
            this.lblNewPass2.Name = "lblNewPass2";
            this.lblNewPass2.Size = new System.Drawing.Size(153, 17);
            this.lblNewPass2.TabIndex = 20;
            this.lblNewPass2.Text = "Confirm New Password:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblNewPass.Location = new System.Drawing.Point(24, 56);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(100, 17);
            this.lblNewPass.TabIndex = 19;
            this.lblNewPass.Text = "New Password:";
            // 
            // lblPrevPass
            // 
            this.lblPrevPass.AutoSize = true;
            this.lblPrevPass.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblPrevPass.Location = new System.Drawing.Point(18, 26);
            this.lblPrevPass.Name = "lblPrevPass";
            this.lblPrevPass.Size = new System.Drawing.Size(125, 17);
            this.lblPrevPass.TabIndex = 18;
            this.lblPrevPass.Text = "Previous Password:";
            // 
            // gbAutoRoll
            // 
            this.gbAutoRoll.Controls.Add(this.rbNoAuto);
            this.gbAutoRoll.Controls.Add(this.rbYesAuto);
            this.gbAutoRoll.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbAutoRoll.Location = new System.Drawing.Point(12, 102);
            this.gbAutoRoll.Name = "gbAutoRoll";
            this.gbAutoRoll.Size = new System.Drawing.Size(332, 56);
            this.gbAutoRoll.TabIndex = 22;
            this.gbAutoRoll.TabStop = false;
            this.gbAutoRoll.Text = "Roll for Attack/Spell Damage Automatically?";
            this.tltHelp.SetToolTip(this.gbAutoRoll, "This is used for attack rolls, damage and initiative.");
            // 
            // rbNoAuto
            // 
            this.rbNoAuto.AutoSize = true;
            this.rbNoAuto.Location = new System.Drawing.Point(84, 24);
            this.rbNoAuto.Name = "rbNoAuto";
            this.rbNoAuto.Size = new System.Drawing.Size(40, 18);
            this.rbNoAuto.TabIndex = 1;
            this.rbNoAuto.TabStop = true;
            this.rbNoAuto.Text = "No";
            this.rbNoAuto.UseVisualStyleBackColor = true;
            // 
            // rbYesAuto
            // 
            this.rbYesAuto.AutoSize = true;
            this.rbYesAuto.Location = new System.Drawing.Point(7, 24);
            this.rbYesAuto.Name = "rbYesAuto";
            this.rbYesAuto.Size = new System.Drawing.Size(41, 18);
            this.rbYesAuto.TabIndex = 0;
            this.rbYesAuto.TabStop = true;
            this.rbYesAuto.Text = "Yes";
            this.rbYesAuto.UseVisualStyleBackColor = true;
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.rbNoHelp);
            this.gbHelp.Controls.Add(this.rbYesHelp);
            this.gbHelp.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbHelp.Location = new System.Drawing.Point(12, 164);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Size = new System.Drawing.Size(332, 56);
            this.gbHelp.TabIndex = 23;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Display Instructional Messages?";
            this.tltHelp.SetToolTip(this.gbHelp, "This will inform you what to do at each step in the program.");
            // 
            // rbNoHelp
            // 
            this.rbNoHelp.AutoSize = true;
            this.rbNoHelp.Location = new System.Drawing.Point(84, 24);
            this.rbNoHelp.Name = "rbNoHelp";
            this.rbNoHelp.Size = new System.Drawing.Size(40, 18);
            this.rbNoHelp.TabIndex = 1;
            this.rbNoHelp.TabStop = true;
            this.rbNoHelp.Text = "No";
            this.rbNoHelp.UseVisualStyleBackColor = true;
            // 
            // rbYesHelp
            // 
            this.rbYesHelp.AutoSize = true;
            this.rbYesHelp.Location = new System.Drawing.Point(7, 24);
            this.rbYesHelp.Name = "rbYesHelp";
            this.rbYesHelp.Size = new System.Drawing.Size(41, 18);
            this.rbYesHelp.TabIndex = 0;
            this.rbYesHelp.TabStop = true;
            this.rbYesHelp.Text = "Yes";
            this.rbYesHelp.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 423);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.gbAutoRoll);
            this.Controls.Add(this.gbChangePass);
            this.Controls.Add(this.gbAttackAlerts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPrefs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.gbAttackAlerts.ResumeLayout(false);
            this.gbAttackAlerts.PerformLayout();
            this.gbChangePass.ResumeLayout(false);
            this.gbChangePass.PerformLayout();
            this.gbAutoRoll.ResumeLayout(false);
            this.gbAutoRoll.PerformLayout();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrefs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAttackAlerts;
        private System.Windows.Forms.RadioButton rbNoAtkSp;
        private System.Windows.Forms.RadioButton rbYesAtkSp;
        private System.Windows.Forms.GroupBox gbChangePass;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtPrevPass;
        private System.Windows.Forms.Label lblNewPass2;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblPrevPass;
        private System.Windows.Forms.GroupBox gbAutoRoll;
        private System.Windows.Forms.RadioButton rbNoAuto;
        private System.Windows.Forms.RadioButton rbYesAuto;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.RadioButton rbNoHelp;
        private System.Windows.Forms.RadioButton rbYesHelp;
        private System.Windows.Forms.ToolTip tltHelp;
    }
}