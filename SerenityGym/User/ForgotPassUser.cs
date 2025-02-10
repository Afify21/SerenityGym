using DBapplication;

namespace SerenityGym
{
    public partial class ForgotPassUser : Form
    {
        Controller controllerObj;
        int UID;
        public ForgotPassUser()
        {
            controllerObj = new Controller();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Userid.Text) || string.IsNullOrWhiteSpace(pass.Text) || string.IsNullOrWhiteSpace(repass.Text))
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
            if (!int.TryParse(Userid.Text, out int UID))
            {
                MessageBox.Show("User ID must be a numeric value");
                return;
            }
            UID = Convert.ToInt32(Userid.Text);
            if (pass.Text.Length < 6)
            {
                MessageBox.Show("Please enter a password of appropriate length (minimum 6 characters).");
                return;
            }
            if (pass.Text == repass.Text)
            {
                int result = controllerObj.UpdateUserPass(pass.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }
            else
                MessageBox.Show("Passwords dont match");


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

