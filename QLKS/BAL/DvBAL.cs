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
        public static bool SendRequestAddDV(string name, string gia)
        {
            return DvDAL.Insert(name, gia);
        }
        public static bool SendRequestDel(string madv)
        {
            return DvDAL.Del(madv);
        }
        public static DvDAL GetDV(string id)
        {
            return DvDAL.GetDV(id);
        }
        public static bool Update(string id, string name, string gia)
        {
            return DvDAL.Update(id, name, gia);
        }
    }
}
