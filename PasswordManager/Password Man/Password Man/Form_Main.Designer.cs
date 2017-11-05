﻿namespace Password_Man
{
    partial class Form_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Header2 = new System.Windows.Forms.Panel();
            this.Drag_Header1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Drag_Header2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Picture_Minimize = new System.Windows.Forms.PictureBox();
            this.Picture_Exit = new System.Windows.Forms.PictureBox();
            this.Gradient_Sidepanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Panel_Placeholder_Sidepanel = new System.Windows.Forms.Panel();
            this.Panel_Header1 = new System.Windows.Forms.Panel();
            this.Picture_GoBack = new System.Windows.Forms.PictureBox();
            this.Picture_AddUser = new System.Windows.Forms.PictureBox();
            this.Animator_Usercontrol = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Panel_Header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Exit)).BeginInit();
            this.Gradient_Sidepanel.SuspendLayout();
            this.Panel_Header1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_GoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_AddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // Panel_Header2
            // 
            this.Panel_Header2.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Header2.Controls.Add(this.Picture_Minimize);
            this.Panel_Header2.Controls.Add(this.Picture_Exit);
            this.Animator_Usercontrol.SetDecoration(this.Panel_Header2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header2.Location = new System.Drawing.Point(221, 0);
            this.Panel_Header2.Name = "Panel_Header2";
            this.Panel_Header2.Size = new System.Drawing.Size(353, 40);
            this.Panel_Header2.TabIndex = 1;
            // 
            // Drag_Header1
            // 
            this.Drag_Header1.Fixed = true;
            this.Drag_Header1.Horizontal = true;
            this.Drag_Header1.TargetControl = this.Panel_Header1;
            this.Drag_Header1.Vertical = true;
            // 
            // Drag_Header2
            // 
            this.Drag_Header2.Fixed = true;
            this.Drag_Header2.Horizontal = true;
            this.Drag_Header2.TargetControl = this.Panel_Header2;
            this.Drag_Header2.Vertical = true;
            // 
            // Panel_Background
            // 
            this.Animator_Usercontrol.SetDecoration(this.Panel_Background, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Background.Location = new System.Drawing.Point(221, 40);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(353, 319);
            this.Panel_Background.TabIndex = 2;
            // 
            // Picture_Minimize
            // 
            this.Animator_Usercontrol.SetDecoration(this.Picture_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.Picture_Minimize.Image = global::Password_Man.Properties.Resources.Minimize_Gray;
            this.Picture_Minimize.Location = new System.Drawing.Point(281, 0);
            this.Picture_Minimize.Name = "Picture_Minimize";
            this.Picture_Minimize.Size = new System.Drawing.Size(35, 40);
            this.Picture_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Minimize.TabIndex = 1;
            this.Picture_Minimize.TabStop = false;
            // 
            // Picture_Exit
            // 
            this.Animator_Usercontrol.SetDecoration(this.Picture_Exit, BunifuAnimatorNS.DecorationType.None);
            this.Picture_Exit.Image = global::Password_Man.Properties.Resources.Exit_Gray;
            this.Picture_Exit.Location = new System.Drawing.Point(315, 0);
            this.Picture_Exit.Name = "Picture_Exit";
            this.Picture_Exit.Size = new System.Drawing.Size(35, 40);
            this.Picture_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Exit.TabIndex = 0;
            this.Picture_Exit.TabStop = false;
            // 
            // Gradient_Sidepanel
            // 
            this.Gradient_Sidepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gradient_Sidepanel.BackgroundImage")));
            this.Gradient_Sidepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gradient_Sidepanel.Controls.Add(this.Panel_Placeholder_Sidepanel);
            this.Gradient_Sidepanel.Controls.Add(this.Panel_Header1);
            this.Animator_Usercontrol.SetDecoration(this.Gradient_Sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.Gradient_Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Gradient_Sidepanel.GradientBottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.Gradient_Sidepanel.GradientBottomRight = System.Drawing.Color.SlateBlue;
            this.Gradient_Sidepanel.GradientTopLeft = System.Drawing.Color.LightPink;
            this.Gradient_Sidepanel.GradientTopRight = System.Drawing.Color.SeaShell;
            this.Gradient_Sidepanel.Location = new System.Drawing.Point(0, 0);
            this.Gradient_Sidepanel.Name = "Gradient_Sidepanel";
            this.Gradient_Sidepanel.Quality = 10;
            this.Gradient_Sidepanel.Size = new System.Drawing.Size(221, 359);
            this.Gradient_Sidepanel.TabIndex = 0;
            // 
            // Panel_Placeholder_Sidepanel
            // 
            this.Panel_Placeholder_Sidepanel.BackColor = System.Drawing.Color.Transparent;
            this.Animator_Usercontrol.SetDecoration(this.Panel_Placeholder_Sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Placeholder_Sidepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Placeholder_Sidepanel.Location = new System.Drawing.Point(0, 40);
            this.Panel_Placeholder_Sidepanel.Name = "Panel_Placeholder_Sidepanel";
            this.Panel_Placeholder_Sidepanel.Size = new System.Drawing.Size(221, 319);
            this.Panel_Placeholder_Sidepanel.TabIndex = 3;
            // 
            // Panel_Header1
            // 
            this.Panel_Header1.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Header1.Controls.Add(this.Picture_GoBack);
            this.Panel_Header1.Controls.Add(this.Picture_AddUser);
            this.Animator_Usercontrol.SetDecoration(this.Panel_Header1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header1.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header1.Name = "Panel_Header1";
            this.Panel_Header1.Size = new System.Drawing.Size(221, 40);
            this.Panel_Header1.TabIndex = 2;
            // 
            // Picture_GoBack
            // 
            this.Animator_Usercontrol.SetDecoration(this.Picture_GoBack, BunifuAnimatorNS.DecorationType.None);
            this.Picture_GoBack.Image = global::Password_Man.Properties.Resources.Back_White;
            this.Picture_GoBack.Location = new System.Drawing.Point(3, 3);
            this.Picture_GoBack.Name = "Picture_GoBack";
            this.Picture_GoBack.Size = new System.Drawing.Size(30, 30);
            this.Picture_GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_GoBack.TabIndex = 7;
            this.Picture_GoBack.TabStop = false;
            this.Picture_GoBack.Visible = false;
            this.Picture_GoBack.Click += new System.EventHandler(this.Picture_GoBack_Click);
            // 
            // Picture_AddUser
            // 
            this.Animator_Usercontrol.SetDecoration(this.Picture_AddUser, BunifuAnimatorNS.DecorationType.None);
            this.Picture_AddUser.Image = global::Password_Man.Properties.Resources.AddUser_White;
            this.Picture_AddUser.Location = new System.Drawing.Point(3, 3);
            this.Picture_AddUser.Name = "Picture_AddUser";
            this.Picture_AddUser.Size = new System.Drawing.Size(30, 30);
            this.Picture_AddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_AddUser.TabIndex = 6;
            this.Picture_AddUser.TabStop = false;
            this.Picture_AddUser.Visible = false;
            this.Picture_AddUser.Click += new System.EventHandler(this.Picture_AddUser_Click);
            // 
            // Animator_Usercontrol
            // 
            this.Animator_Usercontrol.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Animator_Usercontrol.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Animator_Usercontrol.DefaultAnimation = animation1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 359);
            this.Controls.Add(this.Panel_Background);
            this.Controls.Add(this.Panel_Header2);
            this.Controls.Add(this.Gradient_Sidepanel);
            this.Animator_Usercontrol.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Panel_Header2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Exit)).EndInit();
            this.Gradient_Sidepanel.ResumeLayout(false);
            this.Panel_Header1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_GoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_AddUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Gradient_Sidepanel;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Panel Panel_Header1;
        private System.Windows.Forms.Panel Panel_Header2;
        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.PictureBox Picture_Exit;
        private Bunifu.Framework.UI.BunifuDragControl Drag_Header1;
        private Bunifu.Framework.UI.BunifuDragControl Drag_Header2;
        private System.Windows.Forms.PictureBox Picture_Minimize;
        private System.Windows.Forms.Panel Panel_Placeholder_Sidepanel;
        private System.Windows.Forms.PictureBox Picture_AddUser;
        private System.Windows.Forms.PictureBox Picture_GoBack;
        private BunifuAnimatorNS.BunifuTransition Animator_Usercontrol;
    }
}

