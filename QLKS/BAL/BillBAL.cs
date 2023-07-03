using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class BillBAL
    {
        public static void LoadBillInto(DataGridView dgv_hd)
        {
            List<BillDAL> bills = BillDAL.GetBill();
            dgv_hd.DataSource = bills;
        }
    }
}
