using SolidPriciples.Refactored;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.DependecyInjection.LosselyCoupled
{
    public class CashOrder:OrderAbstract
    {
        public CashOrder(Cart cart):base(cart)
        {

        }
    }
}