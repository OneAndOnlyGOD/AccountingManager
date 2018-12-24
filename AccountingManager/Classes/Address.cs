using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManager
{
    class Address
    {
        private string Address_l = string.Empty;
        private string Address2_l = string.Empty;
        private string Location_l = string.Empty;
        private string PostCode_l = string.Empty;
        private string CountryRegionCode_l = string.Empty;

        public string getAddress_m()
        {
            return Address_l;
        }
        public void setAddress_m(string TempAdress_l)
        {
            Address_l = TempAdress_l;
        }
        public string getAdress2_m()
        {
            return Address2_l;
        }
        public void setAddress2_m(string TempAdress2_l)
        {
            Address2_l = TempAdress2_l;
        }
        public string getLocation_m()
        {
            return Location_l;
        }
        public void setLocation_m(string TempLocation_l)
        {
            Location_l = TempLocation_l;
        }
        public string getPostCode_m()
        {
            return PostCode_l;
        }
        public void setPostCode_m(string TempPostCode_l)
        {
            PostCode_l = TempPostCode_l;
        }
        public string getCountryRegionCode_m()
        {
            return CountryRegionCode_l;
        }
        public void steCountryRegionCode_m(string TempCountryRegionCode_l)
        {
            CountryRegionCode_l = TempCountryRegionCode_l;
        }
    }
}
