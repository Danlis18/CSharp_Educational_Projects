namespace _027_EventsExanpleWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            this.BackColor = Color.DarkGreen;
            button1.BackColor = Color.Gray;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"{e.X}, Y: {e.Y}";
        }
    }
}
