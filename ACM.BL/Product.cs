using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; private set; }

        /// <summary>
        /// Validates The Product Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieves one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //code that retrieves the defined product

            return new Product();
        }
        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retieve()
        {
            //code that retrieves all of the products
            return new List<Product>();
        }
        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined product

            return true;
        }
    }
}
