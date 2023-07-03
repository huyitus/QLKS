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
        public static bool SendRequestAddCus(string name, string sdt, string dc, string email, string fax, string group, string amount)
        {
            return CusDAL.Insert(name, dc, sdt, email, fax, group, amount);
        }
        public static CusDAL GetCus(string tenkh)
        {
            return CusDAL.GetCus(tenkh);
        }
        public static bool Update(string id, string name, string sdt, string dc, string email, string fax, string group, string amount)
        {
            return CusDAL.Update(id, name, dc, sdt, email, fax, group, amount);
        }
        public static bool SendRequestDelKH(string tenkh)
        {
            return CusDAL.Del(tenkh);
        }
    }
}
