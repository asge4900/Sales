using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public abstract class Employee : Entity, IPayable
    {
        #region Fields
        protected string name;
        #endregion

        #region Constructors        
        public Employee(int id, string name)
            :base(id)
        {
            Name = name;
        }
        public Employee(string name)
            :this(default, name)
        {

        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        #endregion

        #region Methods
        public abstract decimal Earnings();       
        public decimal GetPaymentAmount()
        {
            return Earnings() - (Earnings()/100*15);            
        }
        #endregion
    }
}
