namespace BankProject
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            slidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panel3 = new Panel();
            BtnHome = new Button();
            panel4 = new Panel();
            btnTransactions = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            lbltransac = new Label();
            ListBoxTransactionHis = new ListBox();
            btnDeposit = new Button();
            btnTransfer = new Button();
            txtCurrentBalance = new TextBox();
            btnWithdrawl = new Button();
            m4mohem = new Label();
            lblCurrentBalance = new Label();
            slidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // slidebar
            // 
            slidebar.BackColor = Color.DarkRed;
            slidebar.Controls.Add(panel1);
            slidebar.Controls.Add(panel3);
            slidebar.Controls.Add(panel4);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel6);
            slidebar.Controls.Add(panel7);
            slidebar.Controls.Add(panel8);
            slidebar.Controls.Add(panel9);
            slidebar.Controls.Add(panel2);
            slidebar.Controls.Add(panel10);
            slidebar.Dock = DockStyle.Left;
            slidebar.Location = new Point(0, 0);
            slidebar.MaximumSize = new Size(278, 726);
            slidebar.MinimumSize = new Size(83, 726);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(278, 726);
            slidebar.TabIndex = 2;
            slidebar.Paint += slidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 125);
            panel1.TabIndex = 2;
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
            // panel3
            // 
            panel3.Controls.Add(BtnHome);
            panel3.Location = new Point(3, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 60);
            panel3.TabIndex = 5;
            // 
            // BtnHome
            // 
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnHome.ForeColor = SystemColors.ButtonHighlight;
            BtnHome.Image = (Image)resources.GetObject("BtnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(-10, -14);
            BtnHome.Name = "BtnHome";
            BtnHome.Padding = new Padding(30, 0, 0, 0);
            BtnHome.Size = new Size(296, 84);
            BtnHome.TabIndex = 4;
            BtnHome.Text = "         Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTransactions);
            panel4.Location = new Point(3, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 60);
            panel4.TabIndex = 6;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = SystemColors.ButtonHighlight;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(-10, -14);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Padding = new Padding(30, 0, 0, 0);
            btnTransactions.Size = new Size(296, 84);
            btnTransactions.TabIndex = 4;
            btnTransactions.Text = "         Transactions";
            btnTransactions.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactions.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 266);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 60);
            panel5.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-10, -14);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(296, 84);
            button4.TabIndex = 4;
            button4.Text = "         Accounts ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Location = new Point(3, 332);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 60);
            panel6.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -14);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(296, 84);
            button1.TabIndex = 4;
            button1.Text = "         Card Details";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 398);
            panel7.Name = "panel7";
            panel7.Size = new Size(275, 60);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 464);
            panel8.Name = "panel8";
            panel8.Size = new Size(275, 60);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 530);
            panel9.Name = "panel9";
            panel9.Size = new Size(275, 35);
            panel9.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 571);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 60);
            panel2.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 637);
            panel10.Name = "panel10";
            panel10.Size = new Size(275, 60);
            panel10.TabIndex = 5;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Interval = 1;
            // 
            // lbltransac
            // 
            lbltransac.AutoSize = true;
            lbltransac.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltransac.Location = new Point(637, 21);
            lbltransac.Name = "lbltransac";
            lbltransac.Size = new Size(179, 38);
            lbltransac.TabIndex = 3;
            lbltransac.Text = "Transactions";
            // 
            // ListBoxTransactionHis
            // 
            ListBoxTransactionHis.BackColor = Color.Black;
            ListBoxTransactionHis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ListBoxTransactionHis.ForeColor = Color.Transparent;
            ListBoxTransactionHis.FormattingEnabled = true;
            ListBoxTransactionHis.ItemHeight = 28;
            ListBoxTransactionHis.Location = new Point(295, 78);
            ListBoxTransactionHis.Name = "ListBoxTransactionHis";
            ListBoxTransactionHis.Size = new Size(930, 284);
            ListBoxTransactionHis.TabIndex = 4;
            // 
            // btnDeposit
            // 
            btnDeposit.FlatStyle = FlatStyle.Popup;
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(295, 605);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(231, 57);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.FlatStyle = FlatStyle.Popup;
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(611, 605);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(231, 57);
            btnTransfer.TabIndex = 6;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCurrentBalance.Location = new Point(565, 503);
            txtCurrentBalance.Multiline = true;
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.Size = new Size(292, 49);
            txtCurrentBalance.TabIndex = 7;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.FlatStyle = FlatStyle.Popup;
            btnWithdrawl.ForeColor = Color.White;
            btnWithdrawl.Location = new Point(949, 605);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(231, 57);
            btnWithdrawl.TabIndex = 8;
            btnWithdrawl.Text = "Withdrawl";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // m4mohem
            // 
            m4mohem.AutoSize = true;
            m4mohem.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            m4mohem.Location = new Point(462, 398);
            m4mohem.Name = "m4mohem";
            m4mohem.Size = new Size(422, 38);
            m4mohem.TabIndex = 9;
            m4mohem.Text = "Current Balance:                   L.E.";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblCurrentBalance.Location = new Point(704, 398);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(77, 38);
            lblCurrentBalance.TabIndex = 10;
            lblCurrentBalance.Text = "1000";
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 728);
            Controls.Add(lblCurrentBalance);
            Controls.Add(m4mohem);
            Controls.Add(btnWithdrawl);
            Controls.Add(txtCurrentBalance);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(ListBoxTransactionHis);
            Controls.Add(lbltransac);
            Controls.Add(slidebar);
            MaximizeBox = false;
            Name = "TransactionsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transactions";
            Load += Transactions_Load;
            slidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel slidebar;
        private Panel panel1;
        private Label label1;
        private PictureBox MenuBtn;
        private Panel panel3;
        private Button BtnHome;
        private Panel panel4;
        private Button btnTransactions;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button1;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel2;
        private Panel panel10;
        private System.Windows.Forms.Timer SliderBarTimer;
        private Label lbltransac;
        private ListBox ListBoxTransactionHis;
        private Button btnDeposit;
        private Button btnTransfer;
        private TextBox txtCurrentBalance;
        private Button btnWithdrawl;
        private Label m4mohem;
        private Label lblCurrentBalance;
    }
}