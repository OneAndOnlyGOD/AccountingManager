using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class CamtSetup : Account
    {
        private string PaymentType_l = String.Empty;
        private bool AllESRImport_l = true;
        private string Camt053Version_l = string.Empty;
        private string Camt054Version_l = string.Empty;
        private string FilePath_l = string.Empty;
        public string getPaymentType_m()
        {
            return PaymentType_l¨;
        }
        public void setPaymentType_m (string TempPaymentType_l)
        {
            PaymentType_l = TempPaymentType_l;
        }
        public bool getAllESERImport_m()
        {
            return AllESRImport_l;
        }
        public void setAllESRImport_m(bool TempAllESRImport_l)
        {
            AllESRImport_l = TempAllESRImport_l;
        }
        public string getCamt053Version_m()
        {
            return Camt053Version_l;
        }
        public void setCamt053Version_m (string TempCamt053Version_l)
        {
            Camt053Version_l = TempCamt053Version_l;
        }
        public string getCamt054Cersion_m()
        {
            return Camt054Version_l;
        }
        public void setCamt054Version_m(string TempCamt054Version_l)
        {
            Camt054Version_l = TempCamt054Version_l;
        }
        public string getFilePath_m()
        {
            return FilePath_l;
        }
        public void setFilePath_m(string TempFilePath_l)
        {
            FilePath_l = TempFilePath_l;
        }
    }
}
