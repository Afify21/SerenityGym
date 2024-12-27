using DBapplication;
using Microsoft.VisualBasic.ApplicationServices;

namespace SerenityGym
{
    public partial class UserLogin : Form
    {
        Controller controllerObj;

        public UserLogin()
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
            ForgotPassUser forgotpass = new ForgotPassUser();
            forgotpass.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int givenid = 0;
            if (!int.TryParse(Userr.Text, out givenid))
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
            if (Userr.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
            int result = controllerObj.MatchingUser(Convert.ToInt16(Userr.Text), Pass.Text);
            if (result == 1)
            {
                User user = new User(Convert.ToInt16(Userr.Text));
                user.Show();
            }
            else
                MessageBox.Show("Please Enter A Proper Combination");



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Userr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
