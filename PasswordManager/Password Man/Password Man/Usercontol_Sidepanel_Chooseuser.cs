﻿using System;
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
        Usercontrol_Sidepanel_Userpanel usup = new Usercontrol_Sidepanel_Userpanel();
        Form_Main fm = new Form_Main();

        public Usercontol_Sidepanel_Chooseuser()
        {
            InitializeComponent();
        }

        public void AddUser(string name)
        {
            
            usup.GetName(name);
            usup.Location = new Point(0, 0);
            Panel_Placeholder_Users.Controls.Add(usup);
            
        }

        private void Usercontol_Sidepanel_Chooseuser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
