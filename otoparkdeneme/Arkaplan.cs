using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkdeneme
{
    internal class Arkaplan
    {
        string OtoparkAdı;
        int Kapasite;
        int boşyersayısı;
        int Bakiye;
       
        const int StandartAraç = 20;
        const int BüyükAraç = 50;

        public Arkaplan(string p_otoparkAdı,int p_kapasite)
        {
            OtoparkAdı = p_otoparkAdı;
            Kapasite = p_kapasite;
            Bakiye = 0;
            boşyersayısı = p_kapasite;
        }
        public void BiletSatış(bool StarndartAraçmı)
        {
            boşyersayısı--;
            if (StarndartAraçmı == true)
                Bakiye += StandartAraç;
            else
                Bakiye += BüyükAraç;   
        }
        public void Biletİade(bool StarndartAraçmı)
        {
            boşyersayısı++;
            if (StarndartAraçmı == true)
                Bakiye -= StandartAraç;
            else
                Bakiye -= BüyükAraç;
        }
        public int BakiyeSorgula()
        { return Bakiye; }

        public int KalanYerSorgula()
        { return boşyersayısı;}
        public override string ToString()
        {
            //return base.ToString();//c# ın kendi tostringi default değer
            return "güncel bakiye" + this.Bakiye + "güncel kapasite" + this.Kapasite; 
            //otopark sınfından oluşan nesnenin sonuna tostring yazıldığında bunu yazar
        }


    }
}
