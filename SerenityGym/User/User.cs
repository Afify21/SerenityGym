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
    }
}
