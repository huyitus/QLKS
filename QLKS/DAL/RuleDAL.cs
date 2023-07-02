using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS.DAL
{
    class RuleDAL
    {
        public string MaQD { get; set; }
        public string NoiDung { get; set; }
        public RuleDAL(string maqd, string nd)
        {
            MaQD = maqd;
            NoiDung = nd;
        }
        public static List<RuleDAL> GetRule()
        {
            string query = "SELECT * FROM QLKS.QUYDINH";

            List<RuleDAL> rules = new List<RuleDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var maqd = reader.GetString(0);
                    var nd = reader.GetString(1);

                    var rule = new RuleDAL(maqd, nd);
                    rules.Add(rule);
                }
            }

            return rules;
        }
    }
}
