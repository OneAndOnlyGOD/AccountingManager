using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class Person : Address
    {
        private string PreName_l = string.Empty;
        private string Name_l = string.Empty;
        private string CompanyName_l = string.Empty;

        public string getPreName_m()
        {
            return PreName_l;
        }
        public void setPreName_m(string TempPreName_l)
        {
            PreName_l = TempPreName_l;
        }
        public string getName_m()
        {
            return Name_l;
        }
        public void setName_m(string TempName_l)
        {
            Name_l = TempName_l;
        }
        public string getCompanyName_m()
        {
            return CompanyName_l;
        }

        public void setCompanyName_m(string TempCompanyName_l)
        {
            CompanyName_l = TempCompanyName_l;
        }
    }
}
