using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class Feedbacks_table : Form
    {
        Controller controllerObj;
        public Feedbacks_table()
        {

            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Feedbacktable();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
