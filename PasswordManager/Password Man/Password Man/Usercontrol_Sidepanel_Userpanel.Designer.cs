﻿namespace Password_Man
{
    partial class Usercontrol_Sidepanel_Userpanel
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.Elipse_Usercontrol = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Picture_Proceed = new System.Windows.Forms.PictureBox();
            this.Picture_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Proceed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Name.AutoSize = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.White;
            this.Label_Name.Location = new System.Drawing.Point(41, 8);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(82, 18);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "Username";
            // 
            // Elipse_Usercontrol
            // 
            this.Elipse_Usercontrol.ElipseRadius = 15;
            this.Elipse_Usercontrol.TargetControl = this;
            // 
            // Picture_Proceed
            // 
            this.Picture_Proceed.Image = global::Password_Man.Properties.Resources.Forward_White;
            this.Picture_Proceed.Location = new System.Drawing.Point(152, 2);
            this.Picture_Proceed.Name = "Picture_Proceed";
            this.Picture_Proceed.Size = new System.Drawing.Size(30, 30);
            this.Picture_Proceed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Proceed.TabIndex = 2;
            this.Picture_Proceed.TabStop = false;
            this.Picture_Proceed.Click += new System.EventHandler(this.Picture_Proceed_Click);
            // 
            // Picture_Icon
            // 
            this.Picture_Icon.Image = global::Password_Man.Properties.Resources.User2_White;
            this.Picture_Icon.Location = new System.Drawing.Point(0, 0);
            this.Picture_Icon.Name = "Picture_Icon";
            this.Picture_Icon.Size = new System.Drawing.Size(35, 35);
            this.Picture_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Icon.TabIndex = 0;
            this.Picture_Icon.TabStop = false;
            // 
            // Usercontrol_Sidepanel_Userpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Picture_Proceed);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Picture_Icon);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Usercontrol_Sidepanel_Userpanel";
            this.Size = new System.Drawing.Size(182, 35);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Proceed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Icon;
        private System.Windows.Forms.Label Label_Name;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Usercontrol;
        private System.Windows.Forms.PictureBox Picture_Proceed;
    }
}
