using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class PnDAL
    {
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public string MaTour { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public PnDAL(string madt, string name, string mt, string dc, string sdt, string mail)
        {
            MaDT = madt;
            TenDT = name;
            MaTour = mt;
            DiaChi = dc;
            SDT = sdt;
            Email = mail;
        }
        public static List<PnDAL> GetPartner()
        {
            string query = "SELECT * FROM QLKS.DOITAC ";

            List<PnDAL> partners = new List<PnDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var madt = reader.GetString(0);
                    var name = reader.GetString(1);
                    var mt = reader.GetString(2);
                    var dc = reader.GetString(3);
                    var sdt = reader.GetString(4);
                    var mail = reader.GetString(5);

                    var partner = new PnDAL(madt, name, mt, dc, sdt, mail);
                    partners.Add(partner);
                }
            }

            return partners;
        }
        public static bool Insert(string name, string mt, string dc, string sdt, string mail)
        {
            string query = string.Format("INSERT INTO QLKS.DOITAC VALUES(' ','{0}','{1}','{2}','{3}','{4}')", name, mt, dc, sdt, mail);
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
        public static bool Del(string madt)
        {
            string query = string.Format("DELETE FROM QLKS.DOITAC WHERE MADT='{0}'", madt);
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
        public static PnDAL GetDT(string id)
        {
            string query = "SELECT * FROM QLKS.DOITAC WHERE MADT='" + id + "'";

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var madt = reader.GetString(0);
                    var name = reader.GetString(1);
                    var mt = reader.GetString(2);
                    var dc = reader.GetString(3);
                    var sdt = reader.GetString(4);
                    var mail = reader.GetString(5);

                    var dt = new PnDAL(madt, name, mt, dc, sdt, mail);
                    return dt;
                }
            }

            return null;
        }
        public static bool Update(string id,string name, string mt, string dc, string sdt, string mail)
        {
            string query = string.Format("UPDATE QLKS.DOITAC SET TENDT='{0}', MATOUR='{1}', DIACHI='{2}', SDT='{3}', EMAIL='{4}' WHERE MADT='{5}'", name, mt,dc, sdt,mail, id);
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
