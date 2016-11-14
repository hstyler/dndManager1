using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Forms;

namespace WindowsFormsApplication2
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Read in all preferences from the form radio buttons
            bool[] Prefs = new Boolean[3];

            //Checks for spell/attack notifications
            if (rbNoAtkSp.Checked == true)
            {
                Globals.Prefs[0] = false;
            }
            else
            {
                Globals.Prefs[0] = true;
            }

            //Checks for auto-roll
            if (rbNoAuto.Checked == true)
            {
                Globals.Prefs[1] = false;
            }
            else
            {
                Globals.Prefs[1] = true;
            }

            //Checks for instructional messages
            if (rbNoHelp.Checked == true)
            {
                Globals.Prefs[2] = false;
            }
            else
            {
                Globals.Prefs[2] = true;
            }

            //Write the preferences to the file
            FileRW.WritePrefs(Globals.currentUser, Application.StartupPath + "\\Users\\" + Globals.currentUser);

            bool passChangeAttempt = false;

            //If they have entered any data into the password textboxes
            if (!((txtNewPass.Text == "") && (txtNewPass2.Text == "") && (txtPrevPass.Text == "")))
            {
                //If they have entered two matching new passwords
                if (txtNewPass.Text == txtNewPass2.Text)
                {
                    passChangeAttempt = true;

                    string filePath = Application.StartupPath + "\\Users\\" + Globals.currentUser;

                    //If the current password entered matches the one in the user's file:
                    if (txtPrevPass.Text == FileRW.ReadUserPass(Globals.currentUser, filePath))
                    {
                        //Update their password & close form
                        FileRW.UpdateUserPass(Globals.currentUser, filePath, txtNewPass.Text);
                        this.Close();
                    }
                    else
                    {
                        //Otherwise output an error
                        MessageBox.Show("Previous password is incorrect, please check it has been entered correctly.");
                    }
                }
                else
                {
                    //If the two new passwords do not match, output an error
                    passChangeAttempt = true;
                    MessageBox.Show("New password fields do not match. Check that you have entered the password correctly.");
                }
            }

            //If they attempted to change the pass, and the form has not yet close (which
            //would happen were they to enter valid data), allow them to re-enter these details.
            //If they have simply changed the preferences, close the form.
            if (passChangeAttempt == true)
            {
                passChangeAttempt = false;
            }
            else
            {
                this.Close();
            }
        }


        private void Preferences_Load(object sender, EventArgs e)
        {
            //Fill in the relevant radio button option, using their current preferences
            //that have been read into the global preferences array.
            if (Globals.Prefs[0] == false)
            {
                rbNoAtkSp.Checked = true;
            }
            else
            {
                rbYesAtkSp.Checked = true;
            }

            if (Globals.Prefs[1] == false)
            {
                rbNoAuto.Checked = true;
            }
            else
            {
                rbYesAuto.Checked = true;
            }

            if (Globals.Prefs[2] == false)
            {
                rbNoHelp.Checked = true;
            }
            else
            {
                rbYesHelp.Checked = true;
            }
        }
    }
}
