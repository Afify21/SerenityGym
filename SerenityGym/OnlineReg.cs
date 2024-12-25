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
            controllerObj=new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
