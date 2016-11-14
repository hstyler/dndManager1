namespace WindowsFormsApplication2.Classes
{
    partial class LoadFile
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Gadugi", 15F);
            this.lblInstructions.Location = new System.Drawing.Point(56, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(193, 24);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Choose a file to load:";
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.Location = new System.Drawing.Point(13, 40);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.ScrollAlwaysVisible = true;
            this.lstFileList.Size = new System.Drawing.Size(293, 186);
            this.lstFileList.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 15.5F);
            this.btnSubmit.Location = new System.Drawing.Point(13, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(293, 48);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 290);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.lblInstructions);
            this.Name = "LoadFile";
            this.Text = "LoadFile";
            this.Load += new System.EventHandler(this.LoadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button btnSubmit;
    }
}