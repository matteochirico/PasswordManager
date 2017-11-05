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
        public Usercontrol_Sidepanel_Userpanel()
        {
            InitializeComponent();
        }

        public void GetName(string name)
        {
            Label_Name.Text = name;
        }
    }
}
