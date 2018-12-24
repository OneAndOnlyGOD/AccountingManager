using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class Account : Address
    {
        private int AccountNo_l = 0;
        private int ClearingNo_l = 0;
        private int BankAccountNo_l = 0;
        private string PaymentType_l = string.Empty;
        private string SWIFTCode_l = string.Empty;
        private int PostAccountNo_l = 0;
        private string ESRType_l = string.Empty;
        private int ESRAccountNo_l = 0;
        private string IBAN_l = string.Empty;
        private string CurrencyCode_l = string.Empty;
        private string PaymentTermsCode_l = string.Empty;

        public int getAccountNo_m()
        {
            return AccountNo_l;
        }
        public void setAccountNo_m(int TempAccountNo_l)
        {
            AccountNo_l = TempAccountNo_l;
        }
        public int getClearingNo_m()
        {
            return ClearingNo_l;
        }
        public void setClearingNo_m(int TempClearingNo_l)
        {
            ClearingNo_l = TempClearingNo_l;
        }
        public int getBankAccountNo_m()
        {
            return BankAccountNo_l;
        }
        public void setBankAccountNo_m(int TempBankAccountNo_l)
        {
            BankAccountNo_l = TempBankAccountNo_l;
        }
        public string getpaymentType_m()
        {
            return PaymentType_l;
        }
        public void setPaymentType_m(string TempPaymentType_l)
        {
            PaymentType_l = TempPaymentType_l;
        }
        public string getSWIFTCode_m()
        {
            return SWIFTCode_l;
        }
        public void setSWIFTCode_m(string TempSWIFTCode_l)
        {
            SWIFTCode_l = TempSWIFTCode_l;
        }
        public int getPostAccountNo_m()
        {
            return PostAccountNo_l;
        }
        public void setPostAccountNo_m(int TempPostAccountNo_l)
        {
            PostAccountNo_l = TempPostAccountNo_l;
        }
        public string getESRType_m()
        {
            return ESRType_l;
        }
        public void setESRType_m(string TempESRType_l)
        {
            ESRType_l = TempESRType_l;
        }
        public int getESRAccountNo_m()
        {
            return ESRAccountNo_l;
        }
        public void setESRAccountNo_m(int TempESRAccountNo_l)
        {
            ESRAccountNo_l = TempESRAccountNo_l;
        }
        public string getIBAN_m()
        {
            return IBAN_l;
        }
        public void setIBAN_m(string TempIBAN_l)
        {
            IBAN_l = TempIBAN_l;
        }
        public string getCurrencyCode_m()
        {
            return CurrencyCode_l;
        }
        public void setCurrencyCode_m(string TempCurrencyCode_l)
        {
            CurrencyCode_l = TempCurrencyCode_l;
        }
        public string getPaymentTermsCode_m()
        {
            return PaymentTermsCode_l;
        }
        public void setPaymentTermsCode_m(string TempPaymentTermsCode_l)
        {
            PaymentTermsCode_l = TempPaymentTermsCode_l;
        }
    }
}
