using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class DvBAL
    {
        public static void LoadDVInto(DataGridView dtg_DV)
        {
            List<DvDAL> nvs = DvDAL.GetDV();
            dtg_DV.DataSource = nvs;
        }
    }
}
