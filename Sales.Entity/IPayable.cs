using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Entity
{
    public interface IPayable
    {
        decimal GetPaymentAmount();        
    }
}
