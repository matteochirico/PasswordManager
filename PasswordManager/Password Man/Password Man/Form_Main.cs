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
        public static string currentUser, currentPassword;
        public static List<string> Users = new List<string>();
        static string[] getFolder;

        public static Form_Main Main;
        public Form_Main()
        {
            InitializeComponent();
            Main = this;
            Usercontol_Sidepanel_Chooseuser.uschu = new Usercontol_Sidepanel_Chooseuser();
            Usercontrol_Background_Description.ubd = new Usercontrol_Background_Description();
            Usercontrol_Sidepanel_Createuser.uscu = new Usercontrol_Sidepanel_Createuser();
            Usercontrol_Sidepanel_Password.usp = new Usercontrol_Sidepanel_Password();
            Usercontrol_Sidepanel_Main.usm = new Usercontrol_Sidepanel_Main();
            DoubleBuffered = true;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            CheckForUsers();
            if (Users.Count == 0)
            {
                Usercontrol_Sidepanel_Createuser.firstTime = true;
                Panel_Placeholder_Sidepanel.Controls.Add(Usercontrol_Sidepanel_Createuser.uscu);

                Panel_Placeholder_Background.Controls.Add(Usercontrol_Background_Description.ubd);
                Usercontrol_Background_Description.ubd.ChangeType(Usercontrol_Background_Description.Type.Create);
                Usercontrol_Background_Description.ubd.BringToFront();
            }
            else
            {
                Usercontrol_Sidepanel_Createuser.firstTime = false;
                Panel_Placeholder_Sidepanel.Controls.Add(Usercontol_Sidepanel_Chooseuser.uschu);

                Panel_Placeholder_Background.Controls.Add(Usercontrol_Background_Description.ubd);
                Usercontrol_Background_Description.ubd.ChangeType(Usercontrol_Background_Description.Type.Choose);
                Usercontrol_Background_Description.ubd.BringToFront();
                Picture_AddUser.Visible = true;             
            }

            Opacity = 0;
            Timer_FormFadeIn.Start();
        }

        public static void CheckForUsers()
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

                    Usercontol_Sidepanel_Chooseuser.uschu.AddUser(fullName(), (Users.Count - 1) * 42);
                }
            }
        }

        private void Picture_AddUser_Click(object sender, EventArgs e)
        {
            Picture_AddUser.Visible = false;
            Picture_AddUser.Enabled = false;
            Picture_GoBack.Visible = true;
            Picture_GoBack.Enabled = true;

            Panel_Placeholder_Sidepanel.Controls.Add(Usercontrol_Sidepanel_Createuser.uscu);
            Usercontrol_Sidepanel_Createuser.uscu.BringToFront();

            Panel_Placeholder_Background.Controls.Add(Usercontrol_Background_Description.ubd);
            Usercontrol_Background_Description.ubd.ChangeType(Usercontrol_Background_Description.Type.Create);
        }

        private void Picture_GoBack_Click(object sender, EventArgs e)
        {
            Picture_AddUser.Visible = true;
            Picture_AddUser.Enabled = true;
            Picture_GoBack.Visible = false;
            Picture_GoBack.Enabled = false;

            Panel_Placeholder_Sidepanel.Controls.Clear();

            Panel_Placeholder_Sidepanel.Controls.Add(Usercontol_Sidepanel_Chooseuser.uschu);
            Users.Clear();
            CheckForUsers();

            Usercontrol_Background_Description.ubd.ChangeType(Usercontrol_Background_Description.Type.Choose);

            Usercontrol_Sidepanel_Createuser.uscu.Textbox_Name.Clear();
            Usercontrol_Sidepanel_Createuser.uscu.Textbox_Password.Clear();

            Usercontrol_Sidepanel_Password.usp.Textbox_Password.Clear();
            Usercontrol_Sidepanel_Password.usp.Label_Name.Text = "";
        }

        public void EnterPassword(string name)
        {
            Usercontrol_Background_Description.ubd.ChangeType(Usercontrol_Background_Description.Type.Password);
            
            Panel_Placeholder_Sidepanel.Controls.Add(Usercontrol_Sidepanel_Password.usp);
            Usercontrol_Sidepanel_Password.usp.BringToFront();

            Usercontrol_Sidepanel_Password.usp.Label_Name.Text = name;

            Picture_GoBack.Visible = true;
            Picture_GoBack.Enabled = true;
            Picture_AddUser.Visible = false;
            Picture_AddUser.Enabled = false;
        }

        #region FadeIn & FadeOut
        private void Picture_Exit_Click(object sender, EventArgs e)
        {
            Timer_FormFadeOut.Start();
        }

        private void Picture_Minimize_Click(object sender, EventArgs e)
        {
            Timer_FormMinimzeOut.Start();
        }

        private void Timer_FormFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;

            if (Opacity == 1)
            {
                Timer_FormFadeIn.Stop();
            }
        }

        private void Timer_FormFadeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;

            if (Opacity == 0)
            {
                Timer_FormFadeOut.Stop();
                Application.Exit();
            }
        }

        private void Timer_FormMinimizeIn_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Opacity += 0.1;

                if (Opacity == 1)
                {
                    Timer_FormMinimizeIn.Stop();
                }
            }
        }

        private void Timer_FormMinimzeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;

            if (Opacity == 0)
            {
                WindowState = FormWindowState.Minimized;
                Timer_FormMinimzeOut.Stop();
                Timer_FormMinimizeIn.Start();
            }
        }

        private void Timer_WindowstateCheck_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        public void LogIn(string user, string password)
        {
            currentUser = user;
            currentPassword = password;

            try
            {
                Panel_Placeholder_Sidepanel.Controls.Remove(Usercontol_Sidepanel_Chooseuser.uschu);
                Panel_Placeholder_Sidepanel.Controls.Remove(Usercontrol_Sidepanel_Password.usp);
            }
            catch
            {
                Panel_Placeholder_Sidepanel.Controls.Remove(Usercontrol_Sidepanel_Createuser.uscu);
            }

            Panel_Placeholder_Sidepanel.Controls.Add(Usercontrol_Sidepanel_Main.usm);
            Usercontrol_Sidepanel_Main.usm.Label_Title.Text = currentUser;
        }
    }
}
