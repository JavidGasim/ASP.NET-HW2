using Asp_HW2.Entities;
using System.Drawing;

namespace Asp_HW2.Models
{
    public class AddViewModel
    {
        public Product Product { get; set; }

        public AddViewModel()
        {
            
        }

        public AddViewModel(Product product)
        {
            Product = product;
        }
    }
}
