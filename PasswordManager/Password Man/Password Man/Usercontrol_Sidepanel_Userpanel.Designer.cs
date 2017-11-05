namespace Password_Man
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
            this.Picture_Icon = new System.Windows.Forms.PictureBox();
            this.Elipse_Usercontrol = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Name.Location = new System.Drawing.Point(41, 9);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(72, 16);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "Username";
            // 
            // Picture_Icon
            // 
            this.Picture_Icon.Image = global::Password_Man.Properties.Resources.User2_Gray;
            this.Picture_Icon.Location = new System.Drawing.Point(0, 0);
            this.Picture_Icon.Name = "Picture_Icon";
            this.Picture_Icon.Size = new System.Drawing.Size(35, 35);
            this.Picture_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Icon.TabIndex = 0;
            this.Picture_Icon.TabStop = false;
            // 
            // Elipse_Usercontrol
            // 
            this.Elipse_Usercontrol.ElipseRadius = 15;
            this.Elipse_Usercontrol.TargetControl = this;
            // 
            // Usercontrol_Sidepanel_Userpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Picture_Icon);
            this.Name = "Usercontrol_Sidepanel_Userpanel";
            this.Size = new System.Drawing.Size(182, 35);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Icon;
        private System.Windows.Forms.Label Label_Name;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Usercontrol;
    }
}
