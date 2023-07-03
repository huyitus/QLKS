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
        public static bool Insert(string nd)
        {
            string query = string.Format("INSERT INTO QLKS.QUYDINH VALUES(' ','{0}')", nd);
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool Del(string maqd)
        {
            string query = string.Format("DELETE FROM QLKS.QUYDINH WHERE MAQD='{0}'", maqd);
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static RuleDAL GetRule(string id)
        {
            string query = "SELECT * FROM QLKS.QUYDINH WHERE MAQD='" + id + "'";

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var maqd = reader.GetString(0);
                    var nd = reader.GetString(1);

                    var qd = new RuleDAL(maqd,nd);
                    return qd;
                }
            }

            return null;
        }
        public static bool Update(string id, string nd)
        {
            string query = string.Format("UPDATE QLKS.QUYDINH SET NOIDUNG='{0}' WHERE MAQD='{1}'", nd, id);
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
