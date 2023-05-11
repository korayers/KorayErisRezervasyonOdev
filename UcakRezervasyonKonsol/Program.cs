using System;
using UcakRezervasyonKonsol.Methods;
using UcakRezervasyonKonsol.Models;

class Program
{
    static void Main(string[] args)
    {
        DosyadanOkuma okuyucu = new DosyadanOkuma();
        DosyayaYazma yazici = new DosyayaYazma();
        List<Ucak> ucaklar = new List<Ucak>();
        List<Lokasyon> konumlar = new List<Lokasyon>();
        Random random = new Random();
        Ucak ucak = new Ucak();


        Console.WriteLine("****************************************************");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("*                   Hoş Geldiniz!                  *");
        Console.WriteLine("*      Uçak Rezervasyon Sistemine Hoşgeldiniz      *");
        Console.WriteLine("*                                                  *");
        Console.WriteLine("****************************************************");

        Console.WriteLine("\n\nUçuş Rotaları");
        konumlar = okuyucu.KonumlariOku();
        foreach (var item in konumlar)
        {
            Console.WriteLine(item.LokasyonNo + ", " + item.Ulke + ", " + item.Sehir + ", " + item.Havaalani + ", " + (item.KapaliMi ? "Kapalı" : "Açık"));
        }

        Console.WriteLine("\nLütfen Nereden Uçmak İstediğinizi Seçiniz (Açık olan havalanlarını tercih ediniz ! ! !)");
        Console.WriteLine("Konum Numarasını giriniz : ");
        int konumNoFrom = Convert.ToInt32(Console.ReadLine());
        if (konumlar[konumNoFrom - 1].KapaliMi)
        {
            while (true)
            {
                Console.WriteLine("Kapalı olan bir konum seçtiniz");
                Console.WriteLine("Konum Numarasını giriniz : ");
                konumNoFrom = Convert.ToInt32(Console.ReadLine());
                if (konumlar[konumNoFrom - 1].KapaliMi == false)
                    break;
            }
        }
        Console.WriteLine("Lütfen Nereye Uçmak İstediğinizi Seçiniz");
        Console.WriteLine("Konum Numarasını giriniz : ");
        int konumNoTo = Convert.ToInt32(Console.ReadLine());
        if (konumlar[konumNoTo - 1].KapaliMi)
        {
            while (true)
            {
                Console.WriteLine("Kapalı olan bir konum seçtiniz");
                Console.WriteLine("Konum Numarasını giriniz : ");
                konumNoTo = Convert.ToInt32(Console.ReadLine());
                if (konumlar[konumNoTo - 1].KapaliMi == false)
                    break;
            }
        }
        Console.WriteLine("\nSeçtiğiniz konumlara ait uçuş bilgileri aşağıdadır : \n");
        List<Ucus> ucuslar = new List<Ucus>();
        ucuslar = okuyucu.UcuslariOku();
        ucaklar = okuyucu.UcaklariOku();
        int kalanKoltuk;
        foreach (var item in ucuslar)
        {
            if (item.Nereden == konumNoFrom && item.Nereye == konumNoTo)
            {
                Console.WriteLine("Uçuş Nnumarası : " + item.UcusNo);
                ucak = ucaklar.FirstOrDefault(u => u.SeriNo == item.UcakSeriNo);
                Console.WriteLine("Uçak Modeli : " + ucak.Model);
                kalanKoltuk = ucaklar.FirstOrDefault(u => u.SeriNo == item.UcakSeriNo).KoltukKapasitesi - item.RezerveYolcuSayisi;
                Console.WriteLine("Kalan Koltuk Sayısı : " + kalanKoltuk);
                Console.WriteLine("Ucuş tarihi : " + item.UcusTarihi + "\n\n\n");
            }
        }
        Console.WriteLine("Listelenen Uçuşlardan birinin numarasını giriniz : ");
        int ucusNo = Convert.ToInt32(Console.ReadLine());

        Musteri musteri = new Musteri();
        Console.WriteLine("İşleminizi tamamlayabilmemiz için aşağıdaki müşteri bilgilerini doldurunuz ");

        Console.WriteLine("Ad : ");
        musteri.Ad = Console.ReadLine();
        Console.WriteLine("SoyAd : ");
        musteri.Soyad = Console.ReadLine();
        Console.WriteLine("Cinsiyet : ");
        musteri.Cinsiyet = Console.ReadLine();
        Console.WriteLine("Yaş : ");
        musteri.Yas = Convert.ToInt32(Console.ReadLine());
        musteri.YasliMi = Convert.ToInt32(musteri.Yas) > 65 ? true : false;
        Console.WriteLine("Herhangi bir engeliniz var mı (E veya H giriniz) : ");
        musteri.EngelliMi = Console.ReadLine() == "E" ? true : false;

        yazici.MusteriKaydet(musteri);

        Rezervasyon rezervasyon = new Rezervasyon();
        rezervasyon.Musteri = musteri;
        rezervasyon.Ucus = ucuslar[ucusNo - 1];
        rezervasyon.KoltukNo = random.Next(1, ucak.KoltukKapasitesi);

        yazici.RezervasyonKaydet(rezervasyon);
        Console.WriteLine("Rezervasyonunuz başarıyla gerçekleşmiştir \n Koltuk Numaranız : "+ rezervasyon.KoltukNo);

    }
}