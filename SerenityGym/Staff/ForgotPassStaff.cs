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
            if (Staffid.Text == "" || pass.Text == "" || repass.Text == "")
            {
                MessageBox.Show("Please Enter A Proper Combination");
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
    }
    }

