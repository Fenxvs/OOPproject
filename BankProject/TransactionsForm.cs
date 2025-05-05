using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            ListBoxTransactionHis.BackColor = ColorTranslator.FromHtml("#dfd3c9");
            btnDeposit.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnTransfer.BackColor = ColorTranslator.FromHtml("#322f2d");
            btnWithdrawl.BackColor = ColorTranslator.FromHtml("#322f2d");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();


        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void slidebar_Paint(object sender, PaintEventArgs e)
        {
            slidebar.BackColor = ColorTranslator.FromHtml("#322f2d");
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

            ListBoxTransactionHis.Items.Add($"[{DateTime.Now:MM/dd/yyyy HH:mm}] Deposit: {Deposit} L.E." );
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentBalance.Text))
            {
                MessageBox.Show("Please enter a value", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
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
    }
}
