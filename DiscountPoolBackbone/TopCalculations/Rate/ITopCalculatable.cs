using DiscountPoolBackbone.Models.TOP;

namespace DiscountPoolBackbone.TopCalculations.Rate
{
    public interface ITopCalculatable
    {
        decimal Calculate(int topItemId);
        decimal Calculate(TopItem topItem);
    }
}
