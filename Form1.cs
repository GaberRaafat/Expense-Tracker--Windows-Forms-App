using ITI_EF_WorkShop.Models;

namespace ITI_EF_WorkShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Passwordtext.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbuttom_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input

                if (string.IsNullOrWhiteSpace(Usertext.Text) || string.IsNullOrWhiteSpace(Passwordtext.Text))
                {
                    MessageBox.Show("Username and password cannot be empty.", "Input Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string enteredUsername = Usertext.Text.Trim().ToLower();
                string enteredPassword = Passwordtext.Text.Trim().ToLower();


                if (enteredPassword.Length <= 5)
                {
                    MessageBox.Show("Password must be greater than 5 characters.", "Invalid Password",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (Trackercontext tracker = new Trackercontext())
                {

                    var user = tracker.Users
                                      .FirstOrDefault(t => t.Username == enteredUsername && t.Password == enteredPassword);

                    if (user != null)
                    {
                        int userID = user.UserID;
                        MainDashBoard mainDashBoard = new MainDashBoard(userID);
                        mainDashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password. Please try again.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while attempting to log in. Please try again later.\n\nDetails: {ex.Message}",
                                "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void registerbuttom_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool passwordVisible = Passwordtext.UseSystemPasswordChar;

            if (passwordVisible)
            {
                Passwordtext.UseSystemPasswordChar = false;

            }
            else
            {
                Passwordtext.UseSystemPasswordChar = true;

            }


        }
    }
}
