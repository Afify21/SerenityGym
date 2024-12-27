using DBapplication;

namespace SerenityGym
{
    public partial class Updatestaff : Form
    {
        Controller controllerObj;
        public Updatestaff()
        {
            controllerObj = new Controller();
            InitializeComponent();
            CB_Updator.Items.AddRange(new string[] { "First name", "Last name", "Address", "Password", "Phone number" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Updator.Text == "Password")
            {


                label3.Text = "New Password";
                label3.Visible = true;


            }
            else if (CB_Updator.Text == "First name")
            {
                label3.Text = "New First name";
                label3.Visible = true;


            }
            else if (CB_Updator.Text == "Last name")
            {
                label3.Text = "New Last name";
                label3.Visible = true;

            }
            else if (CB_Updator.Text == "Address")
            {
                label3.Text = "New Address";
                label3.Visible = true;

            }

            else if (CB_Updator.Text == "Phone number")
            {
                label3.Text = "New Number";
                label3.Visible = true;

            }
        }

        private void find_Click(object sender, EventArgs e)
        {

        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            if (staffidbox.Text == "")
            {
                MessageBox.Show("Please enter ID!");
                return;
            }
            else if (!int.TryParse(staffidbox.Text, out _))
            {
                MessageBox.Show("Staff ID should contain only numeric values");
                return;
            }
            else if (int.Parse(staffidbox.Text) < 10000 || int.Parse(staffidbox.Text) > 30000)
            {
                MessageBox.Show("Staff ID should be between 10000 and 30000");
            }
            int UID = Convert.ToInt32(staffidbox.Text);
            if (CB_Updator.Text == "Password")
            {

                int result = controllerObj.UpdateStaffPass(TB_Update.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed! ID may not exist");
                else
                    MessageBox.Show("Updated Successfully!");


            }
            else if (CB_Updator.Text == "First name")
            {
                if (!string.IsNullOrWhiteSpace(TB_Update.Text) && !int.TryParse(TB_Update.Text, out _)) // Check if input is NOT a number
                {
                    int result = controllerObj.UpdateStaffFname(TB_Update.Text, UID);
                    if (result == 0)
                        MessageBox.Show("Update Failed!");
                    else
                        MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("First name cannot contain numbers!");
                }
            }
       
            else if (CB_Updator.Text == "Last name")
            {
                if (!string.IsNullOrWhiteSpace(TB_Update.Text) && !int.TryParse(TB_Update.Text, out _))
                {
                    int result = controllerObj.UpdateStaffLname(TB_Update.Text, UID); // Assuming UpdateStaffLname is the method for last name
                    if (result == 0)
                        MessageBox.Show("Update Failed!");
                    else
                        MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Last name cannot contain numbers or be empty!");
                }
            }

            else if (CB_Updator.Text == "Address")
            {
                int result = controllerObj.UpdateStaffAddress(TB_Update.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }

            else if (CB_Updator.Text == "Phone number")
            {
                if (!string.IsNullOrWhiteSpace(TB_Update.Text) && int.TryParse(TB_Update.Text, out int phoneNumber))
                {
                    int result = controllerObj.UpdateStaffPhone(phoneNumber, UID);
                    if (result == 0)
                        MessageBox.Show("Update Failed!");
                    else
                        MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Phone number must contain only numbers!");
                }
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int SID = Convert.ToInt32(staffidbox.Text); // Ensure input is valid
                if (SID == 30000)
                {
                    MessageBox.Show("Unable to delete manager.");
                    return; // Exit the method without proceeding
                }
                int result = controllerObj.DeleteStaff(SID);

                if (result == 0)
                    MessageBox.Show("Delete Failed! Staff ID may not exist.");
                else
                    MessageBox.Show("Delete Successful!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Staff ID! Please enter a numeric value.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
