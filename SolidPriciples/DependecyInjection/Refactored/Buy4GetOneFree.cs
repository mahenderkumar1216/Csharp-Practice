using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public class Buy4GetOneFree : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            int setsOfFive = item.Quantity / 5;
            total -= setsOfFive * 1m;
            return total;
        }        

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("B4GO_APPLE");
        }
    }
}