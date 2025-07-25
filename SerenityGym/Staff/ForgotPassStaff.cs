using DBapplication;
using Microsoft.VisualBasic.ApplicationServices;

namespace SerenityGym
{
    public partial class ForgotPassStaff : Form
    {
        Controller controllerObj;
        int SID;
        public ForgotPassStaff()
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
            if (pass.Text.Length < 6)
            {
                MessageBox.Show("Please enter a password of appropriate length (minimum 6 characters).");
                return;
            }
            if (string.IsNullOrWhiteSpace(Staffid.Text) || string.IsNullOrWhiteSpace(pass.Text) || string.IsNullOrWhiteSpace(repass.Text))
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
            if (!int.TryParse(Staffid.Text, out int SID))
            {
                MessageBox.Show("Staff ID must be a numeric value");
                return;
            }
            SID = Convert.ToInt32(Staffid.Text);
            if (pass.Text == repass.Text)
            {
                int result = controllerObj.UpdateStaffPass(pass.Text, SID);
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

