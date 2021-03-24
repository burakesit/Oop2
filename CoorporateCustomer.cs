using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    // Aşağıda yazılan class CoorporateCustomer:Customer şeklinde yazılan kısım miras (inhabetıns) gibi birşeydir.Yani Customer özelliklerinin hepsi Coorporae.Cust. içinde geçerlidir.Yani ana başlık Customer alt başlık Coorporate Customer dır.
    class CoorporateCustomer:Customer
    {
        
        public string CompanyName { get; set; }
        public string TasksNumber { get; set; }
    }
}
