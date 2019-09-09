using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public class Cart
    {
        private readonly List<OrderItem> _items;
        private readonly IPricingCalculator _pricingCalculator;

        public Cart(IPricingCalculator pricingCalculator)
        {
            _pricingCalculator = pricingCalculator;
            _items = new List<OrderItem>();
        }
        public Cart():this(new PricingCalculator())
        { }

        

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }

        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in Items)
            {
                total += _pricingCalculator.CalculatePrice(orderItem);
                // more rules are coming!
            }
            return total;
        }
    }
}