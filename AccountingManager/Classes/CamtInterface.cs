using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class CamtInterface
    {
        public CamtSetup CamtSetup_g;
        public JournalLine JournalLine_g;
        public Journal Journal_g;
        public string RefNo_g = string.Empty;
        public int NoRecords_g = 0;
        public decimal TotalAmt_g = 0;
        public int TotalRecord_g = 0;
        public string Currency_g = string.Empty;
        public DateTime Date_g;
        
        public void CamtImport_m(Journal Journal_l, JournalLine JournalLine_l, string FileText_l)
        {

        }
        public void CheckCAMT_m(JournalLine JournaLine_l)
        {

        }
        public void AddBalAccount_m(JournalLine JournalLine_l)
        {

        }
        public void WriteJournalLine_m()
        {

        }
        public void TrimInvoiceNo_m(string InvoiceNo_l)
        {

        }
        public void SaveSourceFile_m()
        {

        }
    }
}
