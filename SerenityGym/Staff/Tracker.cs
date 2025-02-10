using DBapplication;
using System.Data;
using System.Security.Cryptography;

namespace SerenityGym
{
    public partial class Tracker : Form
    {
        int UID;

        Controller controllerObj;

        public Tracker(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
            //comboBox1.DataSource= controllerObj.IsTrainedByWho(UID); 
            //comboBox1.DisplayMember = "fname";
            //comboBox1.ValueMember = "fname";
            string Tname = controllerObj.IsTrainedByWho(UID);
            label4.Text = Tname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewTrainingPlan(UID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewDietPlan(UID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewMemberProgress(UID);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }
    }
}
