using DBapplication;

namespace SerenityGym
{
    public partial class StaffLogin : Form
    {
        Controller controllerObj;

        public StaffLogin()
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
            int givenid = 0;
            if (!int.TryParse(TB_id.Text, out givenid))
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }

            int result = controllerObj.MatchingStaff(givenid, TB_Pass.Text);

            if (result == 1)
            {
                if (givenid >= 10000 && givenid <= 19999)
                {
                    Receptionist receptionist = new Receptionist();
                    receptionist.Show();
                }
                else if (givenid >= 20000 && givenid <= 29999)
                {
                    Trainer trainer = new Trainer();
                    trainer.Show();
                }
                else if (givenid >= 30000 && givenid <= 39999)
                {
                    Manager manager = new Manager();
                    manager.Show();
                }
            }
            else if (result == 0)
            {
                MessageBox.Show("Please Enter A Proper Combination");
                return;
            }
        }
    }
}
