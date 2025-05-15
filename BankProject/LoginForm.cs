using System.Diagnostics;

namespace BankProject
{
    public partial class LoginForm : Form
    {
        public static List<Client> clients = new List<Client>();

        public LoginForm()
        {
            InitializeComponent();
            pictureBox1.SendToBack();

            var client1 = new Client("Alaa", "alaa", "pass1", "01069617448","524093176512" ,null, Card.c1);
            var acc1 = new SavingAccount(client1, 0.05m);
            client1.SetAccount(acc1);

            var client2 = new Client("Malek", "malek", "pass2", "01010765620", "781204365089", null, Card.c2);
            var acc2 = new CheckingAccount(client2);
            client2.SetAccount(acc2);

            clients.Add(client1);
            clients.Add(client2);

            //var client3 = new Client("Noureddin", "noureddin", "pass3", "01006854409", null, Card.c3);
            //var acc3 = new SavingAccount(client3, 0.05m);
            //client1.SetAccount(acc3);
            //clients.Add(client3);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel1.Parent = this.pictureBox1;
            btnLogIn.BackColor = ColorTranslator.FromHtml("#f8eadf");
            this.AcceptButton = btnLogIn;
        }

        private void ProjectName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }
        private int ClickCounter = 0;
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            //UserForm userForm = new UserForm();    //DO NOT TOUCH
            LoginForm loginForm = new LoginForm(); //DO NOT TOUCH

            Client foundClient = clients.FirstOrDefault(C => C.Username == txtUsername.Text && C.Password == txtPassowrd.Text);
            //searches through the clients list and returns the first item that matches the condition provided. If no item matches, it returns null.


            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassowrd.Text))
            {
                ClickCounter++;
                if (ClickCounter == 3)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.ShowDialog();
                    ClickCounter = 0;
                    return;
                }
                MessageBox.Show("Please enter Username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (foundClient != null && foundClient.Authenticate(txtUsername.Text, txtPassowrd.Text))
            {
                UserForm userForm = new UserForm(foundClient);
                userForm.Show();
                this.Hide();
                txtPassowrd.Clear();
                txtUsername.Clear();
            }
            else
            {
                MessageBox.Show("Username or Password is invalid, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassowrd.PasswordChar = '\0';
            }
            else
            {
                txtPassowrd.PasswordChar = '*';
            }
        }
    }
}
