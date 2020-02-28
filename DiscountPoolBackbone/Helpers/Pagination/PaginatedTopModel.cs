using DiscountPoolBackbone.Models.Pagination;
using DiscountPoolBackbone.Models.TOP;
using System.Collections.Generic;

namespace DiscountPoolBackbone.Helpers.Pagination
{
    public class PaginatedTopModel
    {
        public IEnumerable<TopItem> TopItems { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
