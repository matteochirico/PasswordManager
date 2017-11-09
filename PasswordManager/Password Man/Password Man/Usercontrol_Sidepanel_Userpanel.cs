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
        Form_Main fm = new Form_Main();

        Usercontrol_Sidepanel_Password usp = new Usercontrol_Sidepanel_Password();
        Usercontrol_Background_Description ubd = new Usercontrol_Background_Description();

        public Usercontrol_Sidepanel_Userpanel()
        {
            InitializeComponent();
        }

        public void GetName(string name)
        {
            Label_Name.Text = name;
        }

        private void Picture_Proceed_Click(object sender, EventArgs e)
        {
            fm.EnterPassword();
        }
    }
}
