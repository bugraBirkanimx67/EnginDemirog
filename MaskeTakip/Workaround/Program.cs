//string Selamver = "Selam";
//double tutar = 22;
//int Sayı = 1000;
//bool GirişYaptımı = false;

//Console.WriteLine(Selamver);

internal class Program
{
    private static void Main(string[] args)
    {
        Vatandas vatandas = new Vatandas();
        vatandas.Ad = "Buğra";
        vatandas.Soyad = "Birkanım";
        vatandas.Yas = 2000;
        vatandas.Tc = 22222222222;

        
        Selamver("buğra");

        //diziler
        //string ogrenci1 = "Berkay ";
        //string ogrenci2 = "Ali";
        //string ogrenci3 = "Mert";

        string[] ogrenciler = new string[3];

        ogrenciler[0] = "Berkay";
        ogrenciler[1] = "Ali";
        ogrenciler[0] = "Mert";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }
        string[] sehirler = new[] { "adana", "zonguldak" };
        string[] sehirler2 = new[] { "adana", "muş ", "zonguldak" };
        sehirler = sehirler2;
        sehirler[0] = "adana";
        Console.WriteLine(sehirler2[0]);

        foreach (var sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirleri = new List<string> { "izmir", "adana", "elazığ" };

        yeniSehirleri.Add("zonguldak");

        foreach (var sehir in yeniSehirleri)
        {
            Console.WriteLine(sehir);
        }


       

        // string de fbir referans tiptir 
        static void Selamver(string isim = "")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        PttMnager pttMnager = new PttMnager(new personMnager());
        pttMnager.GiveMsk(person);
        Console.ReadLine();

        Person person = new Person();

        person.FirsName = "BUĞRA";
        person.NameLast = "BİRKANIM";
        person.NationalIdentitiy = 123;
        person.DateOfBirthYear = 2000;
    }
}

public class Vatandas
        {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public long Tc { get; set; }

         }
 
