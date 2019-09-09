using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidPriciples.Services
{
    public class InventorySystem
    {
        public void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}