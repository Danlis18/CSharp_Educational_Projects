using System.Diagnostics.Metrics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _036_WF_HomeWork
{
    public partial class Form1 : Form
    {
        int countL = 1;
        int countR = 1;
        int countM = 1;
        int countG = 1;
        int counter = 20;
        public Form1()
        {
            InitializeComponent();

            timer_to_close.Text = counter.ToString();

            DateTime now = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026, 2, 9, 0, 0, 0);

            TimeSpan difference = dateAfterWeek - now;
            seconds.Text = difference.TotalSeconds.ToString("0");
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = countG++.ToString();

            if (e.Button == MouseButtons.Left)
            {
                Left_Clik.Text = countL++.ToString();
            }

            else if (e.Button == MouseButtons.Right)
            {
                Right_Clik.Text = countR++.ToString();
            }

            else if (e.Button == MouseButtons.Middle)
            {
                Middle_Clik.Text = countM++.ToString();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026, 2, 9, 0, 0, 0);

            TimeSpan difference = dateAfterWeek - now;
            seconds.Text = difference.TotalSeconds.ToString("0");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter--;
            timer_to_close.Text = counter.ToString();

            if (counter == 0)
            {
                timer3.Stop();
                this.Close();
            }
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тоді для чого натиснули кнопку?", "Message", MessageBoxButtons.OKCancel);
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не існує неможливих ситуацій! Бажання перемагає будь-який код.", "Message", MessageBoxButtons.OKCancel);
        }

        private void button_yes_MouseMove(object sender, MouseEventArgs e)
        {
            button_yes.Top -= e.Y;
            button_yes.Left += e.X;
            if(button_yes.Top < -10 || button_yes.Top > 100)
                button_yes.Top = 60;
            if (button_yes.Left < -80 || button_yes.Top > 250)
                button_yes.Left = 120;
        }
    }
}
