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

            decimal exptectedEarnings = 100;

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

            decimal exptectedEarnings = 85;

            decimal actualEarnings = sp.GetPaymentAmount();

            Assert.Equal(exptectedEarnings, actualEarnings);
        }
    }
}
