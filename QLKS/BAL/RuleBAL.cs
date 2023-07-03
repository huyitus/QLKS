using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RuleBAL
    {
        public static void LoadRuleInto(DataGridView dtg_QD)
        {
            List<RuleDAL> rules = RuleDAL.GetRule();
            dtg_QD.DataSource = rules;
        }
        public static bool SendRequestAddRule(string nd)
        {
            return RuleDAL.Insert(nd);
        }
        public static bool SendRequestDel(string maqd)
        {
            return RuleDAL.Del(maqd);
        }
    }

}
