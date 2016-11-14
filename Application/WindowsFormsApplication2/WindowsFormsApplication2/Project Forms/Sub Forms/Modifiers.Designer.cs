namespace WindowsFormsApplication2
{
    partial class Modifiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifiers));
            this.lblModifiers = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbModifiers = new System.Windows.Forms.GroupBox();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.rbVuln = new System.Windows.Forms.RadioButton();
            this.rbResist = new System.Windows.Forms.RadioButton();
            this.rbImmune = new System.Windows.Forms.RadioButton();
            this.cbCrit = new System.Windows.Forms.CheckBox();
            this.gbModifiers.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifiers
            // 
            this.lblModifiers.AutoSize = true;
            this.lblModifiers.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblModifiers.Location = new System.Drawing.Point(12, 9);
            this.lblModifiers.Name = "lblModifiers";
            this.lblModifiers.Size = new System.Drawing.Size(260, 17);
            this.lblModifiers.TabIndex = 0;
            this.lblModifiers.Text = "Incoming Spell/Attack Damage Modifiers:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.btnConfirm.Location = new System.Drawing.Point(10, 160);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(262, 36);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbModifiers
            // 
            this.gbModifiers.Controls.Add(this.gbTarget);
            this.gbModifiers.Controls.Add(this.cbCrit);
            this.gbModifiers.Font = new System.Drawing.Font("Gadugi", 8.25F);
            this.gbModifiers.Location = new System.Drawing.Point(12, 29);
            this.gbModifiers.Name = "gbModifiers";
            this.gbModifiers.Size = new System.Drawing.Size(257, 125);
            this.gbModifiers.TabIndex = 5;
            this.gbModifiers.TabStop = false;
            this.gbModifiers.Text = "Damage Modifiers";
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.rbVuln);
            this.gbTarget.Controls.Add(this.rbResist);
            this.gbTarget.Controls.Add(this.rbImmune);
            this.gbTarget.Location = new System.Drawing.Point(7, 46);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(244, 72);
            this.gbTarget.TabIndex = 4;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target Attributes:";
            // 
            // rbVuln
            // 
            this.rbVuln.AutoSize = true;
            this.rbVuln.Location = new System.Drawing.Point(7, 46);
            this.rbVuln.Name = "rbVuln";
            this.rbVuln.Size = new System.Drawing.Size(81, 18);
            this.rbVuln.TabIndex = 2;
            this.rbVuln.TabStop = true;
            this.rbVuln.Text = "Vulnerable";
            this.rbVuln.UseVisualStyleBackColor = true;
            // 
            // rbResist
            // 
            this.rbResist.AutoSize = true;
            this.rbResist.Location = new System.Drawing.Point(122, 22);
            this.rbResist.Name = "rbResist";
            this.rbResist.Size = new System.Drawing.Size(72, 18);
            this.rbResist.TabIndex = 1;
            this.rbResist.TabStop = true;
            this.rbResist.Text = "Resistant";
            this.rbResist.UseVisualStyleBackColor = true;
            // 
            // rbImmune
            // 
            this.rbImmune.AutoSize = true;
            this.rbImmune.Location = new System.Drawing.Point(7, 22);
            this.rbImmune.Name = "rbImmune";
            this.rbImmune.Size = new System.Drawing.Size(66, 18);
            this.rbImmune.TabIndex = 0;
            this.rbImmune.TabStop = true;
            this.rbImmune.Text = "Immune";
            this.rbImmune.UseVisualStyleBackColor = true;
            // 
            // cbCrit
            // 
            this.cbCrit.AutoSize = true;
            this.cbCrit.Location = new System.Drawing.Point(13, 22);
            this.cbCrit.Name = "cbCrit";
            this.cbCrit.Size = new System.Drawing.Size(61, 18);
            this.cbCrit.TabIndex = 0;
            this.cbCrit.Text = "Critical";
            this.cbCrit.UseVisualStyleBackColor = true;
            // 
            // Modifiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 200);
            this.ControlBox = false;
            this.Controls.Add(this.gbModifiers);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblModifiers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modifiers";
            this.Text = "Modifiers";
            this.Load += new System.EventHandler(this.Modifiers_Load);
            this.gbModifiers.ResumeLayout(false);
            this.gbModifiers.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifiers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbModifiers;
        private System.Windows.Forms.CheckBox cbCrit;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.RadioButton rbVuln;
        private System.Windows.Forms.RadioButton rbResist;
        private System.Windows.Forms.RadioButton rbImmune;
    }
}