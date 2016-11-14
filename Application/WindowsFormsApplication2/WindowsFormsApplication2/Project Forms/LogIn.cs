using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApplication2.Forms;

namespace WindowsFormsApplication2
{
    public partial class LogIn : Form
    {
        string filePath = Application.StartupPath;
        bool createNew = false;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //If the form is not in create new mode, so the user is logging in:
            if (!createNew)
            {
                //Read in text box values
                string username = txtUser.Text;
                string userpass = txtPass.Text;
                string userFilePath = filePath + "\\Users\\" + username;

                //If userfile actually exists:
                if (File.Exists(userFilePath + "\\" + username + ".txt"))
                {
                    //If passwords match:
                    if (userpass == FileRW.ReadUserPass(username, userFilePath))
                    {
                        //Open the main form, and set the current user value to the new username
                        Globals.currentUser = username;
                        Form MainForm = new MainForm();
                        //Hide login form
                        this.Hide();
                        MainForm.Show(); 
                    }
                    else
                    {
                        //If pass is incorrect, output error, clear password textboxes
                        MessageBox.Show("Incorrect password, please ensure that you have entered your password correctly");
                        ClearEntries(false);
                    }
                }
                else
                {
                    //If user doesn't exist, clear password textboxes, output error
                    MessageBox.Show("User not found, please enter an existing username, or create a new user");
                    ClearEntries(false);
                }
            }
            //if the form is in create new mode, so a new user is being created:
            else
            {
                //Read in passwords and username.
                string username = txtUser.Text;
                string userpass1 = txtPass.Text;
                string userpass2 = txtPass2.Text;

                //If they have entered all relevant data, carry on with user creation.
                if (!((txtPass.Text == "" && txtPass2.Text == "") && txtPass.Text == ""))
                {
                    //If passwords match, go on to create user.
                    if (userpass1 == userpass2)
                    {
                        //Store the intended file path for the user directory
                        string userFilePath = filePath + "\\Users\\" + username;

                        //If there is a directory with this name already:
                        if (Directory.Exists(userFilePath))
                        {
                            //Output error, return to log in.
                            MessageBox.Show("User already exists with name '" + username + "' please choose another username, or log in if this is your account");
                            LogInMode();
                        }
                        else
                        {
                            //Create user folder, and sub-folders
                            Directory.CreateDirectory(userFilePath);
                            Directory.CreateDirectory(userFilePath + "\\Units");
                            Directory.CreateDirectory(userFilePath + "\\Units\\Enemies");
                            Directory.CreateDirectory(userFilePath + "\\Units\\Players");
                            Directory.CreateDirectory(userFilePath + "\\Encounters");

                            //Create New User file
                            FileRW.WriteUser(username, txtPass.Text, userFilePath);
                            Globals.Prefs[0] = true;
                            Globals.Prefs[1] = false;
                            Globals.Prefs[2] = true;

                            FileRW.WritePrefs(username, userFilePath); 

                            ClearEntries(true);

                            //Open the main form, and set the current user value to the new username
                            Globals.currentUser = username;
                            Form MainForm = new MainForm();
                            //Hide login form
                            this.Hide();
                            MainForm.Show();
                        }
                    }
                    else
                    {
                        //If passwords do not match, output error, allow them to re-enter.
                        MessageBox.Show("Passwords do not match, please check that you have entered your new password correctly.");
                        ClearEntries(false);

                    }
                }
                else
                {
                    //If data is missing, output error message.
                    MessageBox.Show("Please enter username and password");
                    ClearEntries(true);
                }
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (btnCreateNew.Text == "Create New User")
            {
                //Clear all textboxes, change form into createnew mode
                ClearEntries(true);
                CreateNewMode();
            }
            else
            {
                //Clear all textboxes, change form into login mode
                ClearEntries(true);
                LogInMode();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //If the users folder exists:
            if (!Directory.Exists(filePath + "\\Users"))
            {
                //Display message alerting user of this, and create folder
                MessageBox.Show("No users folder found, new user folder created.");
                Directory.CreateDirectory(filePath + "\\Users");
            }
        }

        private void LogInMode()
        {
            ClearEntries(true);

            //When logging in, change form title, resize form.
            this.Size = new Size(this.Size.Width, this.Size.Height - 32);
            lblLogIn.Text = "Log In";

            //Move buttons up, hide second password textbox
            btnCreateNew.Text = "Create New User";
            txtPass2.Visible = false;
            lblPass2.Visible = false;
            btnSubmit.Location = new Point(btnSubmit.Location.X, btnSubmit.Location.Y - 32);
            btnCreateNew.Location = new Point(btnCreateNew.Location.X, btnCreateNew.Location.Y - 32);

            //Set createNew to false so that the correct code will be run on submit
            createNew = false;
        }

        private void CreateNewMode()
        {
            ClearEntries(true);

            //When creating a new user, change form title, resize form.
            this.Size = new Size(this.Size.Width, this.Size.Height + 32);
            lblLogIn.Text = "Create New User";

            //Change create new button to cancel button, and show new password text box, move all objects down
            //to create space for the new text box
            btnCreateNew.Text = "Cancel";
            btnSubmit.Location = new Point(btnSubmit.Location.X, btnSubmit.Location.Y + 32);
            btnCreateNew.Location = new Point(btnCreateNew.Location.X, btnCreateNew.Location.Y + 32);
            txtPass2.Visible = true;
            lblPass2.Visible = true;

            //Set createNew to true so that the correct code will be run on submit
            createNew = true;
        }

        private void ClearEntries(bool clearUsername)
        {
            //Empty all textboxes on form.
            txtPass.Text = "";
            txtPass2.Text = "";
            if (clearUsername == true)
            {
                txtUser.Text = "";
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}
