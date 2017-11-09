namespace Password_Man
{
    partial class Usercontrol_Sidepanel_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usercontrol_Sidepanel_Password));
            this.Label_Title = new System.Windows.Forms.Label();
            this.Pictrure_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.Picture_PasswordChar = new System.Windows.Forms.PictureBox();
            this.Placeholder_Password = new System.Windows.Forms.Label();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Button_Proceed = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Elipse_Password = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).BeginInit();
            this.Panel_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PasswordChar)).BeginInit();
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
            this.Label_Title.TabIndex = 5;
            this.Label_Title.Text = "Password Manager";
            // 
            // Pictrure_Logo
            // 
            this.Pictrure_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pictrure_Logo.Image = global::Password_Man.Properties.Resources.Logo2_White;
            this.Pictrure_Logo.Location = new System.Drawing.Point(75, -11);
            this.Pictrure_Logo.Name = "Pictrure_Logo";
            this.Pictrure_Logo.Size = new System.Drawing.Size(74, 78);
            this.Pictrure_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pictrure_Logo.TabIndex = 3;
            this.Pictrure_Logo.TabStop = false;
            // 
            // Panel_Password
            // 
            this.Panel_Password.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Password.Controls.Add(this.Picture_PasswordChar);
            this.Panel_Password.Controls.Add(this.Placeholder_Password);
            this.Panel_Password.Controls.Add(this.Textbox_Password);
            this.Panel_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Panel_Password.Location = new System.Drawing.Point(21, 205);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(182, 35);
            this.Panel_Password.TabIndex = 6;
            this.Panel_Password.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Password_Paint);
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
            // Placeholder_Password
            // 
            this.Placeholder_Password.AutoSize = true;
            this.Placeholder_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Placeholder_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placeholder_Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Placeholder_Password.Location = new System.Drawing.Point(10, 8);
            this.Placeholder_Password.Name = "Placeholder_Password";
            this.Placeholder_Password.Size = new System.Drawing.Size(69, 17);
            this.Placeholder_Password.TabIndex = 1;
            this.Placeholder_Password.Text = "Password";
            this.Placeholder_Password.Click += new System.EventHandler(this.Placeholder_Password_Click);
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
            // Button_Proceed
            // 
            this.Button_Proceed.ActiveBorderThickness = 1;
            this.Button_Proceed.ActiveCornerRadius = 20;
            this.Button_Proceed.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Button_Proceed.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.Button_Proceed.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Button_Proceed.BackColor = System.Drawing.Color.Transparent;
            this.Button_Proceed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Proceed.BackgroundImage")));
            this.Button_Proceed.ButtonText = "Proceed";
            this.Button_Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Proceed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Proceed.ForeColor = System.Drawing.Color.White;
            this.Button_Proceed.IdleBorderThickness = 1;
            this.Button_Proceed.IdleCornerRadius = 20;
            this.Button_Proceed.IdleFillColor = System.Drawing.Color.Transparent;
            this.Button_Proceed.IdleForecolor = System.Drawing.Color.White;
            this.Button_Proceed.IdleLineColor = System.Drawing.Color.Transparent;
            this.Button_Proceed.Location = new System.Drawing.Point(21, 252);
            this.Button_Proceed.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Proceed.Name = "Button_Proceed";
            this.Button_Proceed.Size = new System.Drawing.Size(182, 41);
            this.Button_Proceed.TabIndex = 7;
            this.Button_Proceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Elipse_Password
            // 
            this.Elipse_Password.ElipseRadius = 15;
            this.Elipse_Password.TargetControl = this.Panel_Password;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.White;
            this.Label_Name.Location = new System.Drawing.Point(31, 172);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(48, 17);
            this.Label_Name.TabIndex = 8;
            this.Label_Name.Text = "Name";
            // 
            // Usercontrol_Sidepanel_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Button_Proceed);
            this.Controls.Add(this.Panel_Password);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Pictrure_Logo);
            this.Name = "Usercontrol_Sidepanel_Password";
            this.Size = new System.Drawing.Size(221, 319);
            this.Load += new System.EventHandler(this.Usercontrol_Sidepanel_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).EndInit();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_PasswordChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.PictureBox Pictrure_Logo;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.PictureBox Picture_PasswordChar;
        private System.Windows.Forms.Label Placeholder_Password;
        public System.Windows.Forms.TextBox Textbox_Password;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Proceed;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Password;
        private System.Windows.Forms.Label Label_Name;
    }
}
