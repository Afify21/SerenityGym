using DBapplication;
using System.Data.SqlClient;

namespace SerenityGym
{
    public partial class GetMYNotis : Form
    {
        int UID;
        Controller controllerObj;
        public GetMYNotis(int x)
        {
            int i=0;
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
/*            string membership = controllerObj.getmembership(UID).ToString();
            string s=controllerObj.Getnotis(membership);*/
/*            string notifMessage = reader["notif_message"].ToString();
*/
            TB_NOTIS.Text = "Helooooo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userid_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
