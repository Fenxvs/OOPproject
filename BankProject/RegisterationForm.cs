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
    }
}
