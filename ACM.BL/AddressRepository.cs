using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieves address data
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            //create the instance of the address class 
            //pass in the requested id
            Address address = new Address(addressId);


            //code that retrieves the defined address

            //Temporary hard coded values to return
            //a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "BagShot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Midle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //code that retrieves the defined address
            //for the customer.

            //Temporary hard-coded values to return a set of address from a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "BagShot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Midle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag End2",
                StreetLine2 = "BagShot row2",
                City = "Hobbiton2",
                State = "Shire2",
                Country = "Midle Earth2",
                PostalCode = "1442",
            };
            addressList.Add(address);
            return addressList;
        }

        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            //code that saves the passed in address
            return true;
        }
    }
}
