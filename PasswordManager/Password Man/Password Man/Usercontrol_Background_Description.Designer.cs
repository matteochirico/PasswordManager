namespace Password_Man
{
    partial class Usercontrol_Background_Description
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
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Label_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.Image = global::Password_Man.Properties.Resources.Access_DarkGrey;
            this.Picture_Logo.Location = new System.Drawing.Point(139, -11);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(74, 74);
            this.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Logo.TabIndex = 0;
            this.Picture_Logo.TabStop = false;
            // 
            // Label_Info
            // 
            this.Label_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Info.BackColor = System.Drawing.Color.Transparent;
            this.Label_Info.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Info.ForeColor = System.Drawing.Color.DarkGray;
            this.Label_Info.Location = new System.Drawing.Point(0, 77);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(353, 39);
            this.Label_Info.TabIndex = 2;
            this.Label_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Usercontrol_Background_Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.Picture_Logo);
            this.Name = "Usercontrol_Background_Description";
            this.Size = new System.Drawing.Size(353, 319);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Logo;
        private System.Windows.Forms.Label Label_Info;
    }
}
