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

namespace Password_Man
{
    public partial class Form_Main : Form
    {
        public List<string> Users = new List<string>();
        string[] getFolder;
        

        Usercontrol_Sidepanel_Createuser uscu = new Usercontrol_Sidepanel_Createuser();
        Usercontol_Sidepanel_Chooseuser uschu = new Usercontol_Sidepanel_Chooseuser();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            CheckForUsers();

            if (Users.Count == 0)
            {
                Panel_Placeholder_Sidepanel.Controls.Add(uscu);
            }
            else
            {
                Panel_Placeholder_Sidepanel.Controls.Add(uschu);
                Picture_AddUser.Visible = true;             
            }
        }

        public void CheckForUsers()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            getFolder = Directory.GetDirectories(currentDirectory, "@*");

            for (var i = 0; i < getFolder.Length; i++)
            {
                if (!Users.Contains(getFolder[i]))
                {
                    Users.Add(getFolder[i]);

                    string fullName()
                    {
                        var index = getFolder[i].IndexOf('@') + 1;
                        string name = getFolder[i].Substring(index);
                        string casedLetter = name.Substring(0, 1).ToUpper();
                        string restOfName = name.Substring(1, name.Length - 1);
                        return casedLetter + restOfName;

                    }


                    uschu.AddUser(fullName(), (Users.Count - 1) * 41);
                }
            }
        }

        private void Picture_AddUser_Click(object sender, EventArgs e)
        {
            Picture_AddUser.Visible = false;
            Picture_AddUser.Enabled = false;
            Picture_GoBack.Visible = true;
            Picture_GoBack.Enabled = true;
            Panel_Placeholder_Sidepanel.Controls.Add(uscu);
            uscu.BringToFront();
        }

        private void Picture_GoBack_Click(object sender, EventArgs e)
        {
            CheckForUsers();
            Panel_Placeholder_Sidepanel.Controls.Remove(uscu);
            Picture_AddUser.Visible = true;
            Picture_AddUser.Enabled = true;
            Picture_GoBack.Visible = false;
            Picture_GoBack.Enabled = false;
        }
    }
}
