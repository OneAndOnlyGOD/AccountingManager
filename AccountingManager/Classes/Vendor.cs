using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class Vendor : Person
    {
        private int VendorNo_l = 0;
        private int DebitBank_l = 0;

        public int getVendorNo_m()
        {
            return VendorNo_l;
        }
        public void setVendorNo_(int TempVendorNo_l)
        {
            VendorNo_l = TempVendorNo_l;
        }
        public int getDebitBank_m()
        {
            return DebitBank_l¨;
        }
        public void setDebitBank_m(int TempDebitBank_l)
        {
            DebitBank_l = TempDebitBank_l;
        }
    }
}
