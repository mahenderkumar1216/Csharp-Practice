using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public class SpecialPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            // $0.40 each; 3 for a $1.00
            total += item.Quantity * .4m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * .2m;
            return total;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("SPECIAL");
        }
    }
}