namespace BankProject
{
    partial class RegisterationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            txtPhoneNum = new TextBox();
            txtCardNum = new TextBox();
            txtCardHoldName = new TextBox();
            txtEXPdate = new TextBox();
            txtCCV = new TextBox();
            label9 = new Label();
            btnSave = new Button();
            linkLabel1 = new LinkLabel();
            AccountTypeBox = new ComboBox();
            label10 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 151);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 92);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 207);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 372);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 4;
            label5.Text = "Card Number:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(349, 371);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 5;
            label6.Text = "Exp. Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 457);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 6;
            label7.Text = "Cardholder name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(381, 456);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 7;
            label8.Text = "CCV:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 28);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(152, 27);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 27);
            txtName.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(157, 208);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(152, 27);
            txtPhoneNum.TabIndex = 11;
            // 
            // txtCardNum
            // 
            txtCardNum.Location = new Point(132, 373);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.Size = new Size(193, 27);
            txtCardNum.TabIndex = 12;
            // 
            // txtCardHoldName
            // 
            txtCardHoldName.Location = new Point(156, 457);
            txtCardHoldName.Name = "txtCardHoldName";
            txtCardHoldName.Size = new Size(193, 27);
            txtCardHoldName.TabIndex = 13;
            // 
            // txtEXPdate
            // 
            txtEXPdate.Location = new Point(446, 372);
            txtEXPdate.Name = "txtEXPdate";
            txtEXPdate.Size = new Size(108, 27);
            txtEXPdate.TabIndex = 14;
            txtEXPdate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCCV
            // 
            txtCCV.Location = new Point(436, 457);
            txtCCV.Name = "txtCCV";
            txtCCV.Size = new Size(108, 27);
            txtCCV.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 319);
            label9.Name = "label9";
            label9.Size = new Size(140, 31);
            label9.TabIndex = 16;
            label9.Text = "Card Details";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(186, 520);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 52);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(231, 586);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AccountTypeBox
            // 
            AccountTypeBox.FormattingEnabled = true;
            AccountTypeBox.Items.AddRange(new object[] { "Saving ", "Checking" });
            AccountTypeBox.Location = new Point(138, 262);
            AccountTypeBox.Name = "AccountTypeBox";
            AccountTypeBox.Size = new Size(151, 28);
            AccountTypeBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 265);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 20;
            label10.Text = "Account Type: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCCV);
            panel1.Controls.Add(AccountTypeBox);
            panel1.Controls.Add(txtEXPdate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCardHoldName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCardNum);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhoneNum);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 638);
            panel1.TabIndex = 21;
            // 
            // RegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 661);
            Controls.Add(panel1);
            Name = "RegisterationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterationForm";
            Load += RegisterationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtPhoneNum;
        private TextBox txtCardNum;
        private TextBox txtCardHoldName;
        private TextBox txtEXPdate;
        private TextBox txtCCV;
        private Label label9;
        private Button btnSave;
        private LinkLabel linkLabel1;
        private ComboBox AccountTypeBox;
        private Label label10;
        private Panel panel1;
    }
}