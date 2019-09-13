using SCM.DAL.Customer_TDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM.BusinessLogicLayer
{
  public  class Customer
    {
        public DataTable CustomerCRUD(int intPart,int intCustomer,string strCustomerName, int intUnitId,string strMobileNo,string strAddress,decimal creditBlance,decimal openningBalance,int intActionBy,ref string msg)
        {
            try
            {
                SprCustomerCreateTableAdapter adp = new SprCustomerCreateTableAdapter();
                return adp.GetCustomerData(intPart, intCustomer, strCustomerName, intUnitId, strMobileNo, strAddress, creditBlance, openningBalance, intActionBy, ref msg);

            }
            catch (Exception ex){ return  new  DataTable(); }
            
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
