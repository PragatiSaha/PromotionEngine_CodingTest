using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPromotionEngine
{
    class CalculatePromotion
    {
        enum StockPrice
        {
            A = 50,
            B = 30,
            C = 20,
            D = 15
        }
        public void ActivePromotionCalculation(int itemNumber_A, int itemNumber_B, int itemNumber_C, int itemNumber_D)
        {
            double discount_Price = 0.00;
            double totalOrder_Value = 0.00;
            int common_Stock = 0;
            int extra_Stock = 0;

            if(itemNumber_A > 0)
            {
                discount_Price = (itemNumber_A / 3) * 130;
                discount_Price += (itemNumber_A % 3) * (int)StockPrice.A;
                totalOrder_Value += discount_Price;
            }
            if (itemNumber_B > 0)
            {
                discount_Price = 0.00;
                discount_Price = (itemNumber_B / 2) * 45;
                discount_Price += (itemNumber_B % 2) * (int)StockPrice.B;
                totalOrder_Value += discount_Price;
            }
            if(itemNumber_C == itemNumber_D)
            {
                discount_Price = 0.00;
                discount_Price = itemNumber_C * 30;
                totalOrder_Value += discount_Price;
            }
            else
            {
                if(itemNumber_C > itemNumber_D)
                {
                    common_Stock = itemNumber_D;
                    extra_Stock = itemNumber_C - itemNumber_D;
                    discount_Price = 0.00;
                    discount_Price = extra_Stock * (int)StockPrice.C;
                    totalOrder_Value += discount_Price;
                }
                else if (itemNumber_D > itemNumber_C)
                {
                    common_Stock = itemNumber_C;
                    extra_Stock = itemNumber_D - itemNumber_C;
                    discount_Price = 0.00;
                    discount_Price = extra_Stock * (int)StockPrice.D;
                    totalOrder_Value += discount_Price;
                }
                else
                {
                    discount_Price = 0.00;
                    discount_Price = common_Stock * 30;
                    totalOrder_Value += discount_Price;
                }
            }
            Console.Write("Total Order Value: {0}", totalOrder_Value);
            Console.ReadKey();
        }
    }
}
