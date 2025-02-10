using DBapplication;

namespace SerenityGym
{
    public partial class Manager : Form
    {
        int MID;
        Controller controllerObj;
        public Manager(int x)
        {
            MID = x;
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            Transactions_table Form = new Transactions_table();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipments Form = new Equipments();
            Form.Show();
        }

        private void Userr_Click(object sender, EventArgs e)
        {
            Statistics_table Form = new Statistics_table();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedbacks_table Form = new Feedbacks_table();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updatestaff Form = new Updatestaff();
            Form.Show();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Addadmin Form = new Addadmin();
            Form.Show();
        }
    }
}
