using DBapplication;

namespace SerenityGym
{
    public partial class UpdateUser : Form
    {
        Controller controllerObj;
        public UpdateUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            int b;
            bool y = false;
            if (int.TryParse(fname.Text, out b) && fname.Text != "")
            {
                MessageBox.Show("Please enter a valid First Name");
                return;
            }
            if (int.TryParse(lname.Text, out b) && lname.Text != "")
            {
                MessageBox.Show("Please enter a valid Last Name");
                return;
            }
            if (!int.TryParse(num.Text, out b) && num.Text != "")
            {
                MessageBox.Show("Please enter a valid Phone Number");
                return;
            }
            if (pass.Text != "")
            {
                if (pass.Text.Length < 6)
                {
                    MessageBox.Show("Please enter a password of appropriate length (minimum 6 characters).");
                    return;
                }
            }
            if (controllerObj.CheckUserID(Convert.ToInt32(id.Text)) != 0)
            {
                if (add.Text != "")
                {
                    controllerObj.UpdateUserAddress(add.Text, Convert.ToInt32(id.Text));
                    y = true;
                }
                if (fname.Text != "")
                {
                    controllerObj.UpdateUserFname(fname.Text, Convert.ToInt32(id.Text));
                    y = true;
                }
                if (lname.Text != "")
                {
                    controllerObj.UpdateUserLname(lname.Text, Convert.ToInt32(id.Text));
                    y = true;
                }
                if (num.Text != "")
                {
                    controllerObj.UpdateUserPhone(Convert.ToInt32(num.Text), Convert.ToInt32(id.Text));
                    y = true;
                }
                if (pass.Text != "")
                {
                    controllerObj.UpdateUserPass(pass.Text, Convert.ToInt32(id.Text));
                    y = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid userid");
                return;
            }



            if (y)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Nothing has been Updated");
            }
        }

        private void Userr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
