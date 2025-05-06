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

namespace BankProject
{
    public partial class CardDetails : Form
    {
        public CardDetails()
        {
            InitializeComponent();
        }

        private void CardDetails_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
        }

        bool SliderBarExpand;

        private void SliderBar_Tick(object sender, PaintEventArgs e)
        {
            SliderBar.BackColor = ColorTranslator.FromHtml("#322f2d");

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

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SliderBarTimer.Start();

            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#322f2d");
            ForeColor = ColorTranslator.FromHtml("#dfd3c9");

            string password = "A";
            string UserInput = Interaction.InputBox("Enter your password", "Password confirmation", "", -1, -1);

            if (string.IsNullOrEmpty(UserInput))
            {
                MessageBox.Show("Please enter a password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (UserInput == password)
            {
                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }
    }
}
