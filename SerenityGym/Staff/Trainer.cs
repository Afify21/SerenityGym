using DBapplication;

namespace SerenityGym
{
    public partial class Trainer : Form
    {
        int TID;
        Controller controllerObj;
        public Trainer(int x)
        {
            TID = x;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePlans updateplans = new UpdatePlans(TID);
            updateplans.Show();
        }
    }
}
