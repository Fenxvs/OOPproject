namespace BankProject
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            slidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            btnLogOut = new Button();
            SliderBarTimer = new System.Windows.Forms.Timer(components);
            slidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
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
            slidebar.Size = new Size(83, 726);
            slidebar.TabIndex = 1;
            slidebar.Paint += flowLayoutPanel1_Paint;
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
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 60);
            panel3.TabIndex = 5;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, -14);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(296, 84);
            button2.TabIndex = 4;
            button2.Text = "         Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 60);
            panel4.TabIndex = 6;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-10, -14);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(296, 84);
            button3.TabIndex = 4;
            button3.Text = "         Transactions";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
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
            button4.Text = "         Contacts";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            button1.Click += button1_Click;
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
            panel10.Controls.Add(btnLogOut);
            panel10.Location = new Point(3, 637);
            panel10.Name = "panel10";
            panel10.Size = new Size(275, 60);
            panel10.TabIndex = 5;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(-10, -14);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(30, 0, 0, 0);
            btnLogOut.Size = new Size(296, 84);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "         Log out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // SliderBarTimer
            // 
            SliderBarTimer.Interval = 1;
            SliderBarTimer.Tick += SliderBar_Tick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1237, 728);
            Controls.Add(slidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            slidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel slidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Button btnLogOut;
        private PictureBox MenuBtn;
        private System.Windows.Forms.Timer SliderBarTimer;
    }
}