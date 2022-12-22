using System.Collections.Generic;

namespace Online_Shop___BackEnd.Models
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
