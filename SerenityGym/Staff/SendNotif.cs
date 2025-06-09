using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class SendNotif : Form
    {
        Controller controllerObj;
        public SendNotif()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetMemberships();
            type.DataSource = dt;
            type.DisplayMember = "membership_type";
            type.ValueMember = "membership_type";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            if (type.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a membership type");
                return;
            }
            if (notif.Text.Length == 0)
            {
                MessageBox.Show("Please enter a message for the notification");
                return;
            }
            controllerObj.SendNotification(notif.Text);
            int ID = controllerObj.GetNotifID();
            controllerObj.GetsNotified(ID, type.Text);
            MessageBox.Show("Notification Sent Successfully!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (notif.Text.Length == 0)
            {
                MessageBox.Show("Please enter a message for the notification");
                return;
            }
            controllerObj.SendNotification(notif.Text);
            int ID = controllerObj.GetNotifID();
            controllerObj.GetsNotified(ID, "Bronze");
            controllerObj.SendNotification(notif.Text);
            ID = controllerObj.GetNotifID();
            controllerObj.GetsNotified(ID, "Gold");
            controllerObj.SendNotification(notif.Text);
            ID = controllerObj.GetNotifID();
            controllerObj.GetsNotified(ID, "Platinum");
            controllerObj.SendNotification(notif.Text);
            ID = controllerObj.GetNotifID();
            controllerObj.GetsNotified(ID, "Silver");
            MessageBox.Show("Notification Sent Successfully!");
        }
    }
}
