using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FisrtName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FisrtName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FisrtName;
                }
                return fullName;
            }
        }
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates The Customer Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieves one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //code that retrieves the defined customer

            return new Customer();
        }
        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retieve()
        {
            //code that retrieves all of the customers
            return new List<Customer>();
        }
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves the defined customer

            return true;
        }
    }
}
