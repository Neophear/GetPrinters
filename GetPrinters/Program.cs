using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace GetPrinters
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var printServer = new PrintServer(@"\\TRR-I-SRV2"))
            {
                foreach (var queue in printServer.GetPrintQueues())
                {
                    if (!queue.IsShared)
                    {
                        continue;
                    }
                    Console.WriteLine($"{queue.Name} \t {queue.QueuePort.Name}");
                    //Console.WriteLine(queue.PropertiesCollection.GetProperty(""));
                    //Console.WriteLine(queue.PropertiesCollection[""]);
                    //foreach (System.Collections.DictionaryEntry item in queue.PropertiesCollection)
                    //{
                    //    Console.WriteLine($"{item.Key}: {item.Value.ToString()}");
                    //}
                }
            }

            Console.ReadKey();
        }
    }
}
