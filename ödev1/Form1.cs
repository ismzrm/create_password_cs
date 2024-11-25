namespace ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void hesapla(int seviye)
        {
            string sifre = "";
            char[] dizi = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmöç.,*_-!+/".ToArray();
            Random karıstır = new Random();

            for (int i = 0; i <= seviye; i++)
            {
                sifre += dizi[karıstır.Next(dizi.Count())];
                
            }
            listBox1.Items.Add(sifre);
            
        
        }
        int seviye;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("LÜTFEN SEVİYE SEÇİNİZ!!!");
                return;
            }
            if (comboBox1.SelectedIndex == 0) { seviye = 4; }
            if (comboBox1.SelectedIndex == 1) { seviye = 8; }
            if (comboBox1.SelectedIndex == 2) { seviye = 12; }

            hesapla(seviye);

           
            
        }
    }
}
