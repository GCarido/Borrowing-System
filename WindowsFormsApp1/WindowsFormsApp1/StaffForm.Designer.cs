namespace WindowsFormsApp1
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.navbottom = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.poslbl = new System.Windows.Forms.Label();
            this.positionTxt = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.employeeITxt = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.userlbl = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashBoard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.borrowingForm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.staffInventory = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.staffTransaction = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.sidebarContainer = new System.Windows.Forms.Timer(this.components);
            this.staffFormPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbottom
            // 
            this.navbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.navbottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbottom.Location = new System.Drawing.Point(0, 0);
            this.navbottom.Name = "navbottom";
            this.navbottom.Size = new System.Drawing.Size(1556, 2);
            this.navbottom.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design__3_;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Location = new System.Drawing.Point(13, 11);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(48, 40);
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.Cyan;
            this.idlbl.Location = new System.Drawing.Point(1429, 102);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(33, 18);
            this.idlbl.TabIndex = 8;
            this.idlbl.Text = "{id}";
            // 
            // poslbl
            // 
            this.poslbl.AutoSize = true;
            this.poslbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.poslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poslbl.ForeColor = System.Drawing.Color.Cyan;
            this.poslbl.Location = new System.Drawing.Point(1401, 71);
            this.poslbl.Name = "poslbl";
            this.poslbl.Size = new System.Drawing.Size(80, 18);
            this.poslbl.TabIndex = 9;
            this.poslbl.Text = "{position}";
            // 
            // positionTxt
            // 
            this.positionTxt.AutoSize = true;
            this.positionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.positionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTxt.ForeColor = System.Drawing.Color.Yellow;
            this.positionTxt.Location = new System.Drawing.Point(1336, 71);
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.Size = new System.Drawing.Size(66, 18);
            this.positionTxt.TabIndex = 6;
            this.positionTxt.Text = "Position:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.Yellow;
            this.usernameTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameTxt.Location = new System.Drawing.Point(1336, 134);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(85, 18);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "Username: ";
            // 
            // employeeITxt
            // 
            this.employeeITxt.AutoSize = true;
            this.employeeITxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.employeeITxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeITxt.ForeColor = System.Drawing.Color.Yellow;
            this.employeeITxt.Location = new System.Drawing.Point(1335, 102);
            this.employeeITxt.Name = "employeeITxt";
            this.employeeITxt.Size = new System.Drawing.Size(96, 18);
            this.employeeITxt.TabIndex = 11;
            this.employeeITxt.Text = "Employee ID:";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1448, 8);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 13;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click_1);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1496, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.Cyan;
            this.userlbl.Location = new System.Drawing.Point(1414, 134);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(94, 18);
            this.userlbl.TabIndex = 14;
            this.userlbl.Text = "{username}";
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Location = new System.Drawing.Point(0, 183);
            this.sidebar.MaximumSize = new System.Drawing.Size(274, 667);
            this.sidebar.MinimumSize = new System.Drawing.Size(76, 667);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(76, 667);
            this.sidebar.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 62);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.home);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 53);
            this.panel2.TabIndex = 20;
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
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashBoard);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 53);
            this.panel3.TabIndex = 21;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.borrowingForm);
            this.panel4.Location = new System.Drawing.Point(3, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 53);
            this.panel4.TabIndex = 22;
            // 
            // borrowingForm
            // 
            this.borrowingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.borrowingForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowingForm.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingForm.ForeColor = System.Drawing.Color.White;
            this.borrowingForm.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__5_;
            this.borrowingForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowingForm.Location = new System.Drawing.Point(-4, -10);
            this.borrowingForm.Name = "borrowingForm";
            this.borrowingForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.borrowingForm.Size = new System.Drawing.Size(283, 69);
            this.borrowingForm.TabIndex = 0;
            this.borrowingForm.Text = "         Borrowing Form";
            this.borrowingForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowingForm.UseVisualStyleBackColor = false;
            this.borrowingForm.Click += new System.EventHandler(this.borrowingForm_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.staffInventory);
            this.panel5.Location = new System.Drawing.Point(3, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 53);
            this.panel5.TabIndex = 23;
            // 
            // staffInventory
            // 
            this.staffInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.staffInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffInventory.ForeColor = System.Drawing.Color.White;
            this.staffInventory.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__6_;
            this.staffInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffInventory.Location = new System.Drawing.Point(-4, -10);
            this.staffInventory.Name = "staffInventory";
            this.staffInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.staffInventory.Size = new System.Drawing.Size(283, 69);
            this.staffInventory.TabIndex = 0;
            this.staffInventory.Text = "         Inventory";
            this.staffInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffInventory.UseVisualStyleBackColor = false;
            this.staffInventory.Click += new System.EventHandler(this.staffInventory_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.staffTransaction);
            this.panel6.Location = new System.Drawing.Point(3, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 53);
            this.panel6.TabIndex = 24;
            // 
            // staffTransaction
            // 
            this.staffTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.staffTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffTransaction.ForeColor = System.Drawing.Color.White;
            this.staffTransaction.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__8_;
            this.staffTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffTransaction.Location = new System.Drawing.Point(-4, -10);
            this.staffTransaction.Name = "staffTransaction";
            this.staffTransaction.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.staffTransaction.Size = new System.Drawing.Size(283, 69);
            this.staffTransaction.TabIndex = 0;
            this.staffTransaction.Text = "         Transaction";
            this.staffTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffTransaction.UseVisualStyleBackColor = false;
            this.staffTransaction.Click += new System.EventHandler(this.staffTransaction_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 366);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 53);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 425);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 53);
            this.panel8.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button7);
            this.panel9.Location = new System.Drawing.Point(3, 484);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(271, 53);
            this.panel9.TabIndex = 27;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__9_;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-4, -10);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(283, 69);
            this.button7.TabIndex = 0;
            this.button7.Text = "         Settings";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button8);
            this.panel10.Location = new System.Drawing.Point(3, 543);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(271, 53);
            this.panel10.TabIndex = 28;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::WindowsFormsApp1.Properties.Resources.Untitled_design__10_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-4, -10);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(283, 69);
            this.button8.TabIndex = 0;
            this.button8.Text = "         About";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.logoutBTN);
            this.panel11.Location = new System.Drawing.Point(3, 602);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(271, 53);
            this.panel11.TabIndex = 29;
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
            // sidebarContainer
            // 
            this.sidebarContainer.Enabled = true;
            this.sidebarContainer.Interval = 10;
            this.sidebarContainer.Tick += new System.EventHandler(this.sidebarContainer_Tick);
            // 
            // staffFormPanel
            // 
            this.staffFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.staffFormPanel.Location = new System.Drawing.Point(70, 183);
            this.staffFormPanel.Name = "staffFormPanel";
            this.staffFormPanel.Size = new System.Drawing.Size(1486, 667);
            this.staffFormPanel.TabIndex = 16;
            this.staffFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffFormPanel_Paint_1);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login_layer_1;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.employeeITxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.navbottom);
            this.Controls.Add(this.poslbl);
            this.Controls.Add(this.positionTxt);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.staffFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing System for CPE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StaffForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel navbottom;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label poslbl;
        private System.Windows.Forms.Label positionTxt;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.Label employeeITxt;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button borrowingForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button staffInventory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button staffTransaction;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Panel staffFormPanel;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel7;
    }
}