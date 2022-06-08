using System;
using Xunit;

namespace ACM.BL.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-Arrange
            Customer customer = new Customer
            {
                FisrtName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void  NewTestOfReferenceType()
        {
            var c1 = new Customer();
            c1.FisrtName = "elijah";

            var c2 = c1;
            c2.FisrtName = "Macharia";

            Console.WriteLine(c1);
            Assert.Equal("Macharia", c1.FisrtName);
        }
    }
}
