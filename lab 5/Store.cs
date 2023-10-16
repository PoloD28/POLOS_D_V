using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Store : ISearchable
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; } = new List<User>();

        public List<Product> SearchByPrice(double price)
        {
            return Products.FindAll(product => product.Price <= price);
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.FindAll(product => product.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> SearchByRating(int rating)
        {
            return Products.FindAll(product => product.Rating >= rating);
        }
    }
}
