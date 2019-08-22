using Sales.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace Sales.Test
{
    public class InvoiceTest
    {
        [Fact]
        public void Test1_PaymentAmount()
        {
            Product product1 = new Product("", 20, 3);

            Product product2 = new Product("", 60, 1);
            
            List <Product>products = new List<Product>() {
                product1, product2
            };

            var invoice = new Invoice(products);           

            decimal expectedPayment = 120;

            decimal actualPayment = invoice.GetPaymentAmount();

            Assert.Equal(expectedPayment, actualPayment);
        }

        [Fact]
        public void Test_GetTotalPaymentAmount()
        {
            Product product1 = new Product("", 20, 3);

            Product product2 = new Product("", 60, 1);

            List<Product> products = new List<Product>() {
                product1, product2
            };

            var invoice = new Invoice(products);

            Product product3 = new Product("", 50, 5);

            Product product4 = new Product("", 100, 1);

            List<Product> products2 = new List<Product>() {
                product3, product4
            };

            var invoice2 = new Invoice(products2);


            Product product5 = new Product("", 10, 20);

            Product product6 = new Product("", 5, 9);

            List<Product> products3 = new List<Product>() {
                product5, product6
            };

            var invoice3 = new Invoice(products3);

            List<IPayable> list = new List<IPayable>()
            {
                invoice, invoice2, invoice3
            };

            decimal GetTotalPaymentAmpunt(List<IPayable> IPayables)
            {
                decimal sum = 0;
                 
                foreach (var item in IPayables)
                {
                    sum += item.GetPaymentAmount();
                }
                return sum;                 
            }

            decimal expected = 715;

            decimal actual = GetTotalPaymentAmpunt(list);

            Assert.Equal(expected, actual);
        }
    }
}
