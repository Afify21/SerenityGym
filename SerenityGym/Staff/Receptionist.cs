using DBapplication;

namespace SerenityGym
{
    public partial class Receptionist : Form
    {
        int RID;
        Controller controllerObj;
        public Receptionist(int x)
        {
            RID = x;
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

        private void Stafff_Click(object sender, EventArgs e)
        {
            SignUp U = new SignUp();
            U.Show();
        }

        private void Userr_Click(object sender, EventArgs e)
        {
            if (upd.SelectedIndex == -1)
            {
                MessageBox.Show("Select what you want to update");
                return;
            }
            if (upd.Text == "User")
            {
                UpdateUser U = new UpdateUser();
                U.Show();
            }

            if (upd.Text == "Self")
            {
                UpdateSelf U = new UpdateSelf(RID);
                U.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendNotif N = new SendNotif();
            N.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (controllerObj.IsClockedInCheck(RID)==1)
            {
                controllerObj.ClockingOut(RID);
                MessageBox.Show("Clocked out successfully");
                this.Close();
                return;
            }
            else if(controllerObj.IsClockedInCheck(RID) == 2)
            {
                MessageBox.Show("You have already clocked out");
                this.Close();
                return;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffLogin.ActiveForm.Close();
            StaffLogin stafflogin = new StaffLogin();
            stafflogin.Show();
        }
    }
}
