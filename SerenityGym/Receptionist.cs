using DBapplication;
using Microsoft.VisualBasic.ApplicationServices;

namespace SerenityGym
{
    public partial class Receptionist : Form
    {
        Controller controllerObj;

        public Receptionist()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            int result = controllerObj.MatchingUser(Convert.ToInt16(User.Text), Pass.Text);
            if (result == 1)
            {
                User user = new User(Convert.ToInt16(User.Text));
                user.Show();
            }
            else
                MessageBox.Show("Please Enter A Proper Combination");
        }
    }
}
