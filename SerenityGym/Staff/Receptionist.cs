using DBapplication;

namespace SerenityGym
{
    public partial class Receptionist : Form
    {
        int RID;
        Controller controllerObj;
        public Receptionist(int x)
        {
            RID = x;
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
