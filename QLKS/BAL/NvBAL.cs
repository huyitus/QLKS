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
        public static bool SendRequestAddNV(string name, string dc, string sdt, string cv)
        {
            return NvDAL.Insert(name,dc,sdt,cv);
        }
        public static bool SendRequestDelNV(string manv)
        {
            return NvDAL.Del(manv);
        }
    }
}
