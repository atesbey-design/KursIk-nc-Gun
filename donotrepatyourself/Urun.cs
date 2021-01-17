using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun //Bir elemanın ürün olması adına gerekli olan özellikler,Genel anlamda ortak olan elemanlar neler ona bakılır
    {
        public int Id { get; set; }
        public string UrunAdı { get; set; }
        public double Fıyatı { get; set; }
        public string Acıklama { get; set; }
        //public int stokadedi { get; set; } -->ENCAPSULATİON(Class kavramının biz karlarından birtanesi,Verilen metoda veri eklemek yerine classa eklersek patlamayız...)
    }
}
