namespace WindowsFormsApplication2.Project_Forms
{
    partial class RollDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollDice));
            this.nudDiceRollAmount = new System.Windows.Forms.NumericUpDown();
            this.lblDiceRolls = new System.Windows.Forms.Label();
            this.cbDiceSelector = new System.Windows.Forms.ComboBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lstDiceRolls = new System.Windows.Forms.ListBox();
            this.btnRoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiceRollAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiceRollAmount
            // 
            this.nudDiceRollAmount.Font = new System.Drawing.Font("Gadugi", 12.5F);
            this.nudDiceRollAmount.Location = new System.Drawing.Point(81, 46);
            this.nudDiceRollAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiceRollAmount.Name = "nudDiceRollAmount";
            this.nudDiceRollAmount.Size = new System.Drawing.Size(57, 30);
            this.nudDiceRollAmount.TabIndex = 23;
            this.nudDiceRollAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDiceRolls
            // 
            this.lblDiceRolls.AutoSize = true;
            this.lblDiceRolls.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblDiceRolls.Location = new System.Drawing.Point(104, 9);
            this.lblDiceRolls.Name = "lblDiceRolls";
            this.lblDiceRolls.Size = new System.Drawing.Size(108, 25);
            this.lblDiceRolls.TabIndex = 22;
            this.lblDiceRolls.Text = "Dice Rolls:";
            // 
            // cbDiceSelector
            // 
            this.cbDiceSelector.Font = new System.Drawing.Font("Gadugi", 13.25F);
            this.cbDiceSelector.FormattingEnabled = true;
            this.cbDiceSelector.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "20",
            "100"});
            this.cbDiceSelector.Location = new System.Drawing.Point(171, 47);
            this.cbDiceSelector.Name = "cbDiceSelector";
            this.cbDiceSelector.Size = new System.Drawing.Size(60, 29);
            this.cbDiceSelector.TabIndex = 21;
            this.cbDiceSelector.Text = "4";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Gadugi", 15.25F);
            this.lblD.Location = new System.Drawing.Point(144, 51);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(24, 25);
            this.lblD.TabIndex = 20;
            this.lblD.Text = "d";
            // 
            // lstDiceRolls
            // 
            this.lstDiceRolls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstDiceRolls.Font = new System.Drawing.Font("Gadugi", 8.5F);
            this.lstDiceRolls.FormattingEnabled = true;
            this.lstDiceRolls.ItemHeight = 14;
            this.lstDiceRolls.Location = new System.Drawing.Point(23, 172);
            this.lstDiceRolls.Name = "lstDiceRolls";
            this.lstDiceRolls.ScrollAlwaysVisible = true;
            this.lstDiceRolls.Size = new System.Drawing.Size(266, 270);
            this.lstDiceRolls.TabIndex = 19;
            // 
            // btnRoll
            // 
            this.btnRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoll.BackgroundImage")));
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRoll.Location = new System.Drawing.Point(23, 81);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(266, 70);
            this.btnRoll.TabIndex = 18;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // RollDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 464);
            this.Controls.Add(this.nudDiceRollAmount);
            this.Controls.Add(this.lblDiceRolls);
            this.Controls.Add(this.cbDiceSelector);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lstDiceRolls);
            this.Controls.Add(this.btnRoll);
            this.Name = "RollDice";
            this.Text = "Roll Dice";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiceRollAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiceRollAmount;
        private System.Windows.Forms.Label lblDiceRolls;
        private System.Windows.Forms.ComboBox cbDiceSelector;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.ListBox lstDiceRolls;
        private System.Windows.Forms.Button btnRoll;
    }
}