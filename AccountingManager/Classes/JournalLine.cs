using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class JournalLine
    {
        private int JournalNo_l = 0;
        private string DocumentTyp_l = string.Empty;
        private int DocumentNo_l = 0;
        private string AccountType_l = string.Empty;
        private int AccountNo_l = 0;
        private decimal Amount_l = 0;
        private string CurrencyCode_l = string.Empty;
        private int ChargeAccount_l = 0;
        private DateTime BookingDate_l;
        private DateTime DueDate_l;

        public int getJournalNo_m()
        {
            return JournalNo_l;
        }
        public void setJournalNo_m(int TempJournalNo_l)
        {
            JournalNo_l = TempJournalNo_l;
        }
        public string getDocumentTyp_m()
        {
            return DocumentTyp_l;
        }
        public void setDocumentType_m(string TempDocumentType_l)
        {
            DocumentTyp_l = TempDocumentType_l;
        }
        public int  getDocumentNo_m()
        {
            return DocumentNo_l;
        }
        public void setDocumentNo_m(int TempDocumentNo_l)
        {
            DocumentNo_l = TempDocumentNo_l;
        }
        public string getAccountTyp_m()
        {
            return AccountType_l;
        }
        public void setAccountTyp_m(string TempAccountType_l)
        {
            AccountType_l = TempAccountType_l;
        }
        public int getAccountNo_m()
        {
            return AccountNo_l;
        }
        public void setAccountNo_m(int TempAccountNo_l)
        {
            AccountNo_l = TempAccountNo_l;
        }
        public decimal getAmount_m()
        {
            return Amount_l;
        }
        public void setAmount_m(decimal TempAmount_l)
        {
            Amount_l = TempAmount_l;
        }
        public string getCurrencyCode_m()
        {
            return CurrencyCode_l;
        }
        public void setCurrencyCode_m(string TempCurrencyCode_l)
        {
            CurrencyCode_l = TempCurrencyCode_l;
        }
        public int getChargeAccount_m()
        {
            return ChargeAccount_l;
        }
        public void setChargeAccount_m(int TempChargeAccount_l)
        {
            ChargeAccount_l = TempChargeAccount_l;
        }
        public DateTime getBookingDate_m()
        {
            return BookingDate_l;
        }
        public void setBookingDate_m(DateTime TempBookingDate_l)
        {
            BookingDate_l = TempBookingDate_l;
        }
        public DateTime getDueDate_m()
        {
            return DueDate_l;
        }
        public void setDueDate_m(DateTime TempDueDate_l)
        {
            DueDate_l = TempDueDate_l;
        }

    }
}
