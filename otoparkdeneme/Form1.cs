namespace otoparkdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Arkaplan Ara�1 = null;
        private void btnOlutur_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text == "")
            {
                MessageBox.Show("otopark ad� girmelisiniz");
                return;//kodun devam�n� engelliyo
            }


            //int32.parse- int32.Tryparse �evirmeye �al�� olmazsa out de�eri atar
            int Kapasite�evirme = 0;
            bool �evirmeSonu� = Int32.TryParse(txtboxKapasite.Text, out Kapasite�evirme);
            //�evirme sonucu true �evirme ba��ar�l�
            //�evirme sonucu false ise ba�ar�s�z,
            if (�evirmeSonu� == false)
            {
                MessageBox.Show("kapasite say� olmal�");
                return;//gidi�ini engellemeye �al��t�
            }


            //Arkaplan Ara�1=new Arkaplan(txtBoxAd.Text,Int32.Parse(txtboxKapasite.Text));
            Arkaplan Ara�1 = new Arkaplan(txtBoxAd.Text, Kapasite�evirme);
            MessageBox.Show("otopark olu�turuldu");

            btnOlutur.Enabled = false;
            btnSat��.Enabled = true;
            btn�ade.Enabled = true;
            btnBakiye.Enabled = true;
            btnKapasite.Enabled = true;


            int a = 5;
            string x = a.ToString();
            //herhangi bir de�eri stringe �eviriyo
            //bazen s�n�fa �zel tostring gerekebilir
            //otopark1.Tostring dedi�imde bana �unu yaz --> kala yer ve bakiye
            //to string metodunu override etmek gerek clas i�inde ya�l�r
            MessageBox.Show(Ara�1.ToString());
            //tostring override etmeden i�ine bi�ey yaz�lmaz default de�er g�sterir o da projenin ismidir
        }
        private void btnSat��_Click(object sender, EventArgs e)
        {
            //bool �ndirimDurumu = chcboxStandarm�.Checked;
           
            Ara�1.BiletSat��(chkboxStandarm�.Checked);
            lblSonu�.Text = "bilet sat�ld� - kalan yer say�s� {0}" +Ara�1.KalanYerSorgula();
        }
        private void btn�ade_Click(object sender, EventArgs e)
        {
            bool Ara�tipi = chkboxStandarm�.Checked;
            Ara�1.Bilet�ade(Ara�tipi);
            lblSonu�.Text = "bilet iade edildi kalan yer say�s� {0}" + Ara�1.KalanYerSorgula() ;

        }
        private void btnBakiye_Click(object sender, EventArgs e)
        {
            lblSonu�.Text = "g�ncel bakiye:" + Ara�1.BakiyeSorgula();
            
        }
        private void btnKapasite_Click(object sender, EventArgs e)
        {
            lblSonu�.Text = "g�ncel Kapasite:" + Ara�1.KalanYerSorgula();
        }
        
    }
}