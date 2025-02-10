using DBapplication;
using System.Data.SqlClient;

namespace SerenityGym
{
    public partial class GetMYNotis : Form
    {
        int UID;
        int i = -1;
        int rc;
        Controller controllerObj;
        string membership;
        string datee;
        public GetMYNotis(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
            membership = controllerObj.getmembership(UID);
            TB_NOTIS.Text = controllerObj.Getnotis(membership, ref i, ref rc, ref datee);
            L_Date.Text = datee;
            B_prev.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            if (i == 0)
                B_Nextt.Visible = true;
            i++;
            TB_NOTIS.Text = controllerObj.Getnotis(membership, ref i, ref rc, ref datee);
            L_Date.Text = datee;
            if (rc - 1 == i)
                B_prev.Visible = false;

        }

        private void B_Prev_Click(object sender, EventArgs e)
        {
            if (rc - 1 == i)
                B_prev.Visible = true;
            i--;
            TB_NOTIS.Text = controllerObj.Getnotis(membership, ref i, ref rc, ref datee);
            L_Date.Text = datee;
            if (i == 0)
                B_Nextt.Visible = false;
        }

        private void L_Date_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
