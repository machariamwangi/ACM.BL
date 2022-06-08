using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //create the instance of the product class
            //pass in the request id
            Product product = new Product(productId);

            //code that retrieves the defined product


            //Temporary hard-coded values to return
            //a populated product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted sixe set of 4 bright yellow mini sunflowers";
                product.CurrentPrice = 15.9M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            //code that saves the defined product

            return true;
        }
    }
}
