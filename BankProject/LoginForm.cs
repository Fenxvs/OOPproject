namespace BankProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            pictureBox1.SendToBack();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.panel1.Parent = this.pictureBox1;
            btnLogIn.BackColor = ColorTranslator.FromHtml("#f8eadf");
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            UserForm userForm = new UserForm();    //DO NOT TOUCH
            LoginForm loginForm = new LoginForm(); //DO NOT TOUCH

            string usernameUser = "Alaa";
            string PasswordUser = "Alaa12345";
            string Null = "";

            this.Hide();

            if (txtUsername.Text == usernameUser && txtPassowrd.Text == PasswordUser)
            {
                userForm.ShowDialog();
                loginForm.Close();
            }
            else if (txtUsername.Text == Null && txtPassowrd.Text == Null)
            {
                MessageBox.Show("Please enter Username and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username or Password is invalid, please try again. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
