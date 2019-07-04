namespace DashBoard1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Button_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.LSide_Panel = new System.Windows.Forms.Panel();
            this.LeftPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UserNameLable1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Side_CP_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Side_MSG_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Side_Home_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Fade_Timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Available = new Bunifu.Framework.UI.BunifuThinButton2();
            this.User_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            this.LSide_Panel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.Button_Minimize.Location = new System.Drawing.Point(1274, 12);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(44, 31);
            this.Button_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Minimize.TabIndex = 5;
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
            this.Button_Exit.Location = new System.Drawing.Point(1315, 12);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(41, 31);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Zoom = 10;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // LSide_Panel
            // 
            this.LSide_Panel.BackColor = System.Drawing.Color.Transparent;
            this.LSide_Panel.Controls.Add(this.LeftPanel);
            this.LSide_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LSide_Panel.Location = new System.Drawing.Point(0, 0);
            this.LSide_Panel.Name = "LSide_Panel";
            this.LSide_Panel.Size = new System.Drawing.Size(239, 768);
            this.LSide_Panel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.Controls.Add(this.UserNameLable1);
            this.LeftPanel.Controls.Add(this.Side_CP_Button);
            this.LeftPanel.Controls.Add(this.Side_MSG_Button);
            this.LeftPanel.Controls.Add(this.Side_Home_Button);
            this.LeftPanel.Controls.Add(this.bunifuCustomLabel1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.LeftPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.LeftPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.LeftPanel.GradientTopRight = System.Drawing.Color.Black;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Quality = 10;
            this.LeftPanel.Size = new System.Drawing.Size(239, 768);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // UserNameLable1
            // 
            this.UserNameLable1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLable1.AutoSize = true;
            this.UserNameLable1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLable1.ForeColor = System.Drawing.Color.White;
            this.UserNameLable1.Location = new System.Drawing.Point(92, 130);
            this.UserNameLable1.Name = "UserNameLable1";
            this.UserNameLable1.Size = new System.Drawing.Size(53, 38);
            this.UserNameLable1.TabIndex = 8;
            this.UserNameLable1.Text = "....";
            // 
            // Side_CP_Button
            // 
            this.Side_CP_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_CP_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Side_CP_Button.BackColor = System.Drawing.Color.Transparent;
            this.Side_CP_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Side_CP_Button.BorderRadius = 0;
            this.Side_CP_Button.ButtonText = "Change Password";
            this.Side_CP_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Side_CP_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Side_CP_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_CP_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Side_CP_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Side_CP_Button.Iconimage = ((System.Drawing.Image)(resources.GetObject("Side_CP_Button.Iconimage")));
            this.Side_CP_Button.Iconimage_right = null;
            this.Side_CP_Button.Iconimage_right_Selected = null;
            this.Side_CP_Button.Iconimage_Selected = null;
            this.Side_CP_Button.IconMarginLeft = 0;
            this.Side_CP_Button.IconMarginRight = 0;
            this.Side_CP_Button.IconRightVisible = true;
            this.Side_CP_Button.IconRightZoom = 0D;
            this.Side_CP_Button.IconVisible = false;
            this.Side_CP_Button.IconZoom = 90D;
            this.Side_CP_Button.IsTab = true;
            this.Side_CP_Button.Location = new System.Drawing.Point(0, 594);
            this.Side_CP_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Side_CP_Button.Name = "Side_CP_Button";
            this.Side_CP_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Side_CP_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_CP_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Side_CP_Button.selected = false;
            this.Side_CP_Button.Size = new System.Drawing.Size(239, 69);
            this.Side_CP_Button.TabIndex = 6;
            this.Side_CP_Button.Text = "Change Password";
            this.Side_CP_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Side_CP_Button.Textcolor = System.Drawing.Color.White;
            this.Side_CP_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_CP_Button.Click += new System.EventHandler(this.Side_CP_Button_Click);
            // 
            // Side_MSG_Button
            // 
            this.Side_MSG_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_MSG_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Side_MSG_Button.BackColor = System.Drawing.Color.Transparent;
            this.Side_MSG_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Side_MSG_Button.BorderRadius = 0;
            this.Side_MSG_Button.ButtonText = "Message";
            this.Side_MSG_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Side_MSG_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Side_MSG_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_MSG_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Side_MSG_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Side_MSG_Button.Iconimage = ((System.Drawing.Image)(resources.GetObject("Side_MSG_Button.Iconimage")));
            this.Side_MSG_Button.Iconimage_right = null;
            this.Side_MSG_Button.Iconimage_right_Selected = null;
            this.Side_MSG_Button.Iconimage_Selected = null;
            this.Side_MSG_Button.IconMarginLeft = 0;
            this.Side_MSG_Button.IconMarginRight = 0;
            this.Side_MSG_Button.IconRightVisible = true;
            this.Side_MSG_Button.IconRightZoom = 0D;
            this.Side_MSG_Button.IconVisible = false;
            this.Side_MSG_Button.IconZoom = 90D;
            this.Side_MSG_Button.IsTab = true;
            this.Side_MSG_Button.Location = new System.Drawing.Point(0, 414);
            this.Side_MSG_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Side_MSG_Button.Name = "Side_MSG_Button";
            this.Side_MSG_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Side_MSG_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_MSG_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Side_MSG_Button.selected = false;
            this.Side_MSG_Button.Size = new System.Drawing.Size(239, 69);
            this.Side_MSG_Button.TabIndex = 7;
            this.Side_MSG_Button.Text = "Message";
            this.Side_MSG_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Side_MSG_Button.Textcolor = System.Drawing.Color.White;
            this.Side_MSG_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_MSG_Button.Click += new System.EventHandler(this.Side_MSG_Button_Click);
            // 
            // Side_Home_Button
            // 
            this.Side_Home_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_Home_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Side_Home_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Side_Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Side_Home_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Side_Home_Button.BorderRadius = 0;
            this.Side_Home_Button.ButtonText = "Home";
            this.Side_Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Side_Home_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Side_Home_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Side_Home_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Side_Home_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Side_Home_Button.Iconimage = ((System.Drawing.Image)(resources.GetObject("Side_Home_Button.Iconimage")));
            this.Side_Home_Button.Iconimage_right = null;
            this.Side_Home_Button.Iconimage_right_Selected = null;
            this.Side_Home_Button.Iconimage_Selected = null;
            this.Side_Home_Button.IconMarginLeft = 0;
            this.Side_Home_Button.IconMarginRight = 0;
            this.Side_Home_Button.IconRightVisible = true;
            this.Side_Home_Button.IconRightZoom = 0D;
            this.Side_Home_Button.IconVisible = false;
            this.Side_Home_Button.IconZoom = 90D;
            this.Side_Home_Button.IsTab = true;
            this.Side_Home_Button.Location = new System.Drawing.Point(0, 231);
            this.Side_Home_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Side_Home_Button.Name = "Side_Home_Button";
            this.Side_Home_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Side_Home_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.Side_Home_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Side_Home_Button.selected = false;
            this.Side_Home_Button.Size = new System.Drawing.Size(239, 69);
            this.Side_Home_Button.TabIndex = 5;
            this.Side_Home_Button.Text = "Home";
            this.Side_Home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Side_Home_Button.Textcolor = System.Drawing.Color.White;
            this.Side_Home_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 43);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 52);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Welcome";
            // 
            // Fade_Timer
            // 
            this.Fade_Timer.Tick += new System.EventHandler(this.Fade_Timer_Tick);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(597, 140);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(739, 52);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "Click on the profile to update status";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(527, 521);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(214, 55);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Location";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Update";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.DimGray;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(960, 504);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(137, 58);
            this.bunifuThinButton23.TabIndex = 19;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Busy";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(735, 301);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(174, 81);
            this.bunifuThinButton21.TabIndex = 20;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Meeting";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(946, 301);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(174, 81);
            this.bunifuThinButton22.TabIndex = 21;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Available
            // 
            this.Available.ActiveBorderThickness = 1;
            this.Available.ActiveCornerRadius = 20;
            this.Available.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Available.ActiveForecolor = System.Drawing.Color.White;
            this.Available.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.Available.BackColor = System.Drawing.Color.White;
            this.Available.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Available.BackgroundImage")));
            this.Available.ButtonText = "Available";
            this.Available.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available.ForeColor = System.Drawing.Color.SeaGreen;
            this.Available.IdleBorderThickness = 1;
            this.Available.IdleCornerRadius = 20;
            this.Available.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Available.IdleForecolor = System.Drawing.Color.DimGray;
            this.Available.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(144)))));
            this.Available.Location = new System.Drawing.Point(512, 301);
            this.Available.Margin = new System.Windows.Forms.Padding(5);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(174, 81);
            this.Available.TabIndex = 22;
            this.Available.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Available.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // User_ID
            // 
            this.User_ID.BackColor = System.Drawing.Color.White;
            this.User_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_ID.HintForeColor = System.Drawing.Color.Empty;
            this.User_ID.HintText = "";
            this.User_ID.isPassword = false;
            this.User_ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(104)))), ((int)(((byte)(184)))));
            this.User_ID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.User_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.User_ID.LineThickness = 2;
            this.User_ID.Location = new System.Drawing.Point(768, 521);
            this.User_ID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(126, 41);
            this.User_ID.TabIndex = 25;
            this.User_ID.Text = "MB 253";
            this.User_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Button_Minimize);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.LSide_Panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            this.LSide_Panel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Button_Minimize;
        private Bunifu.Framework.UI.BunifuImageButton Button_Exit;
        private System.Windows.Forms.Panel LSide_Panel;
        private Bunifu.Framework.UI.BunifuGradientPanel LeftPanel;
        private System.Windows.Forms.Timer Fade_Timer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton Side_Home_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Side_MSG_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Side_CP_Button;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuCustomLabel UserNameLable1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 Available;
        private Bunifu.Framework.UI.BunifuMaterialTextbox User_ID;
    }
}

