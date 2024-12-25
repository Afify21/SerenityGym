using DBapplication;

namespace SerenityGym
{
    public partial class OnlineReg : Form
    {
        int UID;
        Controller controllerObj;
        public OnlineReg(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
            CB_SesType.Items.AddRange(new string[] { "Padel", "Private"});

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = CB_SesType.Text;
            if(type=="Private")
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
