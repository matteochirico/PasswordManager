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
    public partial class Usercontol_Sidepanel_Chooseuser : UserControl
    {
        public Usercontol_Sidepanel_Chooseuser()
        {
            InitializeComponent();
        }

        public void AddUser(string name, int count)
        {
            Usercontrol_Sidepanel_Userpanel usup = new Usercontrol_Sidepanel_Userpanel();
            usup.GetName(name);
            usup.Location = new Point(0, count);
            Panel_Placeholder_Users.Controls.Add(usup);
            
        }

        private void Usercontol_Sidepanel_Chooseuser_Load(object sender, EventArgs e)
        {
            
        }

        private void Panel_Placeholder_Users_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
