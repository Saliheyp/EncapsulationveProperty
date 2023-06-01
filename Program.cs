using System;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Ayse";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;
            ogrenci.OgrenciBilgileriGetir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();
            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.OgrenciBilgileriGetir();
            ogrenci1.SinifDüsür();
            ogrenci1.SinifDüsür();
            ogrenci1.OgrenciBilgileriGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        { 
            get {return isim;}
            set {isim = value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif {
         get => sinif;
         set {
            if(value < 1)
            {
                Console.WriteLine("Sinif en az 1 olabilir");
                sinif =1;
            }
            else
            sinif = value; 
            }}

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("******* Ohrenci biligleri ********");
            Console.WriteLine("Ogrenci Adı      :{0}",this.Isim);
            Console.WriteLine("Ogrenci Soyadı      :{0}",this.Soyisim);
            Console.WriteLine("Ogrenci No      :{0}",this.OgrenciNo);
            Console.WriteLine("Ogrenci Sınıfı      :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;
        }
        public void SinifDüsür()
        {
            this.Sinif = this.Sinif-1;
        }
    }
}