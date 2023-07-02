using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class NvBAL
    {
        public static void LoadNVInto(DataGridView dgv_NV)
        {
            List<NvDAL> nvv = NvDAL.GetNV();
            dgv_NV.DataSource = nvv;
        }
    }
}
