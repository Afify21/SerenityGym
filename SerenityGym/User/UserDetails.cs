using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class UserDetails : Form
    {
        int UID;
        Controller controllerObj;
        public UserDetails(int x)
        {
            UID = x;
            Controller controllerObj = new Controller();
            InitializeComponent();
            DataTable ds = controllerObj.GETMYDET(UID);
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
