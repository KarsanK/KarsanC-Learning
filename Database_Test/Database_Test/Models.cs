using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Test
{
    class Models
    {

        public class PaymentCards
        {
            public int CardPAN { get; set; }
            public string Name { get; set; }
            public int CVV { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
            
        }

        public class PaymentCardType
        {
            public string Issuer{ get; set; }
            public int Bin { get; set; }
            public int CVV { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

        }






    }
}
