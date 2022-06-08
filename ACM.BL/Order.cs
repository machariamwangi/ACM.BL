using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates The orderData Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        /// <summary>
        /// Retrieves one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined Order

            return new Order();
        }
        /// <summary>
        /// Retrieve all Order
        /// </summary>
        /// <returns></returns>
        public List<Order> Retieve()
        {
            //code that retrieves all of the Order
            return new List<Order>();
        }
        /// <summary>
        /// Saves the current Order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined Order

            return true;
        }
    }
}
