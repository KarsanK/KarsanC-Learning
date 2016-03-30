using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cassandra;
using Cassandra.Data.Linq;

namespace Cassandra_stress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Started at " + System.DateTime.Now);

            var cluster = Cluster.Builder()
                        .AddContactPoint("127.0.0.1")
                        .Build();

            Metadata metadata = cluster.Metadata;

            var session = cluster.Connect();
            session.CreateKeyspaceIfNotExists("test");
            session.ChangeKeyspace("test");

            var table = session.GetTable<Test>();
            //table.CreateIfNotExists();

            List<Test> testlist = new List<Test>();

            for (int j = 0; j < 10; j++)
            {
                var batch = session.CreateBatch();

                for (int i = 0; i < 10; i++)
                {
                    testlist.Add(new Test { id = System.Guid.NewGuid(), name = "Name " + i, insertUser = "cassandra", insertTimeStamp = System.DateTimeOffset.UtcNow });
                }

                batch.Append(from t in testlist select table.Insert(t));

                try
                {
                    batch.Execute();
                    //Flush();
                }
                catch (WriteTimeoutException ex)
                {
                    Console.WriteLine("WriteTimeoutException hit.  Waiting 20 seconds...");
                    Console.WriteLine(ex.StackTrace);
                    System.Threading.Thread.Sleep(60000);
                }

                batch = null;

                Console.WriteLine("Time elapsed since start is " + sw.ElapsedMilliseconds);
                //}

                var results = (from rows in table where rows.name == "Name 333" select rows).Execute().Count();

                Console.WriteLine(results);

                sw.Stop();

                Console.WriteLine("Processing time was " + sw.Elapsed.Hours.ToString("00") + ":" + sw.Elapsed.Minutes.ToString("00") + ":" + sw.Elapsed.Seconds.ToString("00") + ":" + sw.Elapsed.Milliseconds.ToString("00") + ".");

                Console.ReadLine();
            }
        }

        //[AllowFiltering]
        //[Table("test")]
        public class Test
        {
            //[PartitionKey]
            //[Column("id")]
            public Guid id;
            //[SecondaryIndex]
            //[Column("name")]
            public string name;
                        //[Column("insert_user")]
            public string insertUser;
            public DateTimeOffset insertTimeStamp;
        }
    }
}