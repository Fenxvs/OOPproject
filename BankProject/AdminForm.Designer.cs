namespace BankProject
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 278);
            label1.Name = "label1";
            label1.Size = new Size(777, 95);
            label1.TabIndex = 1;
            label1.Text = "YOU ARE AN ADMIN";
            label1.Click += label1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 726);
            Controls.Add(label1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}