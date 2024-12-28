namespace SerenityGym
{
    public partial class Surprise : Form
    {
        public Surprise()
        {
            InitializeComponent();
            string f = "C:\\Users\\DELL\\Desktop\\WhatsApp Video.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
