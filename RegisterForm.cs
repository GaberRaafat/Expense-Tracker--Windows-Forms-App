using System.Linq.Expressions;
using ITI_EF_WorkShop.Models;

namespace ITI_EF_WorkShop
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();

            // Attach TextChanged event handlers
            newusernametext.TextChanged += newusernametext_TextChanged;
            passwordtext.TextChanged += passwordtext_TextChanged;
            newincometext.TextChanged += newincometext_TextChanged;
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            Signupbuttom.Enabled = false;   
        }

        private void ValidateUsername()
        {
            if (string.IsNullOrEmpty(newusernametext.Text) || newusernametext.Text.Length < 5)
            {
                label8.Text = "Username must be at least 5 characters long.";
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            CheckAllValidations();
        }

        private void ValidatePassword()
        {
            if (string.IsNullOrEmpty(passwordtext.Text) || passwordtext.Text.Length < 5)
            {
                label6.Text = "Enter a valid password";
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
            CheckAllValidations();
        }

        private void ValidateIncome()
        {
            if (!decimal.TryParse(newincometext.Text, out decimal income) || income <= 0)
            {
                label7.Text = "Enter a valid positive income";
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            CheckAllValidations();
        }

        private void CheckAllValidations()
        {
            Signupbuttom.Enabled = !label8.Visible && !label6.Visible && !label7.Visible;
        }

        private void newusernametext_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void newincometext_TextChanged(object sender, EventArgs e)
        {
            ValidateIncome();
        }

        private void Signupbuttom_Click(object sender, EventArgs e)
        {
            if (label8.Visible || label6.Visible || label7.Visible)
            {
                MessageBox.Show("Please correct the highlighted errors before proceeding.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Trackercontext tracker = new Trackercontext())
            {
                try
                {
                    string newUsername = newusernametext.Text.Trim().ToLower();
                    string newPassword = passwordtext.Text.Trim();

                    User user = new User
                    {
                        Username = newUsername,
                        Password = newPassword,
                        Income = double.Parse(newincometext.Text.Trim())
                    };

                    tracker.Users.Add(user);
                    tracker.SaveChanges();

                    MessageBox.Show("User registered successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    newusernametext.Clear();
                    passwordtext.Clear();
                    newincometext.Clear();
                    Signupbuttom.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving user data: {ex.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
