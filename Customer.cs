using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
    //Class lar 2 tip içerik barındırır bunlardan birisi özellikler diğeri operasyonlardır.İkisi aynı yerde olmaz.
{
    class Customer
    {

        public int Id { get; set; }
        public string CustomerNumber { get; set; }

        //Eğer bir sayısal değer ile işlem yapılmayacaksa bunun string olarak tanımlanması daha verimli sonuçlar oluşturur. Özellikle import işlemlerinde.
    }
}
