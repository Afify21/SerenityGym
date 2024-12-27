using DBapplication;

namespace SerenityGym
{
    public partial class User : Form
    {
        int UID;
        Controller controllerObj;
        public User(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            UpdatePersonal updatePersonal = new UpdatePersonal(UID);
            updatePersonal.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            UserFeedB userFeedB = new UserFeedB(UID);
            userFeedB.Show();
        }



        private void B_Notifications_Click(object sender, EventArgs e)
        {
            GetMYNotis getMYNotis = new GetMYNotis(UID);
            getMYNotis.Show();
        }

        private void B_Registeration_Click(object sender, EventArgs e)
        {
            OnlineReg onlineReg = new OnlineReg(UID, -1);
            onlineReg.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin.ActiveForm.Close();
            UserLogin userlogin = new UserLogin();
            userlogin.Show();
        }

        private void B_Tracker_Click(object sender, EventArgs e)
        {
            if (controllerObj.hasPlan(UID))
            {
                Tracker tracker = new Tracker(UID);
                tracker.Show();
            }
            else
            {
                MessageBox.Show("Your Plan is Still Under Progress");
            }
        }

        private void B_transaction_Click(object sender, EventArgs e)
        {

        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            CancelOnline cancelOnline = new CancelOnline(UID);
            cancelOnline.Show();
        }
    }
}
