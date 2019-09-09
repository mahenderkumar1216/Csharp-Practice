using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public class PerGramPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("WEIGHT");
        }
    }
}