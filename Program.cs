using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            //{
            //  [Erişim Belirleyici][Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici][Veri Tipi] MetotAdi[Parametre Listesi];
            //  {
                //Metot Komutları
            //  }    
            //}

            //Erişim Belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protected

            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Ayşe";
            calisan1.SoyAd = "Kara";
            calisan1.No=23425634;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileriListele();
            System.Console.WriteLine("*********************");

            Calisan calisan2 = new Calisan();

            calisan2.Ad="Deniz";
            calisan2.SoyAd="Arda";
            calisan2.No= 25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileriListele();
        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileriListele()
        {
            System.Console.WriteLine("Çalışanın Adı:{0}",Ad);
            System.Console.WriteLine("Çalışanın Soyadı:{0}",SoyAd);
            System.Console.WriteLine("Çalışanın Numarası:{0}",No);
            System.Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }

    }
}
