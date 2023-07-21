namespace otoparkdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Arkaplan Araç1 = null;
        private void btnOlutur_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text == "")
            {
                MessageBox.Show("otopark adý girmelisiniz");
                return;//kodun devamýný engelliyo
            }


            //int32.parse- int32.Tryparse çevirmeye çalýþ olmazsa out deðeri atar
            int Kapasiteçevirme = 0;
            bool ÇevirmeSonuç = Int32.TryParse(txtboxKapasite.Text, out Kapasiteçevirme);
            //çevirme sonucu true çevirme baþþarýlý
            //çevirme sonucu false ise baþarýsýz,
            if (ÇevirmeSonuç == false)
            {
                MessageBox.Show("kapasite sayý olmalý");
                return;//gidiþini engellemeye çalýþtý
            }


            //Arkaplan Araç1=new Arkaplan(txtBoxAd.Text,Int32.Parse(txtboxKapasite.Text));
            Arkaplan Araç1 = new Arkaplan(txtBoxAd.Text, Kapasiteçevirme);
            MessageBox.Show("otopark oluþturuldu");

            btnOlutur.Enabled = false;
            btnSatýþ.Enabled = true;
            btnÝade.Enabled = true;
            btnBakiye.Enabled = true;
            btnKapasite.Enabled = true;


            int a = 5;
            string x = a.ToString();
            //herhangi bir deðeri stringe çeviriyo
            //bazen sýnýfa özel tostring gerekebilir
            //otopark1.Tostring dediðimde bana þunu yaz --> kala yer ve bakiye
            //to string metodunu override etmek gerek clas içinde yaýlýr
            MessageBox.Show(Araç1.ToString());
            //tostring override etmeden içine biþey yazýlmaz default deðer gösterir o da projenin ismidir
        }
        private void btnSatýþ_Click(object sender, EventArgs e)
        {
            //bool ÝndirimDurumu = chcboxStandarmý.Checked;
           
            Araç1.BiletSatýþ(chkboxStandarmý.Checked);
            lblSonuç.Text = "bilet satýldý - kalan yer sayýsý {0}" +Araç1.KalanYerSorgula();
        }
        private void btnÝade_Click(object sender, EventArgs e)
        {
            bool Araçtipi = chkboxStandarmý.Checked;
            Araç1.BiletÝade(Araçtipi);
            lblSonuç.Text = "bilet iade edildi kalan yer sayýsý {0}" + Araç1.KalanYerSorgula() ;

        }
        private void btnBakiye_Click(object sender, EventArgs e)
        {
            lblSonuç.Text = "güncel bakiye:" + Araç1.BakiyeSorgula();
            
        }
        private void btnKapasite_Click(object sender, EventArgs e)
        {
            lblSonuç.Text = "güncel Kapasite:" + Araç1.KalanYerSorgula();
        }
        
    }
}