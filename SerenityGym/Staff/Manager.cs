using DBapplication;

namespace SerenityGym
{
    public partial class Manager : Form
    {
        int MID;
        Controller controllerObj;
        public Manager(int x)
        {
            MID = x;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
