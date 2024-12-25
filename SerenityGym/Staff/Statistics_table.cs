using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class Statistics_table : Form
    {
        Controller controllerObj;
        public Statistics_table()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Transactionstable();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            int profit = controllerObj.ShowProfit();
            label2.Text = profit.ToString();
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
