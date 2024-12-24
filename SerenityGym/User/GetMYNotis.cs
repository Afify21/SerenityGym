using DBapplication;

namespace SerenityGym
{
    public partial class GetMYNotis : Form
    {
        int UID;
        Controller controllerObj;
        public GetMYNotis(int x)
        {
            UID = x;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
