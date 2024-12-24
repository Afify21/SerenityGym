using DBapplication;

namespace SerenityGym
{
    public partial class UserFeedB : Form
    {
        int UID;
        Controller controllerObj;
        public UserFeedB(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj=new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void B_Feedback_Click(object sender, EventArgs e)
        {
            int result = controllerObj.SubmitFeedback(TB_Feed.Text,UID);
            if (result == 0)
                MessageBox.Show("Error in Submission");
            else
                MessageBox.Show("Feedback Submited Successfully");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
