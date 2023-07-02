using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class PnBAL
    {
        public static void LoadPartnerInto(DataGridView dgv_DT)
        {
            List<PnDAL> partners = PnDAL.GetPartner();
            dgv_DT.DataSource = partners;
        }
    }
}
