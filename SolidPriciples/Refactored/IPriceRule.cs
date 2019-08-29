using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem orderItem);

        decimal CalculatePrice(OrderItem item);
    }
}
