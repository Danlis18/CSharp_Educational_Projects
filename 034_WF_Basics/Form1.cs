namespace _034_WF_Basics
{
    public partial class Form1 : Form
    {

        int count = 0;


        public Form1()
        {

            InitializeComponent();
            labelTimer.Text = DateTime.Now.ToLongTimeString();



            DateTime now = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026, 1, 21, 0, 0, 0);

            TimeSpan difference = dateAfterWeek - now;
            MessageBox.Show(difference.TotalDays.ToString());


            // MessageBox.Show(DateTime.Now.Hour.ToString());





            // MessageBox.Show(DateTime.Now.ToLongTimeString());

            // DialogResult result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);



            //if (result == DialogResult.OK) {
            //    MessageBox.Show("Ви натиснули OK");
            //}

            //if (result == DialogResult.Cancel) {
            //    MessageBox.Show("Ви натиснули Cancel");
            //}


            //DialogResult result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);

            //while (result == DialogResult.Retry)
            //{
            //    result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);
            //}




        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{
            //    MessageBox.Show("Ви натиснули ліву кнопку",
            //        "Повідомлення",
            //        MessageBoxButtons.RetryCancel,
            //        MessageBoxIcon.Warning
            //        );
            //}


            //if (e.Button == MouseButtons.Right) {
            //    MessageBox.Show("Ви натиснули праву кнопку",
            //           "Повідомлення",
            //           MessageBoxButtons.RetryCancel,
            //           MessageBoxIcon.Warning
            //           );

            //}


            this.Text = count++.ToString();



        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            // this.Text = $"{e.X}, {e.Y}";
            textLabel.Text = $"{e.X}, {e.Y}";

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("Message");

            labelCount.Text = count++.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
