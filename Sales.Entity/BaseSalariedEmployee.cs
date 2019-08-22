using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public class BaseSalariedEmployee : Employee
    {
        #region Fields
        protected decimal salary;
        #endregion

        #region Constructors
        public BaseSalariedEmployee(string name, decimal salary)
            :base(name)
        {
            Salary = salary;
        }
        public BaseSalariedEmployee(decimal salary)
            :this(default, salary)
        {

        }
        #endregion

        #region Properties
        public decimal Salary { get => salary; set => salary = value; }
        #endregion

        #region Methods
        public override decimal Earnings()
        {
            return salary;
        }       
        #endregion
    }
}
