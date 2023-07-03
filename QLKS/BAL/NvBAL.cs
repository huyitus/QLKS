using QLKS.DAL;
using QLKS.GUI;

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

        public static NvDAL GetNV(string id)
        {
            return NvDAL.GetNV(id);
        }

        public static bool Update(string id, string name, string addr, string sdt, string pos)
        {
            return NvDAL.Update(id, name, addr, sdt, pos);
        }
    }
}
