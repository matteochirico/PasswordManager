﻿namespace Password_Man
{
    partial class Usercontrol_Sidepanel_Main
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
            this.Pictrure_Logo = new System.Windows.Forms.PictureBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictrure_Logo
            // 
            this.Pictrure_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pictrure_Logo.Image = global::Password_Man.Properties.Resources.Logo2_White;
            this.Pictrure_Logo.Location = new System.Drawing.Point(75, -11);
            this.Pictrure_Logo.Name = "Pictrure_Logo";
            this.Pictrure_Logo.Size = new System.Drawing.Size(74, 78);
            this.Pictrure_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pictrure_Logo.TabIndex = 4;
            this.Pictrure_Logo.TabStop = false;
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
            this.Label_Title.TabIndex = 6;
            this.Label_Title.Text = "Password Manager";
            // 
            // Label_Name
            // 
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.White;
            this.Label_Name.Location = new System.Drawing.Point(0, 108);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(221, 19);
            this.Label_Name.TabIndex = 7;
            this.Label_Name.Text = "Name";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Usercontrol_Sidepanel_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Pictrure_Logo);
            this.Name = "Usercontrol_Sidepanel_Main";
            this.Size = new System.Drawing.Size(221, 319);
            this.Load += new System.EventHandler(this.Usercontrol_Sidepanel_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pictrure_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictrure_Logo;
        public System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_Name;
    }
}
