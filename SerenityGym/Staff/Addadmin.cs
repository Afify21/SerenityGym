using DBapplication;

namespace SerenityGym
{
    public partial class Addadmin : Form
    {
        Controller controllerObj;
        public Addadmin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            int r;

            // Check if any field is empty
            if (fname.Text == "" || lname.Text == "" || add.Text == "" || num.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Please enter all the required fields");
                return;
            }

            // Validate first name (it should not be a number)
            if (int.TryParse(fname.Text, out r))
            {
                MessageBox.Show("Please enter a valid first name (no numbers allowed)");
                return;
            }

            // Validate last name (it should not be a number)
            if (int.TryParse(lname.Text, out r))
            {
                MessageBox.Show("Please enter a valid last name (no numbers allowed)");
                return;
            }

            // Validate phone number (should be a number and can be more flexible if needed)
            if (!int.TryParse(num.Text, out r))
            {
                MessageBox.Show("Please enter a valid phone number (only digits allowed)");
                return;
            }
            if (!int.TryParse(mgrid.Text, out r) || r < 30001 || r > 40000)
            {
                MessageBox.Show("Please enter a valid manager ID between 30001 and 40000");
                return;
            }
            // If all validations pass, insert the admin details into the database
            int result = controllerObj.Insertadmin(mgrid.Text, fname.Text, lname.Text, Convert.ToInt32(num.Text), add.Text, pass.Text);
            if (result > 0)
            {
                MessageBox.Show("Admin Added Successfully!");
            }
            else
            {
                MessageBox.Show("An error occurred while adding the user. Please try again.");
            }
        }

        private void mgrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
