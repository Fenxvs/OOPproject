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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#dfd3c9");
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
    }
}
