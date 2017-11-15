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
    public partial class Usercontrol_Sidepanel_Userpanel : UserControl
    {
        public static Usercontrol_Sidepanel_Userpanel usp;

        public Usercontrol_Sidepanel_Userpanel()
        {
            InitializeComponent();
            usp = this;
        }

        public void GetName(string name)
        {
            Label_Name.Text = name;
        }

        private void Picture_Proceed_Click(object sender, EventArgs e)
        {
            Form_Main.Main.EnterPassword();
        }
    }
}
