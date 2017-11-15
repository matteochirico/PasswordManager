using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Man
{
    public partial class Usercontrol_Background_Description : UserControl
    {
        public static Usercontrol_Background_Description ubd;

        public enum Type
        {
            Choose,
            Create,
            Password
        }

        public Usercontrol_Background_Description()
        {
            InitializeComponent();
            ubd = this;
        }

        public void ChangeType(Type type)
        {
            switch (type)
            {
                case Type.Choose:
                    Picture_Logo.Image = Properties.Resources.UserGroups_DarkGray;
                    Label_Info.Text = "Choose your user to proceed";
                    break;
                case Type.Create:
                    Picture_Logo.Image = Properties.Resources.AddUser2_DarkGray;
                    Label_Info.Text = "Create a new user";
                    break;
                case Type.Password:
                    Picture_Logo.Image = Properties.Resources.Access_DarkGrey;
                    Label_Info.Text = "Enter your password to proceed";
                    break;

            }
        }
    }
}
