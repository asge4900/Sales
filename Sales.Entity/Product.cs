using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public class Product : Entity
    {
        #region Fields
        protected string name;
        protected decimal price;
        protected int quantity;
        #endregion

        #region Constructors
        public Product()
        {

        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #endregion
    }
}
