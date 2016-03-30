using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cassandra;
using Cassandra.Data.Linq;

namespace Database_Test
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            var session = cluster.Connect("payment");


            var table = session.GetTable<card>();
            List<card> testlist = new List<card>();
            var resultsStart = (from row in table select row).Execute().Count();
            Console.WriteLine(resultsStart);

            Stopwatch clock = new Stopwatch();
            clock.Start();

            for (int i = 0; i < 10000; i++)
            {

                session.Execute("insert into card(id, paymentcardid,cardholdername,expirydate,paymentcardtoken) values(uuid(),'1234','KKerai',2010,'ksdfhioioEHjsdhfuiHEFHwehWEHFKsdhfiwhtuiwhefjkHSDFHwrh')");
                
            }

            clock.Stop();

            Console.WriteLine("Total Time" + clock.ElapsedMilliseconds.ToString());

            var resultsEnd = (from row in table select row).Execute().Count();
            Console.WriteLine(resultsEnd);

            Console.ReadLine();

        }



        public class card
        {

            public string paymentcardid { get; set; }
            public string addressid { get; set; }
            public string cardholdername { get; set; }
            public int expirydate { get; set; }
            public string paymentcardtoken { get; internal set; }
        }

    }

}
