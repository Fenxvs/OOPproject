namespace BankProject
{
    partial class Accounts
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            SliderBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panHome = new Panel();
            BtnHome = new Button();
            panCards = new Panel();
            btnCardDetails = new Button();
            panAccounts = new Panel();
            button2 = new Button();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            lblUsername = new Label();
            lblName = new Label();
            lblAccountType = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbName = new Label();
            lbluserNme = new Label();
            lblPhone = new Label();
            lblAccountNumber = new Label();
            lblCurrency = new Label();
            CardGroup = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            AccountGroup = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            SliderBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panHome.SuspendLayout();
            panCards.SuspendLayout();
            panAccounts.SuspendLayout();
            CardGroup.SuspendLayout();
            AccountGroup.SuspendLayout();
            SuspendLayout();
            // 
            // SliderBar
            // 
            SliderBar.BackColor = Color.FromArgb(50, 47, 45);
            SliderBar.Controls.Add(panel1);
            SliderBar.Controls.Add(panHome);
            SliderBar.Controls.Add(panCards);
            SliderBar.Controls.Add(panAccounts);
            SliderBar.Dock = DockStyle.Left;
            SliderBar.Location = new Point(0, 0);
            SliderBar.MaximumSize = new Size(278, 725);
            SliderBar.MinimumSize = new Size(83, 725);
            SliderBar.Name = "SliderBar";
            SliderBar.Size = new Size(278, 725);
            SliderBar.TabIndex = 1;
            SliderBar.Paint += SliderBar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 133);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(9, 38);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(58, 52);
            MenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // panHome
            // 
            panHome.Controls.Add(BtnHome);
            panHome.Location = new Point(3, 142);
            panHome.Name = "panHome";
            panHome.Size = new Size(348, 92);
            panHome.TabIndex = 8;
            // 
            // BtnHome
            // 
            BtnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.ForeColor = Color.LightGray;
            BtnHome.Image = (Image)resources.GetObject("BtnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(-3, -9);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(30, 0, 0, 0);
            BtnHome.Size = new Size(341, 125);
            BtnHome.TabIndex = 5;
            BtnHome.Text = "       Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // panCards
            // 
            panCards.Controls.Add(btnCardDetails);
            panCards.Location = new Point(3, 240);
            panCards.Name = "panCards";
            panCards.Size = new Size(392, 82);
            panCards.TabIndex = 9;
            // 
            // btnCardDetails
            // 
            btnCardDetails.FlatStyle = FlatStyle.Flat;
            btnCardDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCardDetails.ForeColor = SystemColors.ButtonHighlight;
            btnCardDetails.Image = (Image)resources.GetObject("btnCardDetails.Image");
            btnCardDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.Location = new Point(-3, -9);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(30, 0, 0, 0);
            btnCardDetails.Size = new Size(305, 100);
            btnCardDetails.TabIndex = 6;
            btnCardDetails.Text = "         Card Details";
            btnCardDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnCardDetails.UseVisualStyleBackColor = true;
            btnCardDetails.Click += btnCardDetails_Click;
            // 
            // panAccounts
            // 
            panAccounts.Controls.Add(button2);
            panAccounts.Location = new Point(3, 328);
            panAccounts.Name = "panAccounts";
            panAccounts.Size = new Size(437, 82);
            panAccounts.TabIndex = 10;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, -14);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(425, 108);
            button2.TabIndex = 7;
            button2.Text = "       Accounts";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Enabled = true;
            SliderBarTimer.Interval = 1;
            SliderBarTimer.Tick += SliderBar_Tick;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(50, 47, 45);
            lblUsername.Location = new Point(334, 43);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(378, 60);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Account Name :";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(50, 47, 45);
            lblName.Location = new Point(334, 198);
            lblName.Name = "lblName";
            lblName.Size = new Size(378, 60);
            lblName.TabIndex = 4;
            lblName.Text = "Phone Number :";
            // 
            // lblAccountType
            // 
            lblAccountType.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAccountType.ForeColor = Color.FromArgb(50, 47, 45);
            lblAccountType.Location = new Point(334, 368);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(378, 60);
            lblAccountType.TabIndex = 5;
            lblAccountType.Text = "Account Type :";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 47, 45);
            label6.Location = new Point(334, 453);
            label6.Name = "label6";
            label6.Size = new Size(378, 60);
            label6.TabIndex = 6;
            label6.Text = "Balance Currency :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 47, 45);
            label2.Location = new Point(334, 560);
            label2.Name = "label2";
            label2.Size = new Size(378, 60);
            label2.TabIndex = 12;
            label2.Text = "Card Type :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 47, 45);
            label3.Location = new Point(334, 119);
            label3.Name = "label3";
            label3.Size = new Size(378, 60);
            label3.TabIndex = 13;
            label3.Text = "Account Username :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 47, 45);
            label4.Location = new Point(334, 277);
            label4.Name = "label4";
            label4.Size = new Size(378, 60);
            label4.TabIndex = 16;
            label4.Text = "Account Number :";
            // 
            // lbName
            // 
            lbName.BackColor = Color.FromArgb(50, 47, 45);
            lbName.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(223, 211, 201);
            lbName.Location = new Point(596, 60);
            lbName.Name = "lbName";
            lbName.Size = new Size(374, 28);
            lbName.TabIndex = 17;
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbluserNme
            // 
            lbluserNme.BackColor = Color.FromArgb(50, 47, 45);
            lbluserNme.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            lbluserNme.ForeColor = Color.FromArgb(223, 211, 201);
            lbluserNme.Location = new Point(674, 135);
            lbluserNme.Name = "lbluserNme";
            lbluserNme.Size = new Size(348, 29);
            lbluserNme.TabIndex = 18;
            lbluserNme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.FromArgb(50, 47, 45);
            lblPhone.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(223, 211, 201);
            lblPhone.Location = new Point(622, 215);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(348, 28);
            lblPhone.TabIndex = 19;
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.FromArgb(50, 47, 45);
            lblAccountNumber.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            lblAccountNumber.ForeColor = Color.FromArgb(223, 211, 201);
            lblAccountNumber.Location = new Point(651, 297);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(390, 28);
            lblAccountNumber.TabIndex = 20;
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrency
            // 
            lblCurrency.BackColor = Color.FromArgb(50, 47, 45);
            lblCurrency.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            lblCurrency.ForeColor = Color.FromArgb(223, 211, 201);
            lblCurrency.Location = new Point(674, 473);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(389, 31);
            lblCurrency.TabIndex = 22;
            lblCurrency.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardGroup
            // 
            CardGroup.Controls.Add(checkBox3);
            CardGroup.Controls.Add(checkBox4);
            CardGroup.FlatStyle = FlatStyle.Flat;
            CardGroup.Location = new Point(543, 541);
            CardGroup.Name = "CardGroup";
            CardGroup.Size = new Size(545, 79);
            CardGroup.TabIndex = 23;
            CardGroup.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = Color.FromArgb(50, 47, 45);
            checkBox3.Location = new Point(17, 24);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(93, 42);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Visa";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox4.ForeColor = Color.FromArgb(50, 47, 45);
            checkBox4.Location = new Point(213, 25);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(203, 42);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Master Card ";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            // 
            // AccountGroup
            // 
            AccountGroup.Controls.Add(checkBox2);
            AccountGroup.Controls.Add(checkBox1);
            AccountGroup.FlatStyle = FlatStyle.Popup;
            AccountGroup.Location = new Point(596, 354);
            AccountGroup.Name = "AccountGroup";
            AccountGroup.Size = new Size(590, 74);
            AccountGroup.TabIndex = 0;
            AccountGroup.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(50, 47, 45);
            checkBox2.Location = new Point(324, 27);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(266, 42);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Checking Account";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(50, 47, 45);
            checkBox1.Location = new Point(38, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(239, 42);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Saving account ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 201);
            ClientSize = new Size(1237, 728);
            Controls.Add(AccountGroup);
            Controls.Add(CardGroup);
            Controls.Add(lblCurrency);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblPhone);
            Controls.Add(lbluserNme);
            Controls.Add(lbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(lblAccountType);
            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(SliderBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            Load += Accounts_Load;
            SliderBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panHome.ResumeLayout(false);
            panCards.ResumeLayout(false);
            panAccounts.ResumeLayout(false);
            CardGroup.ResumeLayout(false);
            CardGroup.PerformLayout();
            AccountGroup.ResumeLayout(false);
            AccountGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SliderBar;
        private Panel panel1;
        private Label label1;
        private PictureBox MenuBtn;
        private Button BtnHome;
        private Button btnCardDetails;
        private Button button2;
        private Panel panHome;
        private Panel panCards;
        private Panel panAccounts;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Label lblUsername;
        private Label lblName;
        private Label LblBalance;
        private Label lblAccountType;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbName;
        private Label lbluserNme;
        private Label lblPhone;
        private Label lblAccountNumber;
        private Label label10;
        private Label lblCurrency;
        private GroupBox CardGroup;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox AccountGroup;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}