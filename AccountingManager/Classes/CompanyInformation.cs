using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager.Classes
{
    class CompanyInformation : Address
    {
        private string Name_l = string.Empty;
        private string Phone_l = string.Empty;
        private string HomePage_l = string.Empty;

        public string getName_m()
        {
            return Name_l;
        }
        public void setName_m(string TempName_l)
        {
            Name_l = TempName_l;
        }
        public string getPhone_m()
        {
            return Phone_l;
        }

        public void setPhone_m(string TempPhone_l)
        {
            Phone_l = TempPhone_l;
        }
        public string getHomePage_m()
        {
            return HomePage_l;
        }
        public void setHomePage_m(string TempHomePage_l)
        {
            HomePage_l = TempHomePage_l;
        }
    }
}
