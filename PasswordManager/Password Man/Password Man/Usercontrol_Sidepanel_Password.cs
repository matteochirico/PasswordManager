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
    public partial class Usercontrol_Sidepanel_Password : UserControl
    {
        public static Usercontrol_Sidepanel_Password usp;

        public Usercontrol_Sidepanel_Password()
        {
            InitializeComponent();

        }

        #region Textbox & etc.
        private void Placeholder_Password_Click(object sender, EventArgs e)
        {
            Textbox_Password.Focus();
        }

        private void Panel_Password_Paint(object sender, PaintEventArgs e)
        {
            Textbox_Password.Focus();
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
        #endregion

        private void Usercontrol_Sidepanel_Password_Load(object sender, EventArgs e)
        {
            Label_Name.Text = Form_Main.currentUser;
        }
    }
}
