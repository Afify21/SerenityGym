using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class Transactions_table : Form
    {
        Controller controllerObj;
        public Transactions_table()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Transactionstable();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
