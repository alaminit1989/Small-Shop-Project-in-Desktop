using SCM.DAL.Customer_TDSTableAdapters;
using SCM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM.BusinessLogicLayer
{
  public  class Customer_BLL
    {
        public DataTable CustomerCRUD(Customers cust, ref string msg)
        {
            try
            {
                SprCustomerCreateTableAdapter adp = new SprCustomerCreateTableAdapter(); 
                return adp.GetCustomerData(cust.intPart, cust.intId, cust.strCustomer, cust.intUnitID, cust.strMobileNo, cust.strAddress, cust.decCreditBlance, cust.decOpeningBlance, cust.intActionBy, ref msg);

            }
            catch (Exception ex){ return  new  DataTable(); }
            
        }
        public DataTable GetCustomer(Customers cust,ref string msg)
        {
            try
            {
                SprCustomerCreateTableAdapter adp = new SprCustomerCreateTableAdapter();
                return adp.GetCustomerData(cust.intPart, cust.intId, cust.strCustomer, cust.intUnitID, cust.strMobileNo, cust.strAddress, cust.decCreditBlance, cust.decOpeningBlance, cust.intActionBy, ref msg);
               

            }
            catch (Exception ex) { return new DataTable(); }
        }
        public DataTable  GetCustomerAll(int intUnitId)
        {
            return new DataTable();

        }
    }
}
