using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public class Invoice : Entity, IPayable
    {
        #region Fields
        protected List<Product> products;
        #endregion

        #region Constructors
        public Invoice()
        {

        }
        public Invoice(int id, List<Product> products)
            :base(id)
        {
            Products = products;
        }
        public Invoice(List<Product> products)
            :this(default, products)
        {

        }
        #endregion

        #region Properties
        public List<Product> Products { get => products; set => products = value; }
        #endregion

        #region Methods
        public decimal GetPaymentAmount()
        {
            decimal paymentAmount = 0;
            foreach (var product in products)
            {
                paymentAmount += product.Price * product.Quantity;
            }
            return paymentAmount;
        }
        #endregion
    }
}
