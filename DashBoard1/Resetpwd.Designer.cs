namespace DashBoard1
{
    partial class Resetpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resetpwd));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FACULTY = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Button_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.Fade_Timer = new System.Windows.Forms.Timer(this.components);
            this.Reset_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Login_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.c_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.User_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.resetcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.FACULTY);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(428, 769);
            this.bunifuGradientPanel1.TabIndex = 14;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 477);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(407, 78);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "INDICATOR";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 355);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(333, 64);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "PRESENCE";
            // 
            // FACULTY
            // 
            this.FACULTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FACULTY.AutoSize = true;
            this.FACULTY.BackColor = System.Drawing.Color.Transparent;
            this.FACULTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.FACULTY.ForeColor = System.Drawing.Color.White;
            this.FACULTY.Location = new System.Drawing.Point(52, 197);
            this.FACULTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FACULTY.Name = "FACULTY";
            this.FACULTY.Size = new System.Drawing.Size(343, 78);
            this.FACULTY.TabIndex = 0;
            this.FACULTY.Text = "FACULTY";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.AccessibleDescription = "";
            this.Button_Minimize.AccessibleName = "";
            this.Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Button_Minimize.Image")));
            this.Button_Minimize.ImageActive = null;
            this.Button_Minimize.Location = new System.Drawing.Point(822, 0);
            this.Button_Minimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(66, 48);
            this.Button_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Minimize.TabIndex = 17;
            this.Button_Minimize.TabStop = false;
            this.Button_Minimize.Zoom = 10;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Button_Exit.Image")));
            this.Button_Exit.ImageActive = null;
            this.Button_Exit.Location = new System.Drawing.Point(880, 0);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(62, 48);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Exit.TabIndex = 16;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Zoom = 10;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.ActiveBorderThickness = 1;
            this.Reset_Button.ActiveCornerRadius = 20;
            this.Reset_Button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Reset_Button.ActiveForecolor = System.Drawing.Color.White;
            this.Reset_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Reset_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Reset_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reset_Button.BackgroundImage")));
            this.Reset_Button.ButtonText = "Reset";
            this.Reset_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Reset_Button.IdleBorderThickness = 1;
            this.Reset_Button.IdleCornerRadius = 20;
            this.Reset_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Reset_Button.IdleForecolor = System.Drawing.Color.DimGray;
            this.Reset_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Reset_Button.Location = new System.Drawing.Point(477, 635);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(201, 63);
            this.Reset_Button.TabIndex = 21;
            this.Reset_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.ActiveBorderThickness = 1;
            this.Login_Button.ActiveCornerRadius = 20;
            this.Login_Button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Login_Button.ActiveForecolor = System.Drawing.Color.White;
            this.Login_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Login_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Login_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_Button.BackgroundImage")));
            this.Login_Button.ButtonText = "Login";
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Login_Button.IdleBorderThickness = 1;
            this.Login_Button.IdleCornerRadius = 20;
            this.Login_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Login_Button.IdleForecolor = System.Drawing.Color.DimGray;
            this.Login_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Login_Button.Location = new System.Drawing.Point(720, 637);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(190, 63);
            this.Login_Button.TabIndex = 20;
            this.Login_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(468, 115);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(311, 46);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Reset Password";
            // 
            // c_pass
            // 
            this.c_pass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.c_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.c_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.c_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c_pass.HintForeColor = System.Drawing.Color.Empty;
            this.c_pass.HintText = "";
            this.c_pass.isPassword = true;
            this.c_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.c_pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.c_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.c_pass.LineThickness = 2;
            this.c_pass.Location = new System.Drawing.Point(489, 529);
            this.c_pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.c_pass.Name = "c_pass";
            this.c_pass.Size = new System.Drawing.Size(340, 51);
            this.c_pass.TabIndex = 19;
            this.c_pass.Text = "Password";
            this.c_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User_ID
            // 
            this.User_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.User_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.User_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_ID.HintForeColor = System.Drawing.Color.Empty;
            this.User_ID.HintText = "";
            this.User_ID.isPassword = false;
            this.User_ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.User_ID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.User_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.User_ID.LineThickness = 2;
            this.User_ID.Location = new System.Drawing.Point(484, 266);
            this.User_ID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(340, 51);
            this.User_ID.TabIndex = 18;
            this.User_ID.Text = "Username";
            this.User_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.HintForeColor = System.Drawing.Color.Empty;
            this.pass.HintText = "";
            this.pass.isPassword = true;
            this.pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.pass.LineThickness = 2;
            this.pass.Location = new System.Drawing.Point(488, 445);
            this.pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(340, 51);
            this.pass.TabIndex = 22;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // resetcode
            // 
            this.resetcode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resetcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.resetcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetcode.HintForeColor = System.Drawing.Color.Empty;
            this.resetcode.HintText = "";
            this.resetcode.isPassword = false;
            this.resetcode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.resetcode.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.resetcode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.resetcode.LineThickness = 2;
            this.resetcode.Location = new System.Drawing.Point(486, 358);
            this.resetcode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resetcode.Name = "resetcode";
            this.resetcode.Size = new System.Drawing.Size(340, 51);
            this.resetcode.TabIndex = 23;
            this.resetcode.Text = "Reset Code";
            this.resetcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Resetpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 769);
            this.Controls.Add(this.resetcode);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Button_Minimize);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.c_pass);
            this.Controls.Add(this.User_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Resetpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Resetpwd_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel FACULTY;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Button_Minimize;
        private Bunifu.Framework.UI.BunifuImageButton Button_Exit;
        private Bunifu.Framework.UI.BunifuThinButton2 Reset_Button;
        private Bunifu.Framework.UI.BunifuThinButton2 Login_Button;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox c_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_ID;
        private System.Windows.Forms.Timer Fade_Timer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resetcode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass;
    }
}