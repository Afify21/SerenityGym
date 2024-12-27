using DBapplication;
using System.Security.Cryptography;

namespace SerenityGym
{
    public partial class Trainer : Form
    {
        int TID;
        Controller controllerObj;
        public Trainer(int x)
        {
            TID = x;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePlans updateplans = new UpdatePlans(TID);
            updateplans.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertPlans insertplans = new InsertPlans(TID);
            insertplans.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PastSessions pastsessions = new PastSessions(TID);
            pastsessions.Show();
        }

        private void B_transaction_Click(object sender, EventArgs e)
        {
            ComingSessions comingsessions = new ComingSessions(TID);
            comingsessions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewMemberProgress progress = new ViewMemberProgress(TID);
            progress.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (controllerObj.IsClockedInCheck(TID) == 1)
            {
                controllerObj.ClockingOut(TID);
                MessageBox.Show("Clocked out successfully");

                return;
            }
            else if (controllerObj.IsClockedInCheck(TID) == 2)
            {
                MessageBox.Show("You have already clocked out");

                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddProgress addprogress = new AddProgress(TID);
            addprogress.Show();
        }
    }
}
