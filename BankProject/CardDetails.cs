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
using Microsoft.VisualBasic;

namespace BankProject
{
    public partial class CardDetails : Form
    {
        private Client client;
        public CardDetails(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void CardDetails_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
        }



        private void SliderBar_Tick(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(client);
            userForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#322f2d");
            ForeColor = ColorTranslator.FromHtml("#dfd3c9");
            try
            {
                string password = client.Password;
                string UserInput = Interaction.InputBox("Enter your password", "Password confirmation", "", -1, -1);

                if (string.IsNullOrEmpty(UserInput))
                {
                    MessageBox.Show("Please enter a password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (UserInput == password)
                {
                    if (client.Username == "alaa")
                    {
                        lblCardNumber.Text = Card.c1.CardNumber;
                        lblDate.Text = Card.c1.ExpirationDate.ToString("MM/yy");
                        lblCVV.Text = Card.c1.CVV;
                        lblName.Text = "ALAA";
                    }
                    else if (client.Username == "malek")
                    {
                        lblCardNumber.Text = Card.c2.CardNumber;
                        lblDate.Text = Card.c2.ExpirationDate.ToString("MM/yy");
                        lblCVV.Text = Card.c2.CVV;
                        lblName.Text = "MALEK";
                    }
                    else
                    {
                        MessageBox.Show("Error Occured, Try again please!", "Warning", MessageBoxButtons.OK);
                    }

                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error occured, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCardDetails_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accountsForm = new Accounts(client);
            accountsForm.ShowDialog();
        }
    }
}
