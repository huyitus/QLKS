using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class CusBAL
    {
        public static void LoadCusInto(DataGridView dgvCus)
        {
            List<CusDAL> cuss = CusDAL.GetCus();
            dgvCus.DataSource = cuss;
        }
    }
}
