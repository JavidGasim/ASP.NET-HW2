using Asp_HW2.Entities;

namespace Asp_HW2.Models
{
    public class UpdateViewModel
    {
        public Product Product { get; set; }

        public UpdateViewModel()
        {
            
        }

        public UpdateViewModel(Product product)
        {
            Product = product;
        }
    }
}
