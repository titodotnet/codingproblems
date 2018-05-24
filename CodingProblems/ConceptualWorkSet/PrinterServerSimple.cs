using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConceptualWorkSet
{
    class PrinterServerSimple
    {
        public static void Main()
        {
            Semaphore semaphore = new Semaphore(initialCount: 3, maximumCount: 3, name: "PrinterPool");
            PrinterServerSimpleProcessor printerProcessor = new PrinterServerSimpleProcessor();

            for (int i = 0; i < 20; i++)
            {
                string jobName = $"JobProcess{i}";
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine($"Job {jobName} : Acquiring process");
                    semaphore.WaitOne();
                    Console.WriteLine($"Job {jobName} : Acquired process");
                    printerProcessor.ProcessPrint(jobName);
                    semaphore.Release();
                });
            }
            
            Console.ReadKey();
        }
    }

    class PrinterServerSimpleProcessor
    {
        public void ProcessPrint(string jobId)
        {
            Console.WriteLine($"Job {jobId} : Printing in progress......");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine($"Job {jobId} : Printing completed");
        }
    }
}
