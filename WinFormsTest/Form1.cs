namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                label1.Text = "Progressing...  0%";
                Random random = new Random();
                while (progressBar1.Value < 100)
                {
                    int step = random.Next(1, 6);
                    Thread.Sleep(random.Next(0, 2000));
                    if (progressBar1.Value + step > 100)
                    {
                        progressBar1.Value = 100;
                        label1.Text = $"All done";
                    }
                    else
                    {
                        progressBar1.Value += step;
                        label1.Text = $"Progressing...  {progressBar1.Value}%";
                    }
                }
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                label2.Text = "Progressing...  0%";
                Random random = new Random();
                while (progressBar2.Value < 100)
                {
                    int step = random.Next(1, 6);
                    Thread.Sleep(random.Next(0, 2000));
                    if (progressBar2.Value + step > 100)
                    {
                        progressBar2.Value = 100;
                        label2.Text = $"All done";
                    }
                    else
                    {
                        progressBar2.Value += step;
                        label2.Text = $"Progressing...  {progressBar2.Value}%";
                    }
                }
            });
        }
    }
}
