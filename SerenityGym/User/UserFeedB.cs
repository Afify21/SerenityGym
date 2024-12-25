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
            string revmood;

            if (radioButton1.Checked == true)
            {
                revmood = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                revmood = radioButton2.Text;
            }
            else
            {
                MessageBox.Show("Please choose review type");
                return;
            }

            int result = controllerObj.SubmitFeedback(TB_Feed.Text,UID,revmood);
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
