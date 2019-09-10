using SCM.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM
{
    public class BLL
    {
        #region ==== Item ==============================================================================
        public DataTable GetItemData()
        {
            try
            {
                SprItemReportTableAdapter adp = new SprItemReportTableAdapter();
                return adp.GetItemData();
            }
            catch { return new DataTable(); }
        }

        #endregion ======================================================================================











    }
}
