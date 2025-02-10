using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class ComingSessions : Form
    {
        int TID;
        int UID;
        Controller controllerObj;
        public ComingSessions(int id)
        {
            TID = id;
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void submit_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable dt = controllerObj.ViewComingSessions(TID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
