using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class Customer : Person
    {
        private int CustomerNo_l = 0;

        public int getCustomer_m()
        {
            return CustomerNo_l;
        }
        public void setCustomerNo_(int TempCustomerNo_l)
        {
            CustomerNo_l = TempCustomerNo_l;
        }
    }
}
