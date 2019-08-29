using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolidPriciples.Model;


namespace SolidPriciples.Refactored
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IPriceRule>();
            _pricingRules.Add(new Buy4GetOneFree());
            _pricingRules.Add(new EachPriceRule());
            _pricingRules.Add(new PerGramPriceRule());
            _pricingRules.Add(new SpecialPriceRule());
        }
        public decimal CalculatePrice(OrderItem orderItem)
        {
            return _pricingRules.First(r => r.IsMatch(orderItem)).CalculatePrice(orderItem);
        }
    }
}