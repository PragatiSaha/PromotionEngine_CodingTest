using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPromotionEngine
{
    class PromotionEngine
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Number of item for Stock A: ");
                int itemNumber_A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of item for Stock B: ");
                int itemNumber_B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of item for Stock C: ");
                int itemNumber_C = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of item for Stock D: ");
                int itemNumber_D = Convert.ToInt32(Console.ReadLine());
                 
                if ((itemNumber_A < 0) || (itemNumber_B < 0) || (itemNumber_C < 0) || (itemNumber_D < 0))
                {
                    var exceptionMessage = "Negative number not allowed";
                    throw new ArgumentException(exceptionMessage);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
