using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class Journal
    {
        private int JournalNo_l = 0;
        private string JournalTyp_l = string.Empty;
        private string JournalName_l = string.Empty;
        private decimal Amount_l = 0;

        public int getJournalNo_m()
        {
            return JournalNo_l;
        }
        public void setJournalNo_m(int TempJournalNo_l)
        {
            JournalNo_l = TempJournalNo_l;
        }
        public string getJournalType_m()
        {
            return JournalTyp_l;
        }
        public void setJournalType_m(string TempJournalType_l)
        {
            JournalTyp_l = TempJournalType_l;
        }
        public string getJournalName_m()
        {
            return JournalName_l;
        }
        public void setJournalName_m(string TempJournalName_l)
        {
            JournalName_l = TempJournalName_l;
        }
        public decimal getAmount_m()
        {
            return Amount_l;
        }
        public void setAmount_m(decimal TempAmount_l)
        {
            Amount_l = TempAmount_l;
        }
    }
}
