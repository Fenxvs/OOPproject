using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization;

namespace BankProject
{
    public partial class UserForm : Form
    {
        Client Client1 = new Client("Ahmed", Gender.Male, "Ahmed", "Ahmed12345");
        public UserForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            slidebar.BackColor = ColorTranslator.FromHtml("#322f2d");
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            ListBoxTransactionHis.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            btnDeposit.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnTransfer.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnWithdrawl.BackColor = ColorTranslator.FromHtml("#322f2d");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardDetails cards = new CardDetails();
            cards.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult LogOut = MessageBox.Show("Are you sure you want to log out ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (LogOut == DialogResult.Yes)
            {
                Application.OpenForms[0].Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Log out unsuccesful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        bool SliderBarExpand;

        private void SliderBar_Tick(object sender, EventArgs e)
        {
            if (SliderBarExpand) // checks if the sidebar is expanded
            {
                slidebar.Width -= 10; // decreases the width by 10px each timer click 

                if (slidebar.Width == slidebar.MinimumSize.Width) // law el sidebar reached min width 
                {
                    SliderBarExpand = false; // keda 5alas el sidebar collapsed 
                    SliderBarTimer.Stop();   // stops the timer bema 2n el animation 5elset 
                }
            }
            else
            {
                slidebar.Width += 10; // Expands the sidebar 
                if (slidebar.Width == slidebar.MaximumSize.Width) // law el sidebar reached max width 
                {
                    SliderBarExpand = true; // keda 5alas el sidebar expanded
                    SliderBarTimer.Stop();  // stops the timer bema 2n el animation 5elset 
                }
            }
        }

        private void SideBar(object sender, PaintEventArgs e)
        {

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SliderBarTimer.Start(); // Starts the timer of the animation
        }



        private void BlnceHistotry_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentBalance.Text))
            {
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal Deposit = Convert.ToDecimal(txtCurrentBalance.Text);
            decimal Balance = Convert.ToDecimal(lblCurrentBalance.Text);

            if (Deposit <= 0)
            {
                MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult Dr = MessageBox.Show($"Are you sure you want to deposit {Deposit} L.E. ?", "Confirmation", MessageBoxButtons.YesNo);


            if (Dr == DialogResult.Yes)
            {
                Balance += Deposit;
            }
            else
            {
                MessageBox.Show("Deposit unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            lblCurrentBalance.Text = Balance.ToString();
            txtCurrentBalance.Text = null;

            if (Client1.ClientAccount != null)
            {
                var history = Client1.ClientAccount.GetHistory();

            }
            else
            {

                ListBoxTransactionHis.Items.Add("No account information available");
            }

        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentBalance.Text))
            {
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal withdrawl = Convert.ToDecimal(txtCurrentBalance.Text);
            decimal Balance = Convert.ToDecimal(lblCurrentBalance.Text);

            if (withdrawl <= 0)
            {
                MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (withdrawl > Balance)
            {
                MessageBox.Show("Insuffieient funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult Dr = MessageBox.Show($"Are you sure you want to withdrawl {withdrawl} ?", "Confirmation", MessageBoxButtons.YesNo);

            if (Dr == DialogResult.Yes)
            {
                Balance -= withdrawl;

            }
            else
            {
                MessageBox.Show("Withdrawl unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblCurrentBalance.Text = Balance.ToString();
            txtCurrentBalance.Text = null;

            ListBoxTransactionHis.Items.Add($"[{DateTime.Now:MM/dd/yyyy HH:mm}] Withdrawal: {withdrawl} L.E.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCurrentBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
    