using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class CusDAL
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Doan { get; set; }
        public string SL { get; set; }

        public CusDAL(string makh, string name, string sdt, string dc, string email, string fax)
        { 
            MaKH = makh;
            TenKH = name;
            SDT = sdt;
            DiaChi = dc;
            Email = email;
            Fax = fax;
        }

        public static List<CusDAL> GetCus()
        {
            string query = "SELECT * FROM QLKS.KHACHHANG";

            List<CusDAL> cuss = new List<CusDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var makh = reader.GetString(0);
                    var name = reader.GetString(1);
                    var sdt = reader.GetString(2);
                    var dc = reader.GetString(3);
                    var email = reader.GetString(4);
                    var fax = reader.GetString(5);

                    var cus = new CusDAL(makh, name, sdt, dc, email, fax);
                    cuss.Add(cus);
                }
            }

            return cuss;
        }

        public static CusDAL GetCus(string id)
        {
            string query = "SELECT * FROM QLKS.KHACHHANG WHERE MAKH='" + id + "'";

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var makh = reader.GetString(0);
                    var name = reader.GetString(1);
                    var sdt = reader.GetString(2);
                    var dc = reader.GetString(3);
                    var email = reader.GetString(4);
                    var fax = reader.GetString(5);

                    var kh = new CusDAL(makh, name, sdt, dc, email, fax);
                    return kh;
                }
            }

            return null;
        }

        public static bool Update(string id, string ten, string sdt, string addr, string email, string fax, string doan, string sl)
        {
            string query = string.Format("UPDATE QLKS.KHACHHANG SET TENKH='{0}', SDT='{1}', DIACHI='{2}', EMAIL='{3}', SOFAX='{4}', TENDOAN='{5}', SOLUONGNGUOI='{6}' WHERE MAKH='{7}'", ten, sdt, addr, email, fax, doan, sl, id);
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
        public static bool Del(string id)
        {
            string query = string.Format("DELETE FROM QLKS.KHACHHANG WHERE MAKH='{0}'", id);
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
        public static bool Insert(string name, string sdt, string dc, string email, string fax, string group, string amount)
        {
            string query = string.Format("INSERT INTO QLKS.KHACHHANG VALUES(' ','{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')", name, sdt, dc, email, fax, group, amount);
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
