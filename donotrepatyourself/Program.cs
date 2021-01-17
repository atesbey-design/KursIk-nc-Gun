using System;

namespace Metodlar

{
    class Program
    {
        static void Main(string[] args)
        {   //Urun.cs den aldığım Urun classını yani sınıfını kullanarak iki tane meyve için sınıfı kullandım
            Urun urun1 = new Urun();
            urun1.UrunAdı = "Elma";
            urun1.Fıyatı = 29;
            urun1.Acıklama = "Amasya elması";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.UrunAdı = "Karpuz";
            urun2.Fıyatı = 23;
            urun2.Acıklama = "taş gibi karpuz";
            urun2.Id = 2;

            //Burada Urunler classı için array yani liste oluşturdum
            Urun[] urunler = new Urun[] {urun1,urun2};
            //Burada oluşturduğum liste içerisinde istenilen şekilde elemena dönderdim.
            foreach(Urun meyve in urunler)
            {
                Console.WriteLine(meyve.UrunAdı+"-"+meyve.Acıklama);
                Console.WriteLine("-----------------------");
            }


            Console.WriteLine("*************METODLAR***************");
            sepetManager sepetmanager = new sepetManager();//Yeni bir sepetmanager tanımladık
            sepetmanager.Ekle(urun1); //sepetmanager içerisinden ekleyi çağırdık
            sepetmanager.Ekle2("elma","güzel",12); //Bu tip bir kullanıs basit düzeyde iş yapabilirken farklı bir değişken verdiğin zaman patlarsın...
            

        }
    }
}
