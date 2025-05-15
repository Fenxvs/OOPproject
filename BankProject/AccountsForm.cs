using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankProject.UserForm;

namespace BankProject
{
    public partial class Accounts : Form
    {
        private Client client;
        public Accounts(Client client)
        {
            InitializeComponent();
            this.client = client;
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(client);
            userForm.ShowDialog();
        }

        private void btnCardDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardDetails cards = new CardDetails(client);
            cards.ShowDialog();
        }

        bool SliderBarExpand;
        private void SliderBar_Paint(object sender, PaintEventArgs e)
        {
            SliderBar.BackColor = ColorTranslator.FromHtml("#322f2d");
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SliderBarTimer.Start();
        }

        private void SliderBar_Tick(object sender, EventArgs e)
        {

            if (SliderBarExpand)
            {
                SliderBar.Width -= 10;

                if (SliderBar.Width == SliderBar.MinimumSize.Width)
                {
                    SliderBarExpand = false;
                    SliderBarTimer.Stop();
                }
            }
            else
            {
                SliderBar.Width += 10;
                if (SliderBar.Width == SliderBar.MaximumSize.Width)
                {
                    SliderBarExpand = true;
                    SliderBarTimer.Stop();
                }
            }
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox.Checked)
            {

                Control parentGroup = changedCheckBox.Parent;

                foreach (Control control in parentGroup.Controls)
                {
                    if (control is CheckBox checkBox && checkBox != changedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            lbName.Text = client.Name.ToString();
            lbName.Visible = true;
            lbName.Focus();

            lbluserNme.Text = client.Username.ToString();
            lbluserNme.Visible = true;
            lbluserNme.Focus();

            lblPhone.Text = client.PhoneNum.ToString(); 
            lblPhone.Visible = true;
            lblPhone.Focus();

            lblAccountNumber.Text = client.AccountNum.ToString();
            lblAccountNumber.Visible = true;
            lblAccountNumber.Focus();

            lblCurrency.Text = "EGP";

        }
    }
}


