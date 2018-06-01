using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.ArraySet
{
    class StockBuySell
    {
        public static void Main()
        {
            StockBuySellProcessor processor = new StockBuySellProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class StockBuySellProcessor
    {
        public void Process()
        {
            int[] array = { 100, 180, 260, 310, 40, 535, 695 };
            StockBuySell(array);
        }

        private void StockBuySell(int[] array)
        {
            int length = array.Length;
            int i = 0;
            List<BuySellInterval> intervals = new List<BuySellInterval>();

            while (i < length - 1)
            {
                if (length <= 1)
                {
                    Console.WriteLine("Invalid array size");
                    return;
                }

                while ((i < length - 1) && (array[i + 1] <= array[i]))
                {
                    i++;
                }

                if (i >= length - 1)
                {
                    break;
                }

                BuySellInterval interval = new BuySellInterval();
                interval.Buy = array[i];

                i++;

                while ((i < length) && (array[i] > array[i - 1]))
                {
                    i++;
                }

                interval.Sell = array[i - 1]; // i-1 is needed as during the final condition, the i is incremented. A in the condition we're checking a[i] with a[i-1].
                
                intervals.Add(interval);
            }

            foreach (var item in intervals)
            {
                Console.WriteLine($"Buy: {item.Buy}  Sell {item.Sell}");
            }
        }

        class BuySellInterval
        {
            public int Buy { get; set; }
            public int Sell { get; set; }
        }
    }
}
