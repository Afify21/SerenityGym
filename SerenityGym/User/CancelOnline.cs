using DBapplication;
using System.Data;
using System.Windows.Forms;

namespace SerenityGym
{
    public partial class CancelOnline : Form
    {
        int UID;
        Controller controllerObj;
        public CancelOnline(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
            CB_Updator.Visible = false;
            button2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void B_Padel_Click(object sender, EventArgs e)
        {
            DataTable dS = controllerObj.GetPadelReg(UID);

            dataGridView1.DataSource = dS;
            dataGridView1.Refresh();
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("No available registerations");
                return;
            }
            CB_Updator.DataSource = dS;
            CB_Updator.DisplayMember = "registrationid";
            CB_Updator.Visible = true;
            button2.Visible=true;
        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            DataTable dS = controllerObj.Getprivregs(UID);

            dataGridView1.DataSource = dS;
            dataGridView1.Refresh();
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("No available registerations");
            }
            CB_Updator.DataSource = dS;
            CB_Updator.DisplayMember = "registrationid";
            CB_Updator.Visible = true;
            button2.Visible = true;
        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this registeration?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int r = controllerObj.deletereg(Convert.ToInt16(CB_Updator.Text));
                if (r == 0) { MessageBox.Show("Cancelation Failed"); }
                else if (r == 1) { MessageBox.Show("Canceled Successfully");
                    dataGridView1.DataSource=null
               ; dataGridView1.Refresh();
                }
            }

        }
    }
}
