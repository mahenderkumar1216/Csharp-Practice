using SolidPriciples.Refactored;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.DependecyInjection.LosselyCoupled
{
    public abstract class OrderAbstract
    {
        protected readonly Cart _cart;

        protected OrderAbstract(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // log the order in the database
        }
    }
}