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
        public static bool SendRequestAddPartner(string name, string mt, string dc, string sdt, string mail)
        {
            return PnDAL.Insert(name,mt,dc,sdt, mail);
        }
        public static bool SendRequestDel(string madt)
        {
            return PnDAL.Del(madt);
        }
        public static PnDAL GetDT(string id)
        {
            return PnDAL.GetDT(id);
        }
        public static bool Update(string id, string name, string mt, string dc, string sdt, string mail)
        {
            return PnDAL.Update(id, name, mt,dc, sdt,mail);
        }
    }
}
