using Sales.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sales.Test
{
    public class EmployeeTest
    {
        [Fact]
        public void Test_EarningsForBaseSalariedEmployee()
        {
            BaseSalariedEmployee bse = new BaseSalariedEmployee(100);           

            decimal exptectedEarnings = 100;

            decimal actualEarnings = bse.Earnings();

            Assert.Equal(exptectedEarnings, actualEarnings);
        }

        [Fact]
        public void Test_EarningsForSalesRepresentive()
        {
            SalesRepresentive sp = new SalesRepresentive(100, 100, 20);     

            decimal exptectedEarnings = 120;

            decimal actualEarnings = sp.Earnings();

            Assert.Equal(exptectedEarnings, actualEarnings);
        }

        [Fact]
        public void Test_GetPaymentAmountForBaseSalariedEmployee()
        {
            BaseSalariedEmployee bse = new BaseSalariedEmployee(100);            

            decimal exptectedPaymentAmount = 85;

            decimal actualPaymentAmount = bse.GetPaymentAmount();

            Assert.Equal(exptectedPaymentAmount, actualPaymentAmount);
        }

        [Fact]
        public void Test_GetPaymentAmountForSalesRepresentive()
        {
            SalesRepresentive sp = new SalesRepresentive(100, 100, 100);

            decimal exptectedPaymentAmount = 170;

            decimal actualPaymentAmount = sp.GetPaymentAmount();

            Assert.Equal(exptectedPaymentAmount, actualPaymentAmount);
        }

        [Theory]
        [InlineData(1, 1)]
        public void Test_BaseSalriedEmployee(decimal salary, decimal expected)
        {

        }

        [Theory]
        [InlineData(1, 1, 1, 1)]
        public void Test_SalesRepresentive(decimal salary, decimal weeklySales, double commisionRate, decimal expected)
        {

        }


        [Fact]
        public void Test_GetTotalPaymentAmount()
        {
            SalesRepresentive employee1 = new SalesRepresentive(100, 100, 100);
            SalesRepresentive employee2 = new SalesRepresentive(40, 90, 50);

            BaseSalariedEmployee employee3 = new BaseSalariedEmployee(70);
            BaseSalariedEmployee employee4 = new BaseSalariedEmployee(60);
            BaseSalariedEmployee employee5 = new BaseSalariedEmployee(20);

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
                employee1, employee2, employee3, employee4, employee5, invoice, invoice2, invoice3
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

            decimal expectedTotal = 1084.75m;

            decimal actualTotal = GetTotalPaymentAmpunt(list);

            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
