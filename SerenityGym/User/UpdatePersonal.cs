using DBapplication;

namespace SerenityGym
{
    public partial class UpdatePersonal : Form
    {
        int UID;
        Controller controllerObj;
        public UpdatePersonal(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();

            CB_Updator.Items.AddRange(new string[] { "First name", "Last name", "Address", "Password", "Phone number" });
            TB_Update.Visible = false;
            TB_Updator2.Visible = false;
            B_Update.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            if (CB_Updator.Text == "Password")
            {
                if (TB_Update.Text == TB_Updator2.Text)
                {
                    int result = controllerObj.UpdateUserPass(TB_Updator2.Text, UID);
                    if (result == 0)
                        MessageBox.Show("Update Failed!");
                    else
                        MessageBox.Show("Updated Successfully!");
                }
                else
                    MessageBox.Show("Passwords dont match");
            }
            else if (CB_Updator.Text == "First name")
            {
                int result = controllerObj.UpdateUserFname(TB_Update.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }
            else if (CB_Updator.Text == "Last name")
            {
                int result = controllerObj.UpdateUserLname(TB_Update.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }
            else if (CB_Updator.Text == "Address")
            {
                int result = controllerObj.UpdateUserAddress(TB_Update.Text, UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }

            else if (CB_Updator.Text == "Phone number")
            {
                int result = controllerObj.UpdateUserPhone(Convert.ToInt32(TB_Update.Text), UID);
                if (result == 0)
                    MessageBox.Show("Update Failed!");
                else
                    MessageBox.Show("Updated Successfully!");
            }
        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Updator.Text == "Password")
            {
                TB_Update.Clear();
                TB_Update.Visible = true;
                B_Update.Visible = true;
                label3.Text = "New Password";
                label3.Visible = true;


                TB_Updator2.Visible = true;
                label4.Text = "Reneter Password";
                label4.Visible = true;
                return;
            }
            else if (CB_Updator.Text == "First name")
            {
                TB_Update.Clear();
                TB_Updator2.Visible = false;
                label4.Visible = false;
                label3.Text = "New First Name";
                label3.Visible = true;
                TB_Update.Visible = true;
                B_Update.Visible = true;

            }
            else if (CB_Updator.Text == "Last name")
            {
                TB_Update.Clear();

                TB_Updator2.Visible = false;
                label4.Visible = false;

                label3.Text = "New Last Name";
                label3.Visible = true;
                TB_Update.Visible = true;
                B_Update.Visible = true;

            }
            else if (CB_Updator.Text == "Address")
            {
                TB_Update.Clear();

                TB_Updator2.Visible = false;
                label4.Visible = false;

                label3.Text = "New Address";
                label3.Visible = true;
                TB_Update.Visible = true;
                B_Update.Visible = true;
            }

            else if (CB_Updator.Text == "Phone number")
            {
                TB_Update.Clear();

                TB_Updator2.Visible = false;
                label4.Visible = false;

                label3.Text = "New Number";
                label3.Visible = true;
                TB_Update.Visible = true;
                B_Update.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
