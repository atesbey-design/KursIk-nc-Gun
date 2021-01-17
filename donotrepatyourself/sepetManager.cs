using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class sepetManager
    {// naming convertion
        public void Ekle(Urun urun)//Normal parantez() olan yerde anlayın ki metod geçiyor
        {
            Console.WriteLine("Tebrikler...Sepete eklendi :"+ urun.UrunAdı); //Alınan parametre sayesinde istenilen ürümüm adını yazdırdık..Buradaki urun geneldir.İçerisine değeri sen verirsin
        }
        public void Ekle2(string UrunAdı,string Açıklama,double Fiyat)
        {
            Console.WriteLine("Tebrikler...Sepete eklendi :" + UrunAdı);
        }
    }
}
