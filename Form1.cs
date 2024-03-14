namespace zamanSuracleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 100)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 100)
            {
                dakika = 0;
                saat++;
            }
            labelSalise.Text = salise.ToString();
            labelSaniye.Text = saniye.ToString();
            labelDakika.Text = dakika.ToString();
            labelSaat.Text = saat.ToString();


        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(saat + ":" + dakika + ":" + saniye + ":" + salise);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye=0;
            dakika=0;
            saat=0;
            labelSalise.Text = salise.ToString();
            labelSaniye.Text= saniye.ToString();
            labelDakika.Text= dakika.ToString();
            labelSaat.Text= saat.ToString();
            listBox1.Items.Clear();
        }
    }
}
