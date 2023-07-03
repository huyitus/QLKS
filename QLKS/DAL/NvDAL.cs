using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class NvDAL
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ChucVu { get; set; }
        public NvDAL(string manv, string name, string sdt, string dc, string cv)
        {
            MaNV = manv;
            TenNV = name;
            SDT = sdt;
            DiaChi = dc;
            ChucVu = cv;
        }
        public static List<NvDAL> GetNV()
        {
            string query = "SELECT * FROM QLKS.NHANVIEN";

            List<NvDAL> nvv = new List<NvDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var manv = reader.GetString(0);
                    var name = reader.GetString(1);
                    var sdt = reader.GetString(3);
                    var dc = reader.GetString(2);
                    var cv = reader.GetString(4);

                    var nv = new NvDAL(manv, name, sdt, dc, cv);
                    nvv.Add(nv);
                }
            }

            return nvv;
        }
        public static bool Insert(string name, string dc, string sdt, string cv)
        {
            string query = string.Format("INSERT INTO QLKS.NHANVIEN VALUES(' ','{0}', '{1}', '{2}','{3}')",name, dc, sdt, cv);
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
        public static bool Del(string manv)
        {
            string query = string.Format("DELETE FROM QLKS.NHANVIEN WHERE MANV='{0}'", manv);
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
