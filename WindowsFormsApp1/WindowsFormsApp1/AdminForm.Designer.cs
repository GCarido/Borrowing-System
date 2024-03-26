namespace WindowsFormsApp1
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.poslbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dashBoard = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.borrowingPage = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.inventoryAdmin = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.activityLogAdmin = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.accManagement = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarContainer = new System.Windows.Forms.Timer(this.components);
            this.adminFormPanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // poslbl
            // 
            this.poslbl.AutoSize = true;
            this.poslbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poslbl.ForeColor = System.Drawing.Color.Cyan;
            this.poslbl.Location = new System.Drawing.Point(1402, 76);
            this.poslbl.Name = "poslbl";
            this.poslbl.Size = new System.Drawing.Size(80, 18);
            this.poslbl.TabIndex = 15;
            this.poslbl.Text = "{position}";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.Cyan;
            this.idlbl.Location = new System.Drawing.Point(1435, 105);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(33, 18);
            this.idlbl.TabIndex = 14;
            this.idlbl.Text = "{id}";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.Cyan;
            this.userlbl.Location = new System.Drawing.Point(1419, 138);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(94, 18);
            this.userlbl.TabIndex = 13;
            this.userlbl.Text = "{username}";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1467, 11);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 15;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1515, 11);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.sidebar.Controls.Add(this.panel12);
            this.sidebar.Controls.Add(this.panel13);
            this.sidebar.Controls.Add(this.panel14);
            this.sidebar.Controls.Add(this.panel15);
            this.sidebar.Controls.Add(this.panel16);
            this.sidebar.Controls.Add(this.panel17);
            this.sidebar.Controls.Add(this.panel18);
            this.sidebar.Controls.Add(this.panel19);
            this.sidebar.Controls.Add(this.panel20);
            this.sidebar.Controls.Add(this.panel21);
            this.sidebar.Controls.Add(this.panel22);
            this.sidebar.Location = new System.Drawing.Point(0, 183);
            this.sidebar.MaximumSize = new System.Drawing.Size(274, 667);
            this.sidebar.MinimumSize = new System.Drawing.Size(76, 667);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(76, 667);
            this.sidebar.TabIndex = 15;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.menu);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(271, 62);
            this.panel12.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Menu";
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design__3_;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Location = new System.Drawing.Point(13, 11);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(48, 40);
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.home);
            this.panel13.Location = new System.Drawing.Point(3, 71);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(271, 53);
            this.panel13.TabIndex = 20;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__1_;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(-4, -11);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(283, 69);
            this.home.TabIndex = 1;
            this.home.Text = "         Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dashBoard);
            this.panel14.Location = new System.Drawing.Point(3, 130);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(271, 53);
            this.panel14.TabIndex = 21;
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.dashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.ForeColor = System.Drawing.Color.White;
            this.dashBoard.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__4_;
            this.dashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoard.Location = new System.Drawing.Point(-4, -10);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.dashBoard.Size = new System.Drawing.Size(283, 69);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.Text = "         Dashboard";
            this.dashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBoard.UseVisualStyleBackColor = false;
            this.dashBoard.Click += new System.EventHandler(this.dashBoard_Click_1);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.borrowingPage);
            this.panel15.Location = new System.Drawing.Point(3, 189);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(271, 53);
            this.panel15.TabIndex = 22;
            // 
            // borrowingPage
            // 
            this.borrowingPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.borrowingPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowingPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowingPage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingPage.ForeColor = System.Drawing.Color.White;
            this.borrowingPage.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__5_;
            this.borrowingPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowingPage.Location = new System.Drawing.Point(-4, -10);
            this.borrowingPage.Name = "borrowingPage";
            this.borrowingPage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.borrowingPage.Size = new System.Drawing.Size(283, 69);
            this.borrowingPage.TabIndex = 0;
            this.borrowingPage.Text = "         Borrowing Form";
            this.borrowingPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowingPage.UseVisualStyleBackColor = false;
            this.borrowingPage.Click += new System.EventHandler(this.borrowingPage_Click_1);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.inventoryAdmin);
            this.panel16.Location = new System.Drawing.Point(3, 248);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(271, 53);
            this.panel16.TabIndex = 23;
            // 
            // inventoryAdmin
            // 
            this.inventoryAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.inventoryAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAdmin.ForeColor = System.Drawing.Color.White;
            this.inventoryAdmin.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__6_;
            this.inventoryAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryAdmin.Location = new System.Drawing.Point(-4, -10);
            this.inventoryAdmin.Name = "inventoryAdmin";
            this.inventoryAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.inventoryAdmin.Size = new System.Drawing.Size(283, 69);
            this.inventoryAdmin.TabIndex = 0;
            this.inventoryAdmin.Text = "         Inventory";
            this.inventoryAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryAdmin.UseVisualStyleBackColor = false;
            this.inventoryAdmin.Click += new System.EventHandler(this.inventoryAdmin_Click_1);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.activityLogAdmin);
            this.panel17.Location = new System.Drawing.Point(3, 307);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(271, 53);
            this.panel17.TabIndex = 24;
            // 
            // activityLogAdmin
            // 
            this.activityLogAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.activityLogAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activityLogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityLogAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLogAdmin.ForeColor = System.Drawing.Color.White;
            this.activityLogAdmin.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__8_;
            this.activityLogAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityLogAdmin.Location = new System.Drawing.Point(-4, -10);
            this.activityLogAdmin.Name = "activityLogAdmin";
            this.activityLogAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.activityLogAdmin.Size = new System.Drawing.Size(283, 69);
            this.activityLogAdmin.TabIndex = 0;
            this.activityLogAdmin.Text = "         Transaction";
            this.activityLogAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activityLogAdmin.UseVisualStyleBackColor = false;
            this.activityLogAdmin.Click += new System.EventHandler(this.activityLogAdmin_Click_1);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.accManagement);
            this.panel18.Location = new System.Drawing.Point(3, 366);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(271, 92);
            this.panel18.TabIndex = 25;
            // 
            // accManagement
            // 
            this.accManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.accManagement.FlatAppearance.BorderSize = 0;
            this.accManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accManagement.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accManagement.ForeColor = System.Drawing.Color.White;
            this.accManagement.Image = global::WindowsFormsApp1.Properties.Resources.Logo__2_;
            this.accManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accManagement.Location = new System.Drawing.Point(13, 0);
            this.accManagement.Name = "accManagement";
            this.accManagement.Size = new System.Drawing.Size(266, 82);
            this.accManagement.TabIndex = 43;
            this.accManagement.Text = "           Account                            Management";
            this.accManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accManagement.UseVisualStyleBackColor = false;
            this.accManagement.Click += new System.EventHandler(this.accManagement_Click_1);
            // 
            // panel19
            // 
            this.panel19.Location = new System.Drawing.Point(3, 464);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(271, 19);
            this.panel19.TabIndex = 26;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.button4);
            this.panel20.Location = new System.Drawing.Point(3, 489);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(271, 53);
            this.panel20.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__9_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-4, -10);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(283, 69);
            this.button4.TabIndex = 0;
            this.button4.Text = "         Settings";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.button5);
            this.panel21.Location = new System.Drawing.Point(3, 548);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(271, 53);
            this.panel21.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__10_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-4, -10);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(283, 69);
            this.button5.TabIndex = 0;
            this.button5.Text = "         About";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.logoutBTN);
            this.panel22.Location = new System.Drawing.Point(3, 607);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(271, 53);
            this.panel22.TabIndex = 29;
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.logoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.Red;
            this.logoutBTN.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.logoutBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBTN.Location = new System.Drawing.Point(-4, -10);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logoutBTN.Size = new System.Drawing.Size(283, 69);
            this.logoutBTN.TabIndex = 0;
            this.logoutBTN.Text = "         LOGOUT";
            this.logoutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1329, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(1328, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1330, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Position:";
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.Enabled = true;
            this.sidebarContainer.Interval = 10;
            this.sidebarContainer.Tick += new System.EventHandler(this.sidebarContainer_Tick);
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminFormPanel.Location = new System.Drawing.Point(70, 183);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(1486, 667);
            this.adminFormPanel.TabIndex = 47;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login_layer_1;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.poslbl);
            this.Controls.Add(this.adminFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing System for CPE [ADMIN]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseUp);
            this.sidebar.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label poslbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button borrowingPage;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button inventoryAdmin;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button activityLogAdmin;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button accManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarContainer;
        private System.Windows.Forms.Panel adminFormPanel;
    }
}