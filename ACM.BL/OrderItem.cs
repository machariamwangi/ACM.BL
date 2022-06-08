using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Validates The OrderItem Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice== null) isValid = false;
            return isValid;
        }

        /// <summary>
        /// Retrieves one OrderItem
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves the defined OrderItem

            return new OrderItem();
        }
        /// <summary>
        /// Retrieve all OrderItems
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retieve()
        {
            //code that retrieves all of the OrderItems
            return new List<OrderItem>();
        }
        /// <summary>
        /// Saves the current OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined OrderItem

            return true;
        }
    }
}
