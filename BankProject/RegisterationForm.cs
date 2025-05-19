using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                string Name = txtName.Text;
                string PhoneNumber = txtPhoneNum.Text;
                string AccountType = AccountTypeBox.Text;
                string CardNum = txtCardNum.Text;
                string CardHolderName = txtCardHoldName.Text;
                string ExpDate = txtEXPdate.Text;
                string CCV = txtCCV.Text;
                int CCVN = Convert.ToInt32(CCV);


                string FilePath = $"Account_{Username}.txt";
                string FilePathCard = $"Card_{Username}.txt";

                if (File.Exists(FilePath) || File.Exists(FilePathCard))
                {
                    MessageBox.Show("Username already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsCardNumberUsed(CardNum))
                {
                    MessageBox.Show("Card Number already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsPhoneNumberUsed(PhoneNumber))
                {
                    MessageBox.Show("Phone Number already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(IsUsernameUsed(Username))
                {
                    MessageBox.Show("Username already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string data = $"Username: {Username}\n" +
                             $"Password: {Password}\n" +
                             $"Name: {Name}\n" +
                             $"Phone Number: {PhoneNumber}\n" +
                             $"Account Type: {AccountType}\n";

                string dataCard = $"Card Number: {CardNum}\n" +
                                $"Card Holder Name: {CardHolderName}\n" +
                                $"Expiration Date: {ExpDate}\n" +
                                $"CCV: {CCV}";

                File.WriteAllText(FilePath, data);
                File.WriteAllText(FilePathCard, dataCard);

                MessageBox.Show("Account created successfully!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error occured, try again please");
            }
        }

        private void RegisterationForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool IsPhoneNumberUsed(string phoneNumber)
        {
            string[] FilesOfAccounts = Directory.GetFiles(".", "Account_*.txt");
            foreach (var file in FilesOfAccounts)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(phoneNumber))
                    return true;
            }
            return false;
        }

        bool IsCardNumberUsed(string cardNumber)
        {
            string[] cardFiles = Directory.GetFiles(".", "Card_*.txt");
            foreach (var file in cardFiles)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(cardNumber)) return true;
                   
            }
            return false;
        }
        bool IsUsernameUsed(string username)
        {
            string[] FilesOfAccounts = Directory.GetFiles(".", "Account_*.txt");
            foreach (var file in FilesOfAccounts)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(username))
                    return true;
            }
            return false;
        }
    }
}
