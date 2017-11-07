using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Password_Man
{
    public partial class Usercontrol_Sidepanel_Createuser : UserControl
    {
        public Usercontrol_Sidepanel_Createuser()
        {
            InitializeComponent();
        }

        #region TextBoxes & etc.
        private void Textbox_Name_Click(object sender, EventArgs e)
        {
            Textbox_Name.Focus();
        }

        private void Textbox_Password_Click(object sender, EventArgs e)
        {
            Textbox_Password.Focus();
        }

        private void Textbox_Name_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_Name.Text.Length == 0)
            {
                Placeholder_Name.Visible = true;
            }
            else
            {
                Placeholder_Name.Visible = false;
            }
        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e)
        {
            Textbox_Password.PasswordChar = char.Parse("•");
            Picture_PasswordChar.Image = Properties.Resources.Visible_Gray;

            if (Textbox_Password.Text.Length == 0)
            {
                Placeholder_Password.Visible = true;
                Picture_PasswordChar.Visible = false;
            }
            else
            {
                Placeholder_Password.Visible = false;
                Picture_PasswordChar.Visible = true;
            }
        }

        private void Picture_PasswordChar_Click(object sender, EventArgs e)
        {
            if (Textbox_Password.PasswordChar == char.Parse("•"))
            {
                Textbox_Password.PasswordChar = char.MinValue;
                Picture_PasswordChar.Image = Properties.Resources.Invisible_Gray;
            }
            else
            {
                Textbox_Password.PasswordChar = char.Parse("•");
                Picture_PasswordChar.Image = Properties.Resources.Visible_Gray;
            }
        }
        #endregion

        public void CreateUser(string name, string password)
        {
            if (Directory.Exists("@" + name.ToLower()))
            {
                Label_Error.Text = "That username is taken.";
            }
            else
            {
                Directory.CreateDirectory("@" + name.ToLower());
                string BaseDirectory = "@" + name.ToLower();
                string FileDirectory = "#" + name.ToLower();
                StreamWriter sp = new StreamWriter(Path.Combine(BaseDirectory, FileDirectory) + "p");
                sp.Write(password);
                sp.Flush();
                sp.Close();
                StreamWriter sn = new StreamWriter(Path.Combine(BaseDirectory, FileDirectory) + "n");
                sn.Write(name);
                sn.Flush();
                sn.Close();
                File.Encrypt(Path.Combine(BaseDirectory, FileDirectory) + "p");
                File.Encrypt(Path.Combine(BaseDirectory, FileDirectory) + "n");
            }
        }

        private void Usercontrol_Sidepanel_Createuser_Load(object sender, EventArgs e)
        {
           
        }

        private void Button_CreateUser_Click(object sender, EventArgs e)
        {
            if (Textbox_Name.Text.Length != 0 && Textbox_Password.Text.Length != 0 && !Textbox_Name.Text.Contains(" ") && !Textbox_Password.Text.Contains(" "))
            {
                string CasedLetter = Textbox_Name.Text.Substring(0, 1).ToUpper();
                string RestName = Textbox_Name.Text.Substring(1, Textbox_Name.Text.Length - 1);
                
                string CasedName = CasedLetter + RestName;

                CreateUser(CasedName, Textbox_Password.Text);
            }
        }
    }
}
