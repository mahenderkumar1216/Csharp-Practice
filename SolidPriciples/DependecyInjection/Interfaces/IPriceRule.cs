using SolidPriciples.Model;

namespace SolidPriciples.Refactored
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem orderItem);

        decimal CalculatePrice(OrderItem item);
    }
}
