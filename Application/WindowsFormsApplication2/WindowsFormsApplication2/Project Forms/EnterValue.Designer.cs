namespace WindowsFormsApplication2.Project_Forms.Unit_Entries
{
    partial class EnterValue
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
            this.lblEnterVal = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterVal
            // 
            this.lblEnterVal.AutoSize = true;
            this.lblEnterVal.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.lblEnterVal.Location = new System.Drawing.Point(13, 13);
            this.lblEnterVal.Name = "lblEnterVal";
            this.lblEnterVal.Size = new System.Drawing.Size(184, 17);
            this.lblEnterVal.TabIndex = 0;
            this.lblEnterVal.Text = "Enter a Custom ______ Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(16, 33);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(181, 20);
            this.txtValue.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EnterValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblEnterVal);
            this.Name = "EnterValue";
            this.Text = "EnterValue";
            this.Load += new System.EventHandler(this.EnterValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterVal;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSubmit;
    }
}