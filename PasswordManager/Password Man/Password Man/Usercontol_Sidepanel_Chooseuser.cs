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
        public static Usercontol_Sidepanel_Chooseuser uschu { get; set; }

        public Usercontol_Sidepanel_Chooseuser()
        {
            uschu = this;
            InitializeComponent();
           
        }

        public void AddUser(string name, int count)
        {
            Usercontrol_Sidepanel_Userpanel.usp.GetName(name);
            Usercontrol_Sidepanel_Userpanel.usp.Location = new Point(0, count);
            Panel_Placeholder_Users.Controls.Add(Usercontrol_Sidepanel_Userpanel.usp);
            
        }

        private void Usercontol_Sidepanel_Chooseuser_Load(object sender, EventArgs e)
        {
            
        }

        private void Panel_Placeholder_Users_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
