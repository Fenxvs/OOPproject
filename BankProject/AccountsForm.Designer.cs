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
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label4 = new Label();
            lblAccountName = new Label();
            lblAccountUsername = new Label();
            lblPhone = new Label();
            lblAccountNumber = new Label();
            label11 = new Label();
            SliderBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panHome.SuspendLayout();
            panCards.SuspendLayout();
            panAccounts.SuspendLayout();
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
            BtnHome.Location = new Point(-12, -9);
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
            btnCardDetails.Location = new Point(-12, -9);
            btnCardDetails.Name = "btnCardDetails";
            btnCardDetails.Padding = new Padding(30, 0, 0, 0);
            btnCardDetails.Size = new Size(305, 100);
            btnCardDetails.TabIndex = 6;
            btnCardDetails.Text = "       Card Details";
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
            button2.Location = new Point(-13, -14);
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
            lblUsername.Location = new Point(381, 52);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(396, 76);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Account Name :";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(50, 47, 45);
            lblName.Location = new Point(381, 207);
            lblName.Name = "lblName";
            lblName.Size = new Size(396, 76);
            lblName.TabIndex = 4;
            lblName.Text = "Phone Number :";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(50, 47, 45);
            label5.Location = new Point(381, 377);
            label5.Name = "label5";
            label5.Size = new Size(396, 76);
            label5.TabIndex = 5;
            label5.Text = "Account Type :";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(50, 47, 45);
            label6.Location = new Point(381, 457);
            label6.Name = "label6";
            label6.Size = new Size(396, 76);
            label6.TabIndex = 6;
            label6.Text = "Balance Currency :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(675, 387);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 35);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Saving Account";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(920, 387);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(222, 35);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Checking Account";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 47, 45);
            label2.Location = new Point(381, 537);
            label2.Name = "label2";
            label2.Size = new Size(396, 76);
            label2.TabIndex = 12;
            label2.Text = "Card Type :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(50, 47, 45);
            label3.Location = new Point(381, 128);
            label3.Name = "label3";
            label3.Size = new Size(396, 76);
            label3.TabIndex = 13;
            label3.Text = "Account Username :";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(687, 547);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(79, 35);
            checkBox5.TabIndex = 14;
            checkBox5.Text = "Visa";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(920, 547);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(157, 35);
            checkBox6.TabIndex = 15;
            checkBox6.Text = "MasterCard";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(50, 47, 45);
            label4.Location = new Point(381, 286);
            label4.Name = "label4";
            label4.Size = new Size(396, 76);
            label4.TabIndex = 16;
            label4.Text = "Account Number :";
            // 
            // lblAccountName
            // 
            lblAccountName.BackColor = Color.FromArgb(50, 47, 45);
            lblAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountName.ForeColor = Color.FromArgb(223, 211, 201);
            lblAccountName.Location = new Point(643, 69);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(392, 44);
            lblAccountName.TabIndex = 17;
            lblAccountName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccountUsername
            // 
            lblAccountUsername.BackColor = Color.FromArgb(50, 47, 45);
            lblAccountUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountUsername.ForeColor = Color.FromArgb(223, 211, 201);
            lblAccountUsername.Location = new Point(721, 144);
            lblAccountUsername.Name = "lblAccountUsername";
            lblAccountUsername.Size = new Size(366, 45);
            lblAccountUsername.TabIndex = 18;
            lblAccountUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.FromArgb(50, 47, 45);
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(223, 211, 201);
            lblPhone.Location = new Point(669, 224);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(366, 44);
            lblPhone.TabIndex = 19;
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.BackColor = Color.FromArgb(50, 47, 45);
            lblAccountNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountNumber.ForeColor = Color.FromArgb(223, 211, 201);
            lblAccountNumber.Location = new Point(698, 306);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(408, 44);
            lblAccountNumber.TabIndex = 20;
            lblAccountNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(50, 47, 45);
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(223, 211, 201);
            label11.Location = new Point(699, 471);
            label11.Name = "label11";
            label11.Size = new Size(407, 47);
            label11.TabIndex = 22;
            label11.Text = "EGP";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 201);
            ClientSize = new Size(1237, 728);
            Controls.Add(label11);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblPhone);
            Controls.Add(lblAccountUsername);
            Controls.Add(lblAccountName);
            Controls.Add(label4);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private Label label3;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label4;
        private Label lblAccountName;
        private Label lblAccountUsername;
        private Label lblPhone;
        private Label lblAccountNumber;
        private Label label11;
    }
}