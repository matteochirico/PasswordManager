namespace Password_Man
{
    partial class Usercontrol_Sidepanel_Createuser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usercontrol_Sidepanel_Createuser));
            this.Label_Title = new System.Windows.Forms.Label();
            this.Panel_Name = new System.Windows.Forms.Panel();
            this.Placeholder_Name = new System.Windows.Forms.Label();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.Elipse_Name = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_Password = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.Placeholder_Password = new System.Windows.Forms.Label();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Button_CreateUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Picture_PasswordChar = new System.Windows.Forms.PictureBox();
            this.Pictrure_Logo = new System.Windows.Forms.PictureBox();
            this.Label_Error = new System.Windows.Forms.Label();
            this.Panel_Name.SuspendLayout();
            this.Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PasswordChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(34, 77);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(156, 19);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Password Manager";
            // 
            // Panel_Name
            // 
            this.Panel_Name.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Name.Controls.Add(this.Placeholder_Name);
            this.Panel_Name.Controls.Add(this.Textbox_Name);
            this.Panel_Name.Location = new System.Drawing.Point(21, 164);
            this.Panel_Name.Name = "Panel_Name";
            this.Panel_Name.Size = new System.Drawing.Size(182, 35);
            this.Panel_Name.TabIndex = 2;
            this.Panel_Name.Click += new System.EventHandler(this.Textbox_Name_Click);
            // 
            // Placeholder_Name
            // 
            this.Placeholder_Name.AutoSize = true;
            this.Placeholder_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placeholder_Name.ForeColor = System.Drawing.Color.DarkGray;
            this.Placeholder_Name.Location = new System.Drawing.Point(10, 8);
            this.Placeholder_Name.Name = "Placeholder_Name";
            this.Placeholder_Name.Size = new System.Drawing.Size(48, 17);
            this.Placeholder_Name.TabIndex = 1;
            this.Placeholder_Name.Text = "Name";
            this.Placeholder_Name.Click += new System.EventHandler(this.Textbox_Name_Click);
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.BackColor = System.Drawing.SystemColors.Control;
            this.Textbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Name.ForeColor = System.Drawing.Color.DimGray;
            this.Textbox_Name.Location = new System.Drawing.Point(9, 8);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(170, 16);
            this.Textbox_Name.TabIndex = 0;
            this.Textbox_Name.TextChanged += new System.EventHandler(this.Textbox_Name_TextChanged);
            // 
            // Elipse_Name
            // 
            this.Elipse_Name.ElipseRadius = 15;
            this.Elipse_Name.TargetControl = this.Panel_Name;
            // 
            // Elipse_Password
            // 
            this.Elipse_Password.ElipseRadius = 15;
            this.Elipse_Password.TargetControl = this.Panel_Password;
            // 
            // Panel_Password
            // 
            this.Panel_Password.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Password.Controls.Add(this.Picture_PasswordChar);
            this.Panel_Password.Controls.Add(this.Placeholder_Password);
            this.Panel_Password.Controls.Add(this.Textbox_Password);
            this.Panel_Password.Location = new System.Drawing.Point(21, 205);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(182, 35);
            this.Panel_Password.TabIndex = 3;
            this.Panel_Password.Click += new System.EventHandler(this.Textbox_Password_Click);
            // 
            // Placeholder_Password
            // 
            this.Placeholder_Password.AutoSize = true;
            this.Placeholder_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placeholder_Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Placeholder_Password.Location = new System.Drawing.Point(10, 8);
            this.Placeholder_Password.Name = "Placeholder_Password";
            this.Placeholder_Password.Size = new System.Drawing.Size(69, 17);
            this.Placeholder_Password.TabIndex = 1;
            this.Placeholder_Password.Text = "Password";
            this.Placeholder_Password.Click += new System.EventHandler(this.Textbox_Password_Click);
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.BackColor = System.Drawing.SystemColors.Control;
            this.Textbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Password.ForeColor = System.Drawing.Color.DimGray;
            this.Textbox_Password.Location = new System.Drawing.Point(9, 8);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '•';
            this.Textbox_Password.Size = new System.Drawing.Size(132, 16);
            this.Textbox_Password.TabIndex = 0;
            this.Textbox_Password.TextChanged += new System.EventHandler(this.Textbox_Password_TextChanged);
            // 
            // Button_CreateUser
            // 
            this.Button_CreateUser.ActiveBorderThickness = 1;
            this.Button_CreateUser.ActiveCornerRadius = 20;
            this.Button_CreateUser.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Button_CreateUser.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.Button_CreateUser.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Button_CreateUser.BackColor = System.Drawing.Color.Transparent;
            this.Button_CreateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_CreateUser.BackgroundImage")));
            this.Button_CreateUser.ButtonText = "Create User";
            this.Button_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CreateUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CreateUser.ForeColor = System.Drawing.Color.White;
            this.Button_CreateUser.IdleBorderThickness = 1;
            this.Button_CreateUser.IdleCornerRadius = 20;
            this.Button_CreateUser.IdleFillColor = System.Drawing.Color.Transparent;
            this.Button_CreateUser.IdleForecolor = System.Drawing.Color.White;
            this.Button_CreateUser.IdleLineColor = System.Drawing.Color.Transparent;
            this.Button_CreateUser.Location = new System.Drawing.Point(21, 252);
            this.Button_CreateUser.Margin = new System.Windows.Forms.Padding(5);
            this.Button_CreateUser.Name = "Button_CreateUser";
            this.Button_CreateUser.Size = new System.Drawing.Size(182, 41);
            this.Button_CreateUser.TabIndex = 2;
            this.Button_CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_CreateUser.Click += new System.EventHandler(this.Button_CreateUser_Click);
            // 
            // Picture_PasswordChar
            // 
            this.Picture_PasswordChar.Image = global::Password_Man.Properties.Resources.Visible_Gray;
            this.Picture_PasswordChar.Location = new System.Drawing.Point(147, 0);
            this.Picture_PasswordChar.Name = "Picture_PasswordChar";
            this.Picture_PasswordChar.Size = new System.Drawing.Size(30, 35);
            this.Picture_PasswordChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_PasswordChar.TabIndex = 2;
            this.Picture_PasswordChar.TabStop = false;
            this.Picture_PasswordChar.Visible = false;
            this.Picture_PasswordChar.Click += new System.EventHandler(this.Picture_PasswordChar_Click);
            // 
            // Pictrure_Logo
            // 
            this.Pictrure_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pictrure_Logo.Image = global::Password_Man.Properties.Resources.Logo2_White;
            this.Pictrure_Logo.Location = new System.Drawing.Point(75, -11);
            this.Pictrure_Logo.Name = "Pictrure_Logo";
            this.Pictrure_Logo.Size = new System.Drawing.Size(74, 78);
            this.Pictrure_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pictrure_Logo.TabIndex = 0;
            this.Pictrure_Logo.TabStop = false;
            // 
            // Label_Error
            // 
            this.Label_Error.BackColor = System.Drawing.Color.Transparent;
            this.Label_Error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.White;
            this.Label_Error.Location = new System.Drawing.Point(0, 297);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(221, 19);
            this.Label_Error.TabIndex = 4;
            this.Label_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usercontrol_Sidepanel_Createuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.Button_CreateUser);
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.Panel_Name);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Pictrure_Logo);
            this.Name = "Usercontrol_Sidepanel_Createuser";
            this.Size = new System.Drawing.Size(221, 319);
            this.Load += new System.EventHandler(this.Usercontrol_Sidepanel_Createuser_Load);
            this.Panel_Name.ResumeLayout(false);
            this.Panel_Name.PerformLayout();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PasswordChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictrure_Logo;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Panel Panel_Name;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Name;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Password;
        private System.Windows.Forms.Label Placeholder_Name;
        private System.Windows.Forms.TextBox Textbox_Name;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.Label Placeholder_Password;
        private System.Windows.Forms.TextBox Textbox_Password;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_CreateUser;
        private System.Windows.Forms.PictureBox Picture_PasswordChar;
        private System.Windows.Forms.Label Label_Error;
    }
}
