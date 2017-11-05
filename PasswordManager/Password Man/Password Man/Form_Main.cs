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
        List<string> Users = new List<string>();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            CheckForUsers();

            if (Users.Count == 0)
            {
                Usercontrol_Sidepanel_Createuser uscu = new Usercontrol_Sidepanel_Createuser();
                Panel_Placeholder_Sidepanel.Controls.Add(uscu);
            }
        }

        public void CheckForUsers()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            MessageBox.Show(currentDirectory);
            var getFolder = Directory.GetDirectories(currentDirectory, "@*");

            for (var i = 0; i < getFolder.Length; i++)
            {
                MessageBox.Show(getFolder[i]);
                Users.Add(getFolder[i]);
                var startOfName = getFolder[i].IndexOf('@') + 1;
            }
        }
    }
}
