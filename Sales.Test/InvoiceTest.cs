using Sales.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace Sales.Test
{
    public class InvoiceTest
    {
        [Fact]
        public void Test_PaymentAmount()
        {
            Product product1 = new Product()
            {
                Price = 20,
                Quantity = 3
            };

            Product product2 = new Product()
            {
                Price = 60,
                Quantity = 1
            };

            List <Product>products = new List<Product>() {
                product1, product2
            };

            var invoice = new Invoice(products);           

            decimal expectedPayment = 120;

            decimal actualPayment = invoice.GetPaymentAmount();

            Assert.Equal(expectedPayment, actualPayment);
        }        
    }
}
