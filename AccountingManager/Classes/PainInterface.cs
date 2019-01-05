using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class PainInterface
    {
        public PainSetup PainSetup_g;
        public Journal Journal_g;
        public int CountPmtDetails_g = 0;
        public int CountPayment_g = 0;
        public int I_g = 0;
        public string d_g = string.Empty;
        public decimal TotalPmtAmount_g = 0;
        public int NoOfPmtInfo_g = 0;
        public string PaymentFormCode_g = string.Empty;
        public int CountedJournalLine_g = 0;
        public PainSetup DebitBank_g;
        public bool BatchBooking_g = true;
        public string Prtry_g = string.Empty;
        public decimal Amount_g = 0;
        public bool SummaryCheck_g = true;
        public string SummaryPmtTxt_g = string.Empty;
        public bool SEPAStatus_g = true;
        public bool PrevSEPAStatus_g = true;
        public decimal TotalPmtAmountLCY_g = 0;

        public void CheckAndInitializePainTransaction_m()
        {

        }
        public void ProcessGenJournalLineForPain001_m(JournalLine JournalLine_l)
        {

        }
        public void PrepareFilePain001_m()
        {

        }
        public void FilleESRVarsPain001_m()
        {

        }
        public void WriteGroupHeader_m()
        {

        }
        public void CheckPmtInfoNeeded_m()
        {

        }
        public void WritePmtInfo_m()
        {

        }
        public void WritePmtDetails_m()
        {

        }
        public void WriteNode_m()
        {

        }
        public void CheckMandatoryFields_m(PainSetup PainSetup_l)
        {

        }
        public void CheckAmountPmtInfo_m()
        {

        }
        public void WriteEndTag_m()
        {

        }
        public void CheckAmountCdtTrfTxInf_m()
        {

        }
        public void VendorCheck_m(Vendor Vendor_l)
        {

        }
        public void GetNumber_m()
        {

        }
        public void CheckPaymentForm_m()
        {

        }
        public void GetFormatAmount_m()
        {

        }
        public void GetFormatIBAN_m()
        {

        }
        public void ReplaceSpecialCharacters_m()
        {

        }
        public void ReplaceSymbols_m()
        {

        }
        public void PainFileCloseAndBackup_m()
        {

        }
        public void CountGLLines_m(JournalLine JournalLine_l)
        {

        }
        public void PAINCheckDebitBank_m(JournalLine JournalLine_l)
        {

        }
        public void SummaryPerVendorCkeck_m()
        {

        }
        public void SEPACheck_m()
        {

        }
    }
}
