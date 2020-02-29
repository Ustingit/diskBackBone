using DiscountPoolBackbone.Models.TOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountPoolBackbone.TopCalculations.Rate
{
    public class CalculateRate : ITopCalculatable
    {
        public decimal Calculate(int topItemId)
        {
            throw new NotImplementedException();
        }

        public decimal Calculate(TopItem topItem)
        {
            decimal rate = 0;

            if (!string.IsNullOrEmpty(topItem.InstagramUrl))
            {

            }

            return rate;
        }
    }
}
