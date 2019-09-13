using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM.Model
{
    public class Customers
    {
        public int intPart { get; set; }
        public int intId { get; set; }
        public string strCustomer { get; set; }
        public int intUnitID { get; set; }
        public string strMobileNo { get; set; }
        public string strAddress { get; set; }
        public decimal decCreditBlance { get; set; }
        public decimal decOpeningBlance { get; set; }
        public DateTime dteActionTime { get; set; }
        public bool ysnActive { get; set; }
        public int intActionBy { get; set; }

    }
}
