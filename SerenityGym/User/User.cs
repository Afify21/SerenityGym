namespace SerenityGym
{
    public partial class User : Form
    {
        int UID;
        public User(int x)
        {
            UID = x;
            InitializeComponent();
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
            OnlineReg onlineReg = new OnlineReg(UID,-1);
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
    }
}
