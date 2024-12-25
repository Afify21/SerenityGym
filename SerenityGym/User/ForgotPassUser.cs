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

            if (Userid.Text == "" || pass.Text == "" || repass.Text == "")
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
            UID = Convert.ToInt32(Userid.Text);
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

