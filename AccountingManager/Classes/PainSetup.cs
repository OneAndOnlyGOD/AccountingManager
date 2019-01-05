using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class PainSetup : Account
    {
        private bool SEPAPayment_l = true;
        private string PAINBIC_l = string.Empty;
        private string PainVersionNo_l = string.Empty;
        private string FilePath_l = string.Empty;
        private string FileName_l = string.Empty;
        private int FileNo_l = 0;
        private string MessageId_l = string.Empty;
        private string PaymentId_l = string.Empty;
        private string DetailsId_l = string.Empty;
        private string EndToEndId_l = string.Empty;

        public bool getSEPAPayment_m()
        {
            return SEPAPayment_l;
        }
        public void setSEPAPayment_m(bool TempSEPAPayment_l)
        {
            SEPAPayment_l = TempSEPAPayment_l;
        }
        public string getPAINBIC_m()
        {
            return PAINBIC_l;
        }
        public void setPAINBIC_m(string TempPAINBIC)
        {
            PAINBIC_l = TempPAINBIC;
        }
        public string getPainVersionNo_m()
        {
            return PainVersionNo_l;
        }
        public string getFilePath_m()
        {
            return FilePath_l;
        }
        public void setFilePath_m(string TempFilePath_l)
        {
            FilePath_l = TempFilePath_l;
        }
        public string getFileName_m()
        {
            return FileName_l;
        }
        public void setFileName_m(string TempFileName_l)
        {
            FileName_l = TempFileName_l;
        }
        public int getFileNo_m()
        {
            return FileNo_l;
        }
        public void setFileNo_m(int TempFileNo_l)
        {
            FileNo_l = TempFileNo_l;
        }
        public string getMessageId_m()
        {
            return MessageId_l;
        }
        public void setMessageId_m(string TempMessageId_l)
        {
            MessageId_l = TempMessageId_l;
        }
        public string getPaymentId_m()
        {
            return PaymentId_l;
        }
        public void setPaymentId_m(string TempPaymentId_l)
        {
            PaymentId_l = TempPaymentId_l;
        }
        public string getDetailsId_m()
        {
            return DetailsId_l;
        }
        public void setDetailsId_m(string TempDetailsId_l)
        {
            DetailsId_l = TempDetailsId_l;
        }
        public string getendToEndId_m()
        {
            return EndToEndId_l;
        }
        public void setEndToEndId_m(string TempEndToEndId_l)
        {
            EndToEndId_l = TempEndToEndId_l;
        }
    }
}
