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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 135);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 76);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 191);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone number: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 365);
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
            label6.Location = new Point(351, 364);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 5;
            label6.Text = "Exp. Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 450);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 6;
            label7.Text = "Cardholder name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(383, 449);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 7;
            label8.Text = "CCV:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(116, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(152, 27);
            txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 27);
            txtName.TabIndex = 10;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(153, 192);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(152, 27);
            txtPhoneNum.TabIndex = 11;
            // 
            // txtCardNum
            // 
            txtCardNum.Location = new Point(134, 366);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.Size = new Size(193, 27);
            txtCardNum.TabIndex = 12;
            // 
            // txtCardHoldName
            // 
            txtCardHoldName.Location = new Point(158, 450);
            txtCardHoldName.Name = "txtCardHoldName";
            txtCardHoldName.Size = new Size(193, 27);
            txtCardHoldName.TabIndex = 13;
            // 
            // txtEXPdate
            // 
            txtEXPdate.Location = new Point(448, 365);
            txtEXPdate.Name = "txtEXPdate";
            txtEXPdate.Size = new Size(108, 27);
            txtEXPdate.TabIndex = 14;
            // 
            // txtCCV
            // 
            txtCCV.Location = new Point(438, 450);
            txtCCV.Name = "txtCCV";
            txtCCV.Size = new Size(108, 27);
            txtCCV.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 312);
            label9.Name = "label9";
            label9.Size = new Size(140, 31);
            label9.TabIndex = 16;
            label9.Text = "Card Details";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 513);
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
            linkLabel1.Location = new Point(233, 579);
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
            AccountTypeBox.Items.AddRange(new object[] { "Saving ", "Chcking" });
            AccountTypeBox.Location = new Point(134, 246);
            AccountTypeBox.Name = "AccountTypeBox";
            AccountTypeBox.Size = new Size(151, 28);
            AccountTypeBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 249);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 20;
            label10.Text = "Account Type: ";
            // 
            // RegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 625);
            Controls.Add(label10);
            Controls.Add(AccountTypeBox);
            Controls.Add(linkLabel1);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(txtCCV);
            Controls.Add(txtEXPdate);
            Controls.Add(txtCardHoldName);
            Controls.Add(txtCardNum);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterationForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}