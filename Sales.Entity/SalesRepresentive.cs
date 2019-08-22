using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public class SalesRepresentive : BaseSalariedEmployee
    {
        #region Fields
        protected decimal weeklySales;
        protected double commisionRate;
        #endregion

        #region Constructors
        public SalesRepresentive(decimal salary, decimal weeklySales, double commisionRate)
            :base(salary)
        {
            WeeklySales = weeklySales;
            CommisionRate = commisionRate;
        }
        public SalesRepresentive(decimal weeklySales, double commisonRate)
            :this(default, weeklySales, commisonRate)
        {

        }
        #endregion

        #region Properties
        public decimal WeeklySales { get => weeklySales; set => weeklySales = value; }
        public double CommisionRate { get => commisionRate; set => commisionRate = value; }
        #endregion

        #region Methods
        public override decimal Earnings()
        {
            return base.Earnings() + (weeklySales/100) * (decimal) commisionRate;
        }
        #endregion
    }
}
