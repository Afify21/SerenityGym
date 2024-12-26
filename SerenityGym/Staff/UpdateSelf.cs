using DBapplication;

namespace SerenityGym
{
    public partial class UpdateSelf : Form
    {
        int ID;
        Controller controllerObj;
        public UpdateSelf(int x)
        {
            ID = x;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            int b;
            bool y = false;
            if(int.TryParse(fname.Text, out b) && fname.Text!="")
            {
                MessageBox.Show("Please enter a valid First Name");
                return;
            }
            if (int.TryParse(lname.Text, out b) && lname.Text!="")
            {
                MessageBox.Show("Please enter a valid Last Name");
                return;
            }
            if (!int.TryParse(num.Text, out b) && num.Text!="")
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
            if (confirm.Text == controllerObj.GetStaffPassword(ID))
            {
                if (add.Text != "")
                {
                    controllerObj.UpdateStaffAddress(add.Text, ID);
                    y = true;
                }
                if (fname.Text != "")
                {
                    controllerObj.UpdateStaffFName(fname.Text, ID);
                    y = true;
                }
                if (lname.Text != "")
                {
                    controllerObj.UpdateStaffLName(lname.Text, ID);
                    y = true;
                }
                if (num.Text != "")
                {
                    controllerObj.UpdateStaffPhoneNum(Convert.ToInt32(num.Text), ID);
                    y = true;
                }
                if (pass.Text != "")
                {
                    controllerObj.UpdateStaffPass(pass.Text, ID);
                    y = true;
                }
            }
            else
            {
                MessageBox.Show("Please Correctly enter your previous password");
            }


            if(y)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Nothing has been Updated");
            }
        }
    }
}
