using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM.BLL
{
  public  class Customer
    {
        public void CreateCustomer(string strCustomerName,string strMobileNo,string strAddress,decimal creditBlance,decimal openningBalance,int intUnitId)
        {

        }
        public DataTable GetCustomer(int intCustId, string strmMobileNo)
        {
            return new DataTable();
        }
        public DataTable  GetCustomerAll(int intUnitId)
        {
            return new DataTable();

        }
    }
}
