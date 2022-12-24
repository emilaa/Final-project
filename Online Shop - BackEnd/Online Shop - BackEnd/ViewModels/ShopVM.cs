using Online_Shop___BackEnd.Models;
using System.Collections.Generic;

namespace Online_Shop___BackEnd.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Banner> Banners { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public IEnumerable<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
