using Asp_HW2.Entities;
using System.Collections.Generic;

namespace Asp_HW2.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }

        public ProductViewModel() { }

        public ProductViewModel(List<Product> products)
        {
            Products = products;
        }
    }
}
