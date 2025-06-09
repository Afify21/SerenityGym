using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class Equipments : Form
    {
        Controller controllerObj;
        public Equipments()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Equipmenttable();
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
