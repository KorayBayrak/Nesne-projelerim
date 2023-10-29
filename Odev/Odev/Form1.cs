namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Kullanici_Adi = new List<string>();
        List<string> Kullanici_tlf = new List<string>();
        List<string> Kullanici_sifre = new List<string>();
        int Sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_Adi.Add(textBox1.Text);
            Kullanici_tlf.Add(textBox2.Text);
            Kullanici_sifre.Add(textBox3.Text);
            Sayac++;
        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<Sayac;i++)
            {
                string bilgiler = Kullanici_Adi[i]+ "  " + Kullanici_tlf[i] + "  " + Kullanici_sifre[i];
                listBox1.Items.Add(bilgiler);
                comboBox1.Items.Add(bilgiler);
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }
    }
}