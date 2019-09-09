using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public class EachPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 5m;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("EACH");
        }
    }
}