namespace WindowsFormsApplication2
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(13, 13);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(259, 30);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Gadugi", 10.75F);
            this.lblUser.Location = new System.Drawing.Point(14, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 19);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Gadugi", 10.75F);
            this.lblPass.Location = new System.Drawing.Point(14, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(74, 19);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.btnSubmit.Location = new System.Drawing.Point(18, 132);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(256, 48);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 57);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(175, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(99, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(175, 20);
            this.txtPass.TabIndex = 5;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Font = new System.Drawing.Font("Gadugi", 10.25F);
            this.btnCreateNew.Location = new System.Drawing.Point(18, 188);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(256, 48);
            this.btnCreateNew.TabIndex = 6;
            this.btnCreateNew.Text = "Create New User";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // lblPass2
            // 
            this.lblPass2.Font = new System.Drawing.Font("Gadugi", 8.75F);
            this.lblPass2.Location = new System.Drawing.Point(12, 126);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(80, 35);
            this.lblPass2.TabIndex = 7;
            this.lblPass2.Text = "Confirm New Password:";
            this.lblPass2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPass2.Visible = false;
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(99, 132);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(175, 20);
            this.txtPass2.TabIndex = 8;
            this.txtPass2.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogIn_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtPass2;
    }
}

