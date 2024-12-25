using DBapplication;
using System.Data;
using System.Xml.Linq;

namespace SerenityGym
{
    public partial class ViewMemberProgress : Form
    {
        int TID;
        int UID;
        Controller controllerObj;
        public ViewMemberProgress(int id)
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

        private void submit_Click(object sender, EventArgs e)
        {
            UID = Convert.ToInt32(Userid.Text);

            if (Userid.Text == "")
            {
                MessageBox.Show("Please Enter A User ID");
                return;
            }
            if (!controllerObj.IsTrainedByTrainer(UID, TID))
            {
                MessageBox.Show("Please Enter A User You Train");
                return;

            }
            dataGridView1.Visible = true;
            //DataTable dt = controllerObj.ViewMemberProgress(TID, UID);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }
    }
}
